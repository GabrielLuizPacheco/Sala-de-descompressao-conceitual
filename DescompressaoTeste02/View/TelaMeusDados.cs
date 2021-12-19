using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DescompressaoTeste02.View;
using DescompressaoTeste02.Control;
using DescompressaoTeste02.Model;

namespace DescompressaoTeste02.View
{
    public partial class TelaMeusDados : Form
    {
        public TelaMeusDados()
        {

            InitializeComponent();

            ManipularFuncionario manipularFuncionario = new ManipularFuncionario();
            manipularFuncionario.dadosFuncionario();

            labelNome.Text = Funcionario.Nome;

            string nascimento;
            
            nascimento = Convert.ToString(Funcionario.Nascimento);

            labelDataDeNascimento.Text = nascimento.Substring(0, 10);
            labelCPF.Text = Convert.ToString(Funcionario.Cpf);
            labelEmail.Text = Funcionario.Email;
            labelNomeDeUsuario.Text = Funcionario.Usuario;
            labelSenha.Text = Funcionario.Senha;

        }

        private void buttonAlterarMeusDados_Click(object sender, EventArgs e)
        {
            TelaAlterarMeusDados telaAlterarMeusDados = new TelaAlterarMeusDados();
            telaAlterarMeusDados.ShowDialog();
        }
    }
}
