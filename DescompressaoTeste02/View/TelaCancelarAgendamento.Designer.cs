namespace DescompressaoTeste02.View
{
    partial class TelaCancelarAgendamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSimCancelarAgendamento = new System.Windows.Forms.Button();
            this.dataGridViewTodoAgendamentosFuncionarioCancelar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDataCancelar = new System.Windows.Forms.TextBox();
            this.monthCalendarDataCancelar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodoAgendamentosFuncionarioCancelar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha uma data onde você tem um agendamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data selecionada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deseja cancelar os agendamentos neste dia ?";
            // 
            // buttonSimCancelarAgendamento
            // 
            this.buttonSimCancelarAgendamento.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSimCancelarAgendamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSimCancelarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSimCancelarAgendamento.ForeColor = System.Drawing.Color.Black;
            this.buttonSimCancelarAgendamento.Location = new System.Drawing.Point(203, 296);
            this.buttonSimCancelarAgendamento.Name = "buttonSimCancelarAgendamento";
            this.buttonSimCancelarAgendamento.Size = new System.Drawing.Size(66, 23);
            this.buttonSimCancelarAgendamento.TabIndex = 5;
            this.buttonSimCancelarAgendamento.Text = "Sim";
            this.buttonSimCancelarAgendamento.UseVisualStyleBackColor = false;
            this.buttonSimCancelarAgendamento.Click += new System.EventHandler(this.buttonSimCancelarAgendamento_Click);
            // 
            // dataGridViewTodoAgendamentosFuncionarioCancelar
            // 
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.Name = "dataGridViewTodoAgendamentosFuncionarioCancelar";
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.RowHeadersVisible = false;
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.Size = new System.Drawing.Size(444, 124);
            this.dataGridViewTodoAgendamentosFuncionarioCancelar.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Horário Início";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Horário Término";
            this.Column3.Name = "Column3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Agendamentos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxDataCancelar);
            this.groupBox1.Controls.Add(this.monthCalendarDataCancelar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonSimCancelarAgendamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 325);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cancele";
            // 
            // textBoxDataCancelar
            // 
            this.textBoxDataCancelar.Location = new System.Drawing.Point(9, 237);
            this.textBoxDataCancelar.Name = "textBoxDataCancelar";
            this.textBoxDataCancelar.ReadOnly = true;
            this.textBoxDataCancelar.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataCancelar.TabIndex = 7;
            // 
            // monthCalendarDataCancelar
            // 
            this.monthCalendarDataCancelar.Location = new System.Drawing.Point(6, 50);
            this.monthCalendarDataCancelar.Name = "monthCalendarDataCancelar";
            this.monthCalendarDataCancelar.ShowToday = false;
            this.monthCalendarDataCancelar.TabIndex = 6;
            this.monthCalendarDataCancelar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarDataCancelar_DateChanged);
            // 
            // TelaCancelarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewTodoAgendamentosFuncionarioCancelar);
            this.MaximizeBox = false;
            this.Name = "TelaCancelarAgendamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Descompessão";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTodoAgendamentosFuncionarioCancelar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSimCancelarAgendamento;
        private System.Windows.Forms.DataGridView dataGridViewTodoAgendamentosFuncionarioCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendarDataCancelar;
        private System.Windows.Forms.TextBox textBoxDataCancelar;
    }
}