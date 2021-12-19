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
    public partial class TelaAlterarAgendamento : Form
    {
        public TelaAlterarAgendamento()
        {
            InitializeComponent();

            monthCalendarAlterarData.Visible = false;
        }

       

        private void labelModificarDataAlterar_Click(object sender, EventArgs e)
        {
            
            monthCalendarAlterarData.Visible = true;

            
        }

        private void monthCalendarAlterarData_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarAlterarData.Visible = false;
        }
    }
}
