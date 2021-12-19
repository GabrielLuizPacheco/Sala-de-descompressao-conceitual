using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DescompressaoTeste02.Model;
using DescompressaoTeste02.Control;
using DescompressaoTeste02.View;

namespace DescompressaoTeste02.View
{
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        public void label8_Click(object sender, EventArgs e)
        {

            TelaEntrar telaEntrar = new TelaEntrar();
            telaEntrar.Visible = true;

            this.Close();

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxCPFCadastro.Text == "")
            {
                MessageBox.Show("Preencha todos os campos;");
            }
            else if (textBoxNomeCadastrar.Text == "")
            {
                MessageBox.Show("Preencha todos os campos;");
            }
            else if (textBoxEmailCadastro.Text == "")
            {
                MessageBox.Show("Preencha todos os campos;");
            }
            else if (textBoxUsuarioCadastro.Text == "")
            {
                MessageBox.Show("Preencha todos os campos;");
            }
            else if (textBoxSenhaCadastro.Text == "")
            {
                MessageBox.Show("Preencha todos os campos;");
            }
            else
            {
                Funcionario.Cpf = Convert.ToInt32(textBoxCPFCadastro.Text);
                Funcionario.Nome = textBoxNomeCadastrar.Text;
                Funcionario.Nascimento = dateTimePickerNascimentoCadastro.Value;
                Funcionario.Email = textBoxEmailCadastro.Text;
                Funcionario.Usuario = textBoxUsuarioCadastro.Text;

                if (textBoxSenhaCadastro.Text == textBoxCSenhaCadastro.Text)
                {
                    Funcionario.Senha = textBoxSenhaCadastro.Text;

                    ManipularFuncionario manipularFuncionario = new ManipularFuncionario();
                    manipularFuncionario.cadastrarFuncionario();
                }
                else
                {
                    MessageBox.Show("A senha deve ser escrita igual à anterior!");
                }

            }

        }


        private void buttonFecharCadastro2(object sender, FormClosedEventArgs e)
        {
           
        }

        private void textBoxCPFCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
