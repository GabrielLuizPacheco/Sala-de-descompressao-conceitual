using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescompressaoTeste02.View
{
    public partial class TelaFazerAgendamento : Form
    {
        public TelaFazerAgendamento()
        {
            InitializeComponent();
        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.ShowDialog();
        }
    }
}
