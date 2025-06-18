namespace LaborExchange.Forms
{
    partial class PrintVacancy
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
            textBox6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1409, 664);
            panel1.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(199, 498);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(1084, 163);
            textBox6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 463);
            label7.Name = "label7";
            label7.Size = new Size(221, 32);
            label7.TabIndex = 11;
            label7.Text = "Вимоги до фахівця";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 395);
            label6.Name = "label6";
            label6.Size = new Size(182, 32);
            label6.TabIndex = 10;
            label6.Text = "Житлові умови";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 325);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 9;
            label5.Text = "Оплата";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(199, 395);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(1123, 39);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(199, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1125, 39);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(199, 194);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1123, 104);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 194);
            label4.Name = "label4";
            label4.Size = new Size(153, 32);
            label4.TabIndex = 5;
            label4.Text = "Умови праці";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1123, 39);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1123, 39);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 134);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 2;
            label3.Text = "Фірма";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 68);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 1;
            label2.Text = "Посада";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 0);
            label1.Name = "label1";
            label1.Size = new Size(420, 32);
            label1.TabIndex = 0;
            label1.Text = "Оголошення про пошук працівників";
            // 
            // PrintVacancy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 688);
            Controls.Add(panel1);
            MaximumSize = new Size(1459, 759);
            MinimumSize = new Size(1459, 759);
            Name = "PrintVacancy";
            Text = "Друк оголошення";
            Load += PrintVacancy_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox6;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}