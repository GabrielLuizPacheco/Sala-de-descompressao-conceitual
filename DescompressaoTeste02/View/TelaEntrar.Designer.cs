namespace DescompressaoTeste02.View
{
    partial class TelaEntrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsuarioLogin = new System.Windows.Forms.TextBox();
            this.textBoxSenhaLogin = new System.Windows.Forms.TextBox();
            this.labelEsqueceuSuaSenha = new System.Windows.Forms.Label();
            this.buttonEntrarLogin = new System.Windows.Forms.Button();
            this.labelCadastre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // textBoxUsuarioLogin
            // 
            this.textBoxUsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuarioLogin.Location = new System.Drawing.Point(12, 94);
            this.textBoxUsuarioLogin.Name = "textBoxUsuarioLogin";
            this.textBoxUsuarioLogin.Size = new System.Drawing.Size(252, 22);
            this.textBoxUsuarioLogin.TabIndex = 3;
            // 
            // textBoxSenhaLogin
            // 
            this.textBoxSenhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaLogin.Location = new System.Drawing.Point(12, 157);
            this.textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            this.textBoxSenhaLogin.PasswordChar = '*';
            this.textBoxSenhaLogin.Size = new System.Drawing.Size(252, 22);
            this.textBoxSenhaLogin.TabIndex = 4;
            // 
            // labelEsqueceuSuaSenha
            // 
            this.labelEsqueceuSuaSenha.AutoSize = true;
            this.labelEsqueceuSuaSenha.BackColor = System.Drawing.Color.Transparent;
            this.labelEsqueceuSuaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEsqueceuSuaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEsqueceuSuaSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEsqueceuSuaSenha.Location = new System.Drawing.Point(81, 192);
            this.labelEsqueceuSuaSenha.Name = "labelEsqueceuSuaSenha";
            this.labelEsqueceuSuaSenha.Size = new System.Drawing.Size(116, 13);
            this.labelEsqueceuSuaSenha.TabIndex = 5;
            this.labelEsqueceuSuaSenha.Text = "Esqueceu sua senha ?";
            this.labelEsqueceuSuaSenha.Click += new System.EventHandler(this.labelEsqueceuSuaSenha_Click);
            // 
            // buttonEntrarLogin
            // 
            this.buttonEntrarLogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonEntrarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrarLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonEntrarLogin.Location = new System.Drawing.Point(84, 222);
            this.buttonEntrarLogin.Name = "buttonEntrarLogin";
            this.buttonEntrarLogin.Size = new System.Drawing.Size(113, 23);
            this.buttonEntrarLogin.TabIndex = 6;
            this.buttonEntrarLogin.Text = "Entrar";
            this.buttonEntrarLogin.UseVisualStyleBackColor = false;
            this.buttonEntrarLogin.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // labelCadastre
            // 
            this.labelCadastre.AutoSize = true;
            this.labelCadastre.BackColor = System.Drawing.Color.Transparent;
            this.labelCadastre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCadastre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastre.ForeColor = System.Drawing.Color.Snow;
            this.labelCadastre.Location = new System.Drawing.Point(12, 263);
            this.labelCadastre.Name = "labelCadastre";
            this.labelCadastre.Size = new System.Drawing.Size(74, 13);
            this.labelCadastre.TabIndex = 7;
            this.labelCadastre.Text = "Cadastre-se";
            this.labelCadastre.Click += new System.EventHandler(this.labelCadastre_Click);
            // 
            // TelaEntrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DescompressaoTeste02.Properties.Resources.man_sitting_on_sidewalk_while_reading_a_newspaper_3687511;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(277, 464);
            this.Controls.Add(this.labelCadastre);
            this.Controls.Add(this.buttonEntrarLogin);
            this.Controls.Add(this.labelEsqueceuSuaSenha);
            this.Controls.Add(this.textBoxSenhaLogin);
            this.Controls.Add(this.textBoxUsuarioLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaEntrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Descompressão";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.buttonFecharTelaEntrar);
            this.Load += new System.EventHandler(this.TelaEntrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsuarioLogin;
        private System.Windows.Forms.TextBox textBoxSenhaLogin;
        private System.Windows.Forms.Label labelEsqueceuSuaSenha;
        private System.Windows.Forms.Button buttonEntrarLogin;
        private System.Windows.Forms.Label labelCadastre;
    }
}