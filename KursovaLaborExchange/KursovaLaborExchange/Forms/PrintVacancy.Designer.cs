namespace KursovaLaborExchange
{
    partial class PrintAd
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
            label2 = new Label();
            textBox5 = new TextBox();
            Accomadation = new Label();
            textBox4 = new TextBox();
            Payment = new Label();
            textBox3 = new TextBox();
            Conditions = new Label();
            textBox2 = new TextBox();
            PlaceForWork = new Label();
            textBox1 = new TextBox();
            Position = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(Accomadation);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(Payment);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(Conditions);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(PlaceForWork);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Position);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1438, 887);
            panel1.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(348, 650);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(759, 226);
            textBox6.TabIndex = 12;
            textBox6.Text = "Умови";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 650);
            label2.Name = "label2";
            label2.Size = new Size(237, 32);
            label2.TabIndex = 11;
            label2.Text = "Умови до робітника";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(348, 590);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(959, 39);
            textBox5.TabIndex = 10;
            textBox5.Text = "Житлові умови";
            // 
            // Accomadation
            // 
            Accomadation.AutoSize = true;
            Accomadation.Location = new Point(54, 597);
            Accomadation.Name = "Accomadation";
            Accomadation.Size = new Size(182, 32);
            Accomadation.TabIndex = 9;
            Accomadation.Text = "Житлові умови";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(348, 535);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(959, 39);
            textBox4.TabIndex = 8;
            textBox4.Text = "Введіть суму";
            // 
            // Payment
            // 
            Payment.AutoSize = true;
            Payment.Location = new Point(54, 542);
            Payment.Name = "Payment";
            Payment.Size = new Size(93, 32);
            Payment.TabIndex = 7;
            Payment.Text = "Оплата";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(348, 261);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(759, 244);
            textBox3.TabIndex = 6;
            textBox3.Text = "Умови праці";
            // 
            // Conditions
            // 
            Conditions.AutoSize = true;
            Conditions.Location = new Point(54, 261);
            Conditions.Name = "Conditions";
            Conditions.Size = new Size(153, 32);
            Conditions.TabIndex = 5;
            Conditions.Text = "Умови праці";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 184);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(959, 39);
            textBox2.TabIndex = 4;
            textBox2.Text = "Введіть назву фірми";
            // 
            // PlaceForWork
            // 
            PlaceForWork.AutoSize = true;
            PlaceForWork.Location = new Point(54, 191);
            PlaceForWork.Name = "PlaceForWork";
            PlaceForWork.Size = new Size(80, 32);
            PlaceForWork.TabIndex = 3;
            PlaceForWork.Text = "Фірма";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(959, 39);
            textBox1.TabIndex = 2;
            textBox1.Text = "Введіть посаду";
            // 
            // Position
            // 
            Position.AutoSize = true;
            Position.Location = new Point(54, 104);
            Position.Name = "Position";
            Position.Size = new Size(93, 32);
            Position.TabIndex = 1;
            Position.Text = "Посада";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 0);
            label1.Name = "label1";
            label1.Size = new Size(420, 32);
            label1.TabIndex = 0;
            label1.Text = "Оголошення про пошук працівників";
            // 
            // PrintAd
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1662, 911);
            Controls.Add(panel1);
            MaximumSize = new Size(1688, 982);
            MinimumSize = new Size(1688, 982);
            Name = "PrintAd";
            Text = "Друк Оголошення";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox2;
        private Label PlaceForWork;
        private TextBox textBox1;
        private Label Position;
        private TextBox textBox3;
        private Label Conditions;
        private TextBox textBox5;
        private Label Accomadation;
        private TextBox textBox4;
        private Label Payment;
        private TextBox textBox6;
        private Label label2;
    }
}