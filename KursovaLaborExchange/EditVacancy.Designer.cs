namespace KursovaLaborExchange
{
    partial class EditVacancy
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1365, 400);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(621, 0);
            label1.Name = "label1";
            label1.Size = new Size(216, 32);
            label1.TabIndex = 0;
            label1.Text = "Змінити вакансію ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 51);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 1;
            label2.Text = "Заробітня плата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 108);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 2;
            label3.Text = "Посада";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 235);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 3;
            label4.Text = "Житлові умови";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 170);
            label5.Name = "label5";
            label5.Size = new Size(80, 32);
            label5.TabIndex = 4;
            label5.Text = "Фірма";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 51);
            label6.Name = "label6";
            label6.Size = new Size(153, 32);
            label6.TabIndex = 5;
            label6.Text = "Умови праці";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(772, 171);
            label7.Name = "label7";
            label7.Size = new Size(211, 32);
            label7.TabIndex = 6;
            label7.Text = "Умови до фахівця";
            label7.Click += label7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(481, 39);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(481, 39);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(481, 39);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 235);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(481, 39);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(772, 90);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(532, 78);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(772, 206);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(521, 78);
            textBox6.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(271, 485);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 1;
            button1.Text = "Зберегти";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(784, 494);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 2;
            button2.Text = "Скасувати";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditVacancy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 685);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "EditVacancy";
            Text = "Змінити вакансію";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}