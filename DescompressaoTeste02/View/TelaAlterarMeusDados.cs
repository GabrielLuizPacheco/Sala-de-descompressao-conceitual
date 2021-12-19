using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DescompressaoTeste02.Control;
using DescompressaoTeste02.Model;

namespace DescompressaoTeste02.View
{
    public partial class TelaAlterarMeusDados : Form
    {
        public TelaAlterarMeusDados()
        {
            InitializeComponent();

            textBoxNomeFuncionarioAlterar.Text = Funcionario.Nome;
            dateTimePickerNascimentoFuncionarioAlterar.Value = Convert.ToDateTime(Funcionario.Nascimento);
            textBoxEmailFuncionarioAlterar.Text = Funcionario.Email;
            textBoxUsuarioFuncionarioAlterar.Text = Funcionario.Usuario;
            textBoxSenhaFuncionarioAlterar.Text = Funcionario.Senha;
        }

        private void buttonModificarDadosUsuario_Click(object sender, EventArgs e)
        {
            Funcionario.Nome = textBoxNomeFuncionarioAlterar.Text;
            Funcionario.Nascimento = dateTimePickerNascimentoFuncionarioAlterar.Value;
            Funcionario.Email = textBoxEmailFuncionarioAlterar.Text;
            Funcionario.Usuario = textBoxUsuarioFuncionarioAlterar.Text;
            Funcionario.Senha = textBoxSenhaFuncionarioAlterar.Text;

            ManipularFuncionario manipularFuncionario = new ManipularFuncionario();
            manipularFuncionario.alterarDadosFuncionario();

        }
    }
}
