namespace JogoGourmet
{
    partial class CadastroGrupo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNovoGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOKCadastroGrupo = new System.Windows.Forms.Button();
            this.btnCancelCadastroGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNovoGrupo
            // 
            this.txtNovoGrupo.Location = new System.Drawing.Point(38, 26);
            this.txtNovoGrupo.MaxLength = 30;
            this.txtNovoGrupo.Name = "txtNovoGrupo";
            this.txtNovoGrupo.Size = new System.Drawing.Size(161, 23);
            this.txtNovoGrupo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo grupo de pratos:";
            // 
            // btnOKCadastroGrupo
            // 
            this.btnOKCadastroGrupo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKCadastroGrupo.Location = new System.Drawing.Point(62, 55);
            this.btnOKCadastroGrupo.Name = "btnOKCadastroGrupo";
            this.btnOKCadastroGrupo.Size = new System.Drawing.Size(36, 24);
            this.btnOKCadastroGrupo.TabIndex = 1;
            this.btnOKCadastroGrupo.Text = "OK";
            this.btnOKCadastroGrupo.UseVisualStyleBackColor = true;
            // 
            // btnCancelCadastroGrupo
            // 
            this.btnCancelCadastroGrupo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCadastroGrupo.Location = new System.Drawing.Point(101, 55);
            this.btnCancelCadastroGrupo.Name = "btnCancelCadastroGrupo";
            this.btnCancelCadastroGrupo.Size = new System.Drawing.Size(67, 24);
            this.btnCancelCadastroGrupo.TabIndex = 1;
            this.btnCancelCadastroGrupo.Text = "Cancelar";
            this.btnCancelCadastroGrupo.UseVisualStyleBackColor = true;
            // 
            // CadastroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 88);
            this.Controls.Add(this.btnCancelCadastroGrupo);
            this.Controls.Add(this.btnOKCadastroGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNovoGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CadastroGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNovoGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOKCadastroGrupo;
        private System.Windows.Forms.Button btnCancelCadastroGrupo;
    }
}