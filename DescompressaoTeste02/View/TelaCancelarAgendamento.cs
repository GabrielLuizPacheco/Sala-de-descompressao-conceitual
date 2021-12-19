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
    public partial class TelaCancelarAgendamento : Form
    {
        public TelaCancelarAgendamento()
        {
            InitializeComponent();

            ManipularFuncionario manipularFuncionario = new ManipularFuncionario();
            manipularFuncionario.dadosFuncionario();

            dataGridViewTodoAgendamentosFuncionarioCancelar.DataSource = ManipularFuncionario.visuAgendamentosFuncionario();
            dataGridViewTodoAgendamentosFuncionarioCancelar.Columns[0].Visible = false;
            dataGridViewTodoAgendamentosFuncionarioCancelar.Columns[1].Visible = false;
            dataGridViewTodoAgendamentosFuncionarioCancelar.Columns[2].Visible = false;

            dataGridViewTodoAgendamentosFuncionarioCancelar.Columns[3].HeaderCell.Value = "Data";
            dataGridViewTodoAgendamentosFuncionarioCancelar.Columns[4].HeaderCell.Value = "Hora Início";
            dataGridViewTodoAgendamentosFuncionarioCancelar.Columns[5].HeaderCell.Value = "Hora Término";
        }

        private void monthCalendarDataCancelar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime agendou;

            agendou = Convert.ToDateTime(monthCalendarDataCancelar.SelectionStart.Date);

            textBoxDataCancelar.Text = agendou.ToString("dd/MM/yyyy");

            Reserva.DataCancelar = agendou;
        }

        private void buttonSimCancelarAgendamento_Click(object sender, EventArgs e)
        {
            ManipularReserva manipularReserva = new ManipularReserva();
            manipularReserva.deletarReserva();
        }
    }
}
