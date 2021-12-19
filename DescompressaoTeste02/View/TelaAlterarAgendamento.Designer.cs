namespace DescompressaoTeste02.View
{
    partial class TelaAlterarAgendamento
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
            this.labelModificarDataAlterar = new System.Windows.Forms.Label();
            this.labelModificarHorarioAlterar = new System.Windows.Forms.Label();
            this.monthCalendarAlterarData = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelModificarDataAlterar
            // 
            this.labelModificarDataAlterar.AutoSize = true;
            this.labelModificarDataAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarDataAlterar.Location = new System.Drawing.Point(146, 193);
            this.labelModificarDataAlterar.Name = "labelModificarDataAlterar";
            this.labelModificarDataAlterar.Size = new System.Drawing.Size(50, 13);
            this.labelModificarDataAlterar.TabIndex = 0;
            this.labelModificarDataAlterar.Text = "Modificar";
            this.labelModificarDataAlterar.Click += new System.EventHandler(this.labelModificarDataAlterar_Click);
            // 
            // labelModificarHorarioAlterar
            // 
            this.labelModificarHorarioAlterar.AutoSize = true;
            this.labelModificarHorarioAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarHorarioAlterar.Location = new System.Drawing.Point(146, 245);
            this.labelModificarHorarioAlterar.Name = "labelModificarHorarioAlterar";
            this.labelModificarHorarioAlterar.Size = new System.Drawing.Size(50, 13);
            this.labelModificarHorarioAlterar.TabIndex = 1;
            this.labelModificarHorarioAlterar.Text = "Modificar";
            // 
            // monthCalendarAlterarData
            // 
            this.monthCalendarAlterarData.Location = new System.Drawing.Point(208, 193);
            this.monthCalendarAlterarData.Name = "monthCalendarAlterarData";
            this.monthCalendarAlterarData.TabIndex = 2;
            this.monthCalendarAlterarData.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarAlterarData_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora:";
            // 
            // TelaAlterarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendarAlterarData);
            this.Controls.Add(this.labelModificarHorarioAlterar);
            this.Controls.Add(this.labelModificarDataAlterar);
            this.Name = "TelaAlterarAgendamento";
            this.Text = "TelaAlterarAgendamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarDataAlterar;
        private System.Windows.Forms.Label labelModificarHorarioAlterar;
        private System.Windows.Forms.MonthCalendar monthCalendarAlterarData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}