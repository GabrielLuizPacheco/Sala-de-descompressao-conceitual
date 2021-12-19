using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DescompressaoTeste02.Model;
using DescompressaoTeste02.Control;



namespace DescompressaoTeste02.View
{
    public partial class TelaEntrar : Form
    {
        
        public TelaEntrar()
        {
            InitializeComponent();
        }

        private void TelaEntrar_Load(object sender, EventArgs e)
        {

        }

        private void labelCadastre_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            TelaCadastrar telaCadastrar = new TelaCadastrar();
            telaCadastrar.ShowDialog();

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Funcionario.Usuario = textBoxUsuarioLogin.Text;
            Funcionario.Senha = textBoxSenhaLogin.Text;

            ManipularFuncionario manipularFuncionario = new ManipularFuncionario();
            manipularFuncionario.loginFuncionario();
        }

        private void buttonFecharTelaEntrar(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void labelEsqueceuSuaSenha_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            TelaRecuperarSenha telaRecuperarSenha = new TelaRecuperarSenha();
            telaRecuperarSenha.ShowDialog();
        }
    }
}
