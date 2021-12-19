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

namespace DescompressaoTeste02.View
{
    public partial class TelaFazerAgendamento2 : Form
    {
        public TelaFazerAgendamento2()
        {
            InitializeComponent();

            ManipularFuncionario manipularFuncionario = new ManipularFuncionario();
            manipularFuncionario.dadosFuncionario();
        }

        private void monthCalendarDataAgendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime agendou;

            agendou = Convert.ToDateTime(monthCalendarDataAgendar.SelectionStart.Date);

            textBoxDiaEscolhido.Text = agendou.ToString("dd/MM/yyyy");

            Reserva.Data = agendou;

            dataGridViewVagasAgendadasHorarios.DataSource = ManipularReserva.visualizarTodasReservas();
            dataGridViewVagasAgendadasHorarios.Columns[0].Visible = false;
            dataGridViewVagasAgendadasHorarios.Columns[1].Visible = false;
            
            dataGridViewVagasAgendadasHorarios.Columns[2].Visible = false;
            dataGridViewVagasAgendadasHorarios.Columns[3].HeaderCell.Value = "Início";
            dataGridViewVagasAgendadasHorarios.Columns[4].Visible = false;
            dataGridViewVagasAgendadasHorarios.Columns[5].HeaderCell.Value = "Término";

        }

        private void buttonConfirmarAgendamento_Click(object sender, EventArgs e)
        {
            DateTime agendou;

            agendou = Convert.ToDateTime(monthCalendarDataAgendar.SelectionStart.Date);

            Reserva.Data = agendou;


            ManipularReserva manipularReserva = new ManipularReserva();
            manipularReserva.barrarAgendamento();

            if (Reserva.Data == Reserva.DataBarrar)
            {
                MessageBox.Show("Você ja tem um agendamento neste dia.");
            }
            else
            {
                if (comboBoxEscolhaHorario.Text == "")
                {
                    MessageBox.Show("Escolha um horario.");
                }
                else
                {
                    Reserva.HoraInicio = comboBoxEscolhaHorario.Text.Substring(0, 5);

                    Reserva.HoraFim = comboBoxEscolhaHorario.Text.Substring(8);

                    manipularReserva.fazerReserva();
                }
                

            }
            
            
            
        }
    }
}
