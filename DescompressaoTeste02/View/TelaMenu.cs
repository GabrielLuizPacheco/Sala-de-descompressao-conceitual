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
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
       
            InitializeComponent();
           
        }

        private void fazerAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaFazerAgendamento2 telaFazerAgendamento2 = new TelaFazerAgendamento2();
            telaFazerAgendamento2.ShowDialog();
        }

        private void consultarAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaConsultarAgendamento telaConsultarAgendamento = new TelaConsultarAgendamento();
            telaConsultarAgendamento.ShowDialog();
        }

        private void alterarAgendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cancelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCancelarAgendamento telaCancelarAgendamento = new TelaCancelarAgendamento();
            telaCancelarAgendamento.ShowDialog();
        }

        private void meusDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaMeusDados telaMeusDados = new TelaMeusDados();
            telaMeusDados.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
