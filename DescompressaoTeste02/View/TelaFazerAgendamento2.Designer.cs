namespace DescompressaoTeste02.View
{
    partial class TelaFazerAgendamento2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConfirmarAgendamento = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDiaEscolhido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.monthCalendarDataAgendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewVagasAgendadasHorarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxEscolhaHorario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVagasAgendadasHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agendamento";
            // 
            // buttonConfirmarAgendamento
            // 
            this.buttonConfirmarAgendamento.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonConfirmarAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarAgendamento.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmarAgendamento.Location = new System.Drawing.Point(239, 297);
            this.buttonConfirmarAgendamento.Name = "buttonConfirmarAgendamento";
            this.buttonConfirmarAgendamento.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmarAgendamento.TabIndex = 9;
            this.buttonConfirmarAgendamento.Text = "Confirmar";
            this.buttonConfirmarAgendamento.UseVisualStyleBackColor = false;
            this.buttonConfirmarAgendamento.Click += new System.EventHandler(this.buttonConfirmarAgendamento_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxDiaEscolhido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.monthCalendarDataAgendar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 329);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calendário";
            // 
            // textBoxDiaEscolhido
            // 
            this.textBoxDiaEscolhido.Location = new System.Drawing.Point(12, 264);
            this.textBoxDiaEscolhido.Name = "textBoxDiaEscolhido";
            this.textBoxDiaEscolhido.ReadOnly = true;
            this.textBoxDiaEscolhido.Size = new System.Drawing.Size(111, 20);
            this.textBoxDiaEscolhido.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Dia escolhido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Escolha um dia";
            // 
            // monthCalendarDataAgendar
            // 
            this.monthCalendarDataAgendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendarDataAgendar.Location = new System.Drawing.Point(12, 59);
            this.monthCalendarDataAgendar.MinDate = new System.DateTime(2020, 3, 6, 0, 0, 0, 0);
            this.monthCalendarDataAgendar.Name = "monthCalendarDataAgendar";
            this.monthCalendarDataAgendar.ShowToday = false;
            this.monthCalendarDataAgendar.TabIndex = 5;
            this.monthCalendarDataAgendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarDataAgendar_DateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridViewVagasAgendadasHorarios);
            this.groupBox2.Controls.Add(this.buttonConfirmarAgendamento);
            this.groupBox2.Controls.Add(this.comboBoxEscolhaHorario);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(266, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 329);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horários";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Horários Esgotados";
            // 
            // dataGridViewVagasAgendadasHorarios
            // 
            this.dataGridViewVagasAgendadasHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVagasAgendadasHorarios.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVagasAgendadasHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVagasAgendadasHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewVagasAgendadasHorarios.Location = new System.Drawing.Point(20, 59);
            this.dataGridViewVagasAgendadasHorarios.Name = "dataGridViewVagasAgendadasHorarios";
            this.dataGridViewVagasAgendadasHorarios.RowHeadersVisible = false;
            this.dataGridViewVagasAgendadasHorarios.Size = new System.Drawing.Size(247, 162);
            this.dataGridViewVagasAgendadasHorarios.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Início";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Término";
            this.Column2.Name = "Column2";
            // 
            // comboBoxEscolhaHorario
            // 
            this.comboBoxEscolhaHorario.FormattingEnabled = true;
            this.comboBoxEscolhaHorario.Items.AddRange(new object[] {
            "08:00 às 08:15 ",
            "",
            "08:20 às 08:35 ",
            "",
            "08:40 às 08:55 ",
            "",
            "09:00 às 09:15 ",
            "",
            "09:20 às 09:35 ",
            "",
            "09:40 às 09:55",
            "",
            "10:00 às 10:15",
            "",
            "10:20 às 10:35",
            "",
            "10:40 às 10:55",
            "",
            "11:00 às 11:15",
            "",
            "11:20 às 11:35    ",
            "",
            "11:40 às 11:55",
            "",
            "12:00 às 12:15",
            "",
            "12:20 às 12:35    ",
            "",
            "12:40 às 12:55",
            "",
            "13:00 às 13:15",
            "",
            "13:20 às 13:35    ",
            "",
            "13:40 às 13:55",
            "",
            "14:00 às 14:15",
            "",
            "14:20 às 14:35    ",
            "",
            "14:40 às 14:55",
            "",
            "15:00 às 15:15",
            "",
            "15:20 às 15:35    ",
            "",
            "15:40 às 15:55",
            "",
            "16:00 às 16:15",
            "",
            "16:20 às 16:35    ",
            "",
            "16:40 às 16:55",
            "",
            "17:00 às 17:15",
            "",
            "17:20 às 17:35    ",
            "",
            "17:40 às 17:55",
            "",
            "18:00 às 18:15",
            "",
            "18:20 às 18:35    ",
            "",
            "18:40 às 18:55",
            "",
            "19:00 às 19:15",
            "",
            "20:20 às 20:35    ",
            "",
            "20:40 às 20:55",
            "",
            "21:00 às 21:15",
            "",
            "21:20 às 21:35    ",
            "",
            "21:40 às 21:55",
            "",
            "22:00 às 22:15"});
            this.comboBoxEscolhaHorario.Location = new System.Drawing.Point(20, 263);
            this.comboBoxEscolhaHorario.Name = "comboBoxEscolhaHorario";
            this.comboBoxEscolhaHorario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEscolhaHorario.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Escolha um Horário livre";
            // 
            // TelaFazerAgendamento2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "TelaFazerAgendamento2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Descompressão";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVagasAgendadasHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConfirmarAgendamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDiaEscolhido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar monthCalendarDataAgendar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxEscolhaHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewVagasAgendadasHorarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}