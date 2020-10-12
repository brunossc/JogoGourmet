using JogoGourmet.Core;
using JogoGourmet.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class QuestionForm : Form
    {
        private readonly IGourmetService _gourmetService;
        private int _currentGrupo;

        public QuestionForm(IGourmetService gourmetService)
        {
            InitializeComponent();
            _gourmetService = gourmetService;
        }

        #region Events

        private void btnFirst_Click(object sender, EventArgs e) => FazerPregunta(1, -1);

        private void btnOkCadastroPrato_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroPrato.Text))
            {
                DialogResult result = MessageBox.Show(GourmetResource.Preenchimento, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Ativarpanel2();
            }
        }

        private void btnAddTipo_Click (object sender, EventArgs e)
        {
            var cadTipoForm = new CadastroGrupo();
            var retorno = cadTipoForm.ShowDialog();

            if (retorno == DialogResult.OK &&
                !string.IsNullOrWhiteSpace(cadTipoForm.NovoGrupo) &&
                !_gourmetService.GrupoExiste(cadTipoForm.NovoGrupo))
            {
                var grupo = new Grupo() { Nome = cadTipoForm.NovoGrupo };
                _gourmetService.SalvarGrupo(grupo);
                _currentGrupo = grupo.Id;
            }

            loadComboGrupos();
            cadTipoForm.Close();
            cadTipoForm.Dispose();
        }

        private void btnCancelCadastroPrato_Click(object sender, EventArgs e) => AtivarpanelPrincipal();

        private void btnCancelGrupoPrato_Click(object sender, EventArgs e) => AtivarpanelPrincipal();

        public void btnCadastroPratoGrupo_Click(object sender, EventArgs e)
        {
            if (!_gourmetService.PratoExiste(txtCadastroPrato.Text))
            {
                var prato = new Prato() { Nome = txtCadastroPrato.Text, GrupoId = (int)cbGrupoPrato.SelectedValue };
                _gourmetService.SalvarPrato(prato);
            }
            else
            {
                DialogResult result = MessageBox.Show(GourmetResource.PratoJaExiste, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AtivarpanelPrincipal();
        }

        #endregion

        #region Helpers

        public void FazerPregunta(int idGrupo, int indexPrato)
        {
            string nome = string.Empty;

            if (indexPrato == -1)
            {
                var grupo = _gourmetService.ObterGrupo(idGrupo);
                if (grupo != null && grupo.Pratos.Any())
                {
                    nome = grupo.Nome;
                }

                idGrupo++;
            }
            else
            {
                nome = _gourmetService.ObterPrato(indexPrato, idGrupo);
                indexPrato++;
            }

            if (string.IsNullOrWhiteSpace(nome))
            {
                _currentGrupo = idGrupo;
                Ativarpanel1();
            }
            else
            {
                ValidarResposta(idGrupo, indexPrato, nome);
            }
        }

        private void ValidarResposta(int idGrupo, int indexPrato, string nome)
        {
            DialogResult result = MessageBox.Show(string.Format(GourmetResource.QuestaoPrato, nome), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                FazerPregunta(idGrupo, indexPrato);
            }
            else if (indexPrato == -1)
            {
                FazerPregunta(--idGrupo, 0);
            }
            else
            {
                MessageBox.Show(GourmetResource.Acerto, "Acertei ! ;)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void loadComboGrupos()
        {
            cbGrupoPrato.DataSource = _gourmetService.ObterGrupos().ToList();
            cbGrupoPrato.DisplayMember = "Nome";
            cbGrupoPrato.ValueMember = "Id";

            if (_currentGrupo != 0)
            {
                cbGrupoPrato.SelectedValue = _currentGrupo;
            }
        }

        public void AtivarpanelPrincipal()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                    c.Visible = false;
            }

            this.Text = "jogo Gourmet";
            pnlFirstQuestion.Visible = true;
        }

        public void Ativarpanel1()
        {
            this.Text = "Desisto :(";
            txtCadastroPrato.Text = string.Empty;
            pnlCadastroPrato.Location = pnlFirstQuestion.Location;
            pnlFirstQuestion.Visible = false;
            pnlCadastroPrato.Visible = true;
        }

        public void Ativarpanel2()
        {
            loadComboGrupos();
            this.Text = "Complete";
            lblPratoGrupo.Text = string.Format(GourmetResource.lblDefiniGrupoPrato, txtCadastroPrato.Text);
            pnlDefinirGrupo.Location = pnlFirstQuestion.Location;
            pnlCadastroPrato.Visible = false;
            pnlDefinirGrupo.Visible = true;
        }

        #endregion
    }
}
