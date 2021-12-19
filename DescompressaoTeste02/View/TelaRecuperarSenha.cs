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

namespace DescompressaoTeste02.View
{
    public partial class TelaRecuperarSenha : Form
    {
        public TelaRecuperarSenha()
        {
            InitializeComponent();

            this.groupBoxTextoRecuperarSenha.Visible = false;
        }

        private void buttonConfirmarRecuperarSenha_Click(object sender, EventArgs e)
        {
            this.groupBoxTextoRecuperarSenha.Visible = true;
        }

        private void labelVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Close();

            TelaEntrar telaEntrar = new TelaEntrar();
            telaEntrar.Visible = true;
        }
    }
}
