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
using DescompressaoTeste02.View;

namespace DescompressaoTeste02.View
{
    public partial class TelaConsultarAgendamento : Form
    {
        public TelaConsultarAgendamento()
        {
            InitializeComponent();

            ManipularFuncionario manipularFuncionario = new ManipularFuncionario();
            manipularFuncionario.dadosFuncionario();

        }

        private void buttonBuscarTodosAgendamentosFuncionario_Click(object sender, EventArgs e)
        {
            dataGridViewConsultarAgendamentosFuncionario.DataSource = ManipularFuncionario.visuAgendamentosFuncionario();
            dataGridViewConsultarAgendamentosFuncionario.Columns[0].Visible = false;
            dataGridViewConsultarAgendamentosFuncionario.Columns[1].Visible = false;
            dataGridViewConsultarAgendamentosFuncionario.Columns[2].Visible = false;

            dataGridViewConsultarAgendamentosFuncionario.Columns[3].HeaderCell.Value = "Data";
            dataGridViewConsultarAgendamentosFuncionario.Columns[4].HeaderCell.Value = "Hora Início";
            dataGridViewConsultarAgendamentosFuncionario.Columns[5].HeaderCell.Value = "Hora Término";

        }
    }
}
