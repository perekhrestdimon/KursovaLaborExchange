namespace KursovaLaborExchange
{
    partial class AddVacancy
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
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            SaveVacancy = new Button();
            CancelVacancy = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1288, 357);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 71);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "Заробітня плата";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(265, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 39);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 118);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 2;
            label2.Text = "Посада";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(265, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 39);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 171);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 4;
            label3.Text = "Фірма";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(265, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(325, 39);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 68);
            label4.Name = "label4";
            label4.Size = new Size(153, 32);
            label4.TabIndex = 6;
            label4.Text = "Умови праці";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(851, 61);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(434, 89);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 32);
            label5.TabIndex = 8;
            label5.Text = "Додати вакансію";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(641, 171);
            label6.Name = "label6";
            label6.Size = new Size(211, 32);
            label6.TabIndex = 9;
            label6.Text = "Умови до фахівця";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(851, 171);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(434, 78);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 217);
            label7.Name = "label7";
            label7.Size = new Size(182, 32);
            label7.TabIndex = 11;
            label7.Text = "Житлові умови";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(265, 217);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(325, 39);
            textBox6.TabIndex = 12;
            // 
            // SaveVacancy
            // 
            SaveVacancy.Location = new Point(354, 428);
            SaveVacancy.Name = "SaveVacancy";
            SaveVacancy.Size = new Size(150, 46);
            SaveVacancy.TabIndex = 1;
            SaveVacancy.Text = "Зберегти";
            SaveVacancy.UseVisualStyleBackColor = true;
            // 
            // CancelVacancy
            // 
            CancelVacancy.Location = new Point(792, 428);
            CancelVacancy.Name = "CancelVacancy";
            CancelVacancy.Size = new Size(150, 46);
            CancelVacancy.TabIndex = 2;
            CancelVacancy.Text = "Скасувати";
            CancelVacancy.UseVisualStyleBackColor = true;
            // 
            // AddVacancy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 682);
            Controls.Add(CancelVacancy);
            Controls.Add(SaveVacancy);
            Controls.Add(panel1);
            MaximumSize = new Size(1378, 753);
            MinimumSize = new Size(1378, 753);
            Name = "AddVacancy";
            Text = "Додати Вакансію";
            Load += AddVacancy_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Button SaveVacancy;
        private Button CancelVacancy;
    }
}