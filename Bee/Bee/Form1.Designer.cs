namespace Bee
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignJob = new System.Windows.Forms.Button();
            this.workerBeeJobs = new System.Windows.Forms.ComboBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.relatorio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.workerBeeJobs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atribuições de Tarefas de Operárias";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(237, 36);
            this.shifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(71, 20);
            this.shifts.TabIndex = 4;
            this.shifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarefa da operária";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turnos";
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(6, 64);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(195, 23);
            this.assignJob.TabIndex = 1;
            this.assignJob.Text = "Atribuir essa tarefa a uma abelha";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // workerBeeJobs
            // 
            this.workerBeeJobs.DisplayMember = "2";
            this.workerBeeJobs.FormattingEnabled = true;
            this.workerBeeJobs.Items.AddRange(new object[] {
            "Coletar néctar",
            "Produção de mel",
            "Cuidar dos ovos",
            "Ensinar as abelhas bebês",
            "Manutenção da colméia",
            "Patrulha"});
            this.workerBeeJobs.Location = new System.Drawing.Point(6, 36);
            this.workerBeeJobs.Name = "workerBeeJobs";
            this.workerBeeJobs.Size = new System.Drawing.Size(195, 21);
            this.workerBeeJobs.TabIndex = 2;
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(332, 32);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(75, 67);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Próximo turno";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // relatorio
            // 
            this.relatorio.Location = new System.Drawing.Point(12, 115);
            this.relatorio.Multiline = true;
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(395, 149);
            this.relatorio.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 276);
            this.Controls.Add(this.relatorio);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.ComboBox workerBeeJobs;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.TextBox relatorio;
    }
}

