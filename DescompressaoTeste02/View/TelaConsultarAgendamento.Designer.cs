namespace DescompressaoTeste02.View
{
    partial class TelaConsultarAgendamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarTodosAgendamentosFuncionario = new System.Windows.Forms.Button();
            this.dataGridViewConsultarAgendamentosFuncionario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarAgendamentosFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = " Meus Agendamentos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonBuscarTodosAgendamentosFuncionario);
            this.groupBox1.Controls.Add(this.dataGridViewConsultarAgendamentosFuncionario);
            this.groupBox1.Location = new System.Drawing.Point(49, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 307);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonBuscarTodosAgendamentosFuncionario
            // 
            this.buttonBuscarTodosAgendamentosFuncionario.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonBuscarTodosAgendamentosFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarTodosAgendamentosFuncionario.Location = new System.Drawing.Point(196, 20);
            this.buttonBuscarTodosAgendamentosFuncionario.Name = "buttonBuscarTodosAgendamentosFuncionario";
            this.buttonBuscarTodosAgendamentosFuncionario.Size = new System.Drawing.Size(107, 24);
            this.buttonBuscarTodosAgendamentosFuncionario.TabIndex = 4;
            this.buttonBuscarTodosAgendamentosFuncionario.Text = "Buscar Todos";
            this.buttonBuscarTodosAgendamentosFuncionario.UseVisualStyleBackColor = false;
            this.buttonBuscarTodosAgendamentosFuncionario.Click += new System.EventHandler(this.buttonBuscarTodosAgendamentosFuncionario_Click);
            // 
            // dataGridViewConsultarAgendamentosFuncionario
            // 
            this.dataGridViewConsultarAgendamentosFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConsultarAgendamentosFuncionario.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConsultarAgendamentosFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultarAgendamentosFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewConsultarAgendamentosFuncionario.Location = new System.Drawing.Point(33, 68);
            this.dataGridViewConsultarAgendamentosFuncionario.Name = "dataGridViewConsultarAgendamentosFuncionario";
            this.dataGridViewConsultarAgendamentosFuncionario.RowHeadersVisible = false;
            this.dataGridViewConsultarAgendamentosFuncionario.Size = new System.Drawing.Size(444, 219);
            this.dataGridViewConsultarAgendamentosFuncionario.TabIndex = 3;
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
            // TelaConsultarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TelaConsultarAgendamento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala de Descompressão";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarAgendamentosFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBuscarTodosAgendamentosFuncionario;
        private System.Windows.Forms.DataGridView dataGridViewConsultarAgendamentosFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}