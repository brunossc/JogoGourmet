using System.Windows.Forms;

namespace JogoGourmet
{
    partial class QuestionForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.pnlFirstQuestion = new System.Windows.Forms.Panel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblFisrt = new System.Windows.Forms.Label();
            this.pnlCadastroPrato = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCadastroPrato = new System.Windows.Forms.TextBox();
            this.btnCancelCadastroPrato = new System.Windows.Forms.Button();
            this.btnOkCadastroPrato = new System.Windows.Forms.Button();
            this.QuestionLbl = new System.Windows.Forms.Label();
            this.lblPratoGrupo = new System.Windows.Forms.Label();
            this.pnlDefinirGrupo = new System.Windows.Forms.Panel();
            this.bntAddTipo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCadastroPratoGrupo = new System.Windows.Forms.Button();
            this.btnCancelGrupoPrato = new System.Windows.Forms.Button();
            this.cbGrupoPrato = new System.Windows.Forms.ComboBox();
            this.pnlFirstQuestion.SuspendLayout();
            this.pnlCadastroPrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDefinirGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFirstQuestion
            // 
            this.pnlFirstQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFirstQuestion.Controls.Add(this.btnFirst);
            this.pnlFirstQuestion.Controls.Add(this.lblFisrt);
            this.pnlFirstQuestion.Location = new System.Drawing.Point(2, 2);
            this.pnlFirstQuestion.Name = "pnlFirstQuestion";
            this.pnlFirstQuestion.Size = new System.Drawing.Size(314, 74);
            this.pnlFirstQuestion.TabIndex = 0;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(156, 40);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(36, 24);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "OK";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // lblFisrt
            // 
            this.lblFisrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFisrt.AutoSize = true;
            this.lblFisrt.Location = new System.Drawing.Point(78, 12);
            this.lblFisrt.Name = "lblFisrt";
            this.lblFisrt.Size = new System.Drawing.Size(193, 15);
            this.lblFisrt.TabIndex = 0;
            this.lblFisrt.Text = "Pense em um prato que você gosta";
            // 
            // pnlCadastroPrato
            // 
            this.pnlCadastroPrato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCadastroPrato.Controls.Add(this.pictureBox1);
            this.pnlCadastroPrato.Controls.Add(this.txtCadastroPrato);
            this.pnlCadastroPrato.Controls.Add(this.btnCancelCadastroPrato);
            this.pnlCadastroPrato.Controls.Add(this.btnOkCadastroPrato);
            this.pnlCadastroPrato.Controls.Add(this.QuestionLbl);
            this.pnlCadastroPrato.Location = new System.Drawing.Point(2, 94);
            this.pnlCadastroPrato.Name = "pnlCadastroPrato";
            this.pnlCadastroPrato.Size = new System.Drawing.Size(314, 74);
            this.pnlCadastroPrato.TabIndex = 0;
            this.pnlCadastroPrato.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 36);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtCadastroPrato
            // 
            this.txtCadastroPrato.Location = new System.Drawing.Point(62, 21);
            this.txtCadastroPrato.MaxLength = 30;
            this.txtCadastroPrato.Name = "txtCadastroPrato";
            this.txtCadastroPrato.Size = new System.Drawing.Size(245, 23);
            this.txtCadastroPrato.TabIndex = 2;
            // 
            // btnCancelCadastroPrato
            // 
            this.btnCancelCadastroPrato.Location = new System.Drawing.Point(168, 45);
            this.btnCancelCadastroPrato.Name = "btnCancelCadastroPrato";
            this.btnCancelCadastroPrato.Size = new System.Drawing.Size(67, 24);
            this.btnCancelCadastroPrato.TabIndex = 1;
            this.btnCancelCadastroPrato.Text = "Cancelar";
            this.btnCancelCadastroPrato.UseVisualStyleBackColor = true;
            this.btnCancelCadastroPrato.Click += new System.EventHandler(this.btnCancelCadastroPrato_Click);
            // 
            // btnOkCadastroPrato
            // 
            this.btnOkCadastroPrato.Location = new System.Drawing.Point(129, 45);
            this.btnOkCadastroPrato.Name = "btnOkCadastroPrato";
            this.btnOkCadastroPrato.Size = new System.Drawing.Size(36, 24);
            this.btnOkCadastroPrato.TabIndex = 1;
            this.btnOkCadastroPrato.Text = "OK";
            this.btnOkCadastroPrato.UseVisualStyleBackColor = true;
            this.btnOkCadastroPrato.Click += new System.EventHandler(this.btnOkCadastroPrato_Click);
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Location = new System.Drawing.Point(56, 5);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(141, 15);
            this.QuestionLbl.TabIndex = 0;
            this.QuestionLbl.Text = "Qual prato você pensou ?";
            this.QuestionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPratoGrupo
            // 
            this.lblPratoGrupo.AutoSize = true;
            this.lblPratoGrupo.Location = new System.Drawing.Point(56, 5);
            this.lblPratoGrupo.Name = "lblPratoGrupo";
            this.lblPratoGrupo.Size = new System.Drawing.Size(76, 15);
            this.lblPratoGrupo.TabIndex = 0;
            this.lblPratoGrupo.Text = "O prato {0} é ";
            // 
            // pnlDefinirGrupo
            // 
            this.pnlDefinirGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDefinirGrupo.Controls.Add(this.bntAddTipo);
            this.pnlDefinirGrupo.Controls.Add(this.pictureBox2);
            this.pnlDefinirGrupo.Controls.Add(this.btnCadastroPratoGrupo);
            this.pnlDefinirGrupo.Controls.Add(this.btnCancelGrupoPrato);
            this.pnlDefinirGrupo.Controls.Add(this.cbGrupoPrato);
            this.pnlDefinirGrupo.Controls.Add(this.lblPratoGrupo);
            this.pnlDefinirGrupo.Location = new System.Drawing.Point(2, 179);
            this.pnlDefinirGrupo.Name = "pnlDefinirGrupo";
            this.pnlDefinirGrupo.Size = new System.Drawing.Size(314, 86);
            this.pnlDefinirGrupo.TabIndex = 0;
            this.pnlDefinirGrupo.Visible = false;
            // 
            // bntAddTipo
            // 
            this.bntAddTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntAddTipo.Location = new System.Drawing.Point(285, 27);
            this.bntAddTipo.Name = "bntAddTipo";
            this.bntAddTipo.Size = new System.Drawing.Size(24, 23);
            this.bntAddTipo.TabIndex = 5;
            this.bntAddTipo.Text = "+";
            this.bntAddTipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntAddTipo.UseVisualStyleBackColor = true;
            this.bntAddTipo.Click += new System.EventHandler(this.btnAddTipo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 36);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnCadastroPratoGrupo
            // 
            this.btnCadastroPratoGrupo.Location = new System.Drawing.Point(129, 54);
            this.btnCadastroPratoGrupo.Name = "btnCadastroPratoGrupo";
            this.btnCadastroPratoGrupo.Size = new System.Drawing.Size(36, 28);
            this.btnCadastroPratoGrupo.TabIndex = 1;
            this.btnCadastroPratoGrupo.Text = "OK";
            this.btnCadastroPratoGrupo.UseVisualStyleBackColor = true;
            this.btnCadastroPratoGrupo.Click += new System.EventHandler(this.btnCadastroPratoGrupo_Click);
            // 
            // btnCancelGrupoPrato
            // 
            this.btnCancelGrupoPrato.Location = new System.Drawing.Point(168, 54);
            this.btnCancelGrupoPrato.Name = "btnCancelGrupoPrato";
            this.btnCancelGrupoPrato.Size = new System.Drawing.Size(67, 28);
            this.btnCancelGrupoPrato.TabIndex = 1;
            this.btnCancelGrupoPrato.Text = "Cancelar";
            this.btnCancelGrupoPrato.UseVisualStyleBackColor = true;
            this.btnCancelGrupoPrato.Click += new System.EventHandler(this.btnCancelGrupoPrato_Click);
            // 
            // cbGrupoPrato
            // 
            this.cbGrupoPrato.FormattingEnabled = true;
            this.cbGrupoPrato.Location = new System.Drawing.Point(58, 25);
            this.cbGrupoPrato.Name = "cbGrupoPrato";
            this.cbGrupoPrato.Size = new System.Drawing.Size(221, 23);
            this.cbGrupoPrato.TabIndex = 1;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 268);
            this.Controls.Add(this.pnlDefinirGrupo);
            this.Controls.Add(this.pnlCadastroPrato);
            this.Controls.Add(this.pnlFirstQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Gourmet";
            this.pnlFirstQuestion.ResumeLayout(false);
            this.pnlFirstQuestion.PerformLayout();
            this.pnlCadastroPrato.ResumeLayout(false);
            this.pnlCadastroPrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDefinirGrupo.ResumeLayout(false);
            this.pnlDefinirGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlFirstQuestion;
        private Button btnFirst;
        private Label lblFisrt;
        private Panel pnlCadastroPrato;
        private Label QuestionLbl;
        private Label lblPratoGrupo;
        private Panel pnlDefinirGrupo;
        private Button btnCancelCadastroPrato;
        private Button btnOkCadastroPrato;
        private PictureBox pictureBox1;
        private TextBox txtCadastroPrato;
        private Button btnCadastroPratoGrupo;
        private Button btnCancelGrupoPrato;
        private ComboBox cbGrupoPrato;
        private Button bntAddTipo;
        private PictureBox pictureBox2;
    }
}

