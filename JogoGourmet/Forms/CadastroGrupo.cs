using JogoGourmet.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class CadastroGrupo : Form
    {
        public string NovoGrupo { get { return txtNovoGrupo.Text; } }

        public CadastroGrupo()
        {
            InitializeComponent();
        }
    }
}
