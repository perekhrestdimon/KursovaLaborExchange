namespace KursovaLaborExchange
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            Find = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            Company = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            Housing = new DataGridViewTextBoxColumn();
            Requirements = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(500, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "job title";
            // 
            // Find
            // 
            Find.AutoSize = true;
            Find.Location = new Point(85, 58);
            Find.Name = "Find";
            Find.Size = new Size(0, 32);
            Find.TabIndex = 1;
            Find.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(573, 51);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(500, 39);
            textBox2.TabIndex = 2;
            textBox2.Text = "City, town";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Find);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1513, 523);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(1122, 55);
            button1.Name = "button1";
            button1.Size = new Size(212, 35);
            button1.TabIndex = 3;
            button1.Text = "FIND JOBS";
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 130);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 4;
            label1.Text = "Filter by Education";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(582, 130);
            label2.Name = "label2";
            label2.Size = new Size(199, 32);
            label2.TabIndex = 5;
            label2.Text = "Filter by Payment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1063, 138);
            label3.Name = "label3";
            label3.Size = new Size(196, 32);
            label3.TabIndex = 6;
            label3.Text = "Filter by Housing";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 250);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(303, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 40);
            comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(796, 130);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 40);
            comboBox2.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1265, 135);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(242, 40);
            comboBox3.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(1357, 44);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 13;
            button2.Text = "Clear Filters";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Company, Position, Payment, Housing, Requirements });
            dataGridView1.Location = new Point(76, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1085, 294);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(652, -3);
            label4.Name = "label4";
            label4.Size = new Size(194, 32);
            label4.TabIndex = 15;
            label4.Text = "Search Vacancies";
            // 
            // Company
            // 
            Company.HeaderText = "Company";
            Company.MinimumWidth = 10;
            Company.Name = "Company";
            Company.Width = 200;
            // 
            // Position
            // 
            Position.HeaderText = "Position ";
            Position.MinimumWidth = 10;
            Position.Name = "Position";
            Position.Width = 200;
            // 
            // Payment
            // 
            Payment.HeaderText = "Payment ";
            Payment.MinimumWidth = 10;
            Payment.Name = "Payment";
            Payment.Width = 200;
            // 
            // Housing
            // 
            Housing.HeaderText = "Housing";
            Housing.MinimumWidth = 10;
            Housing.Name = "Housing";
            Housing.Width = 200;
            // 
            // Requirements
            // 
            Requirements.HeaderText = "Requirements ";
            Requirements.MinimumWidth = 10;
            Requirements.Name = "Requirements";
            Requirements.Width = 200;
            // 
            // button3
            // 
            button3.Location = new Point(1167, 398);
            button3.Name = "button3";
            button3.Size = new Size(323, 46);
            button3.TabIndex = 16;
            button3.Text = "View Details";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1167, 450);
            button4.Name = "button4";
            button4.Size = new Size(323, 46);
            button4.TabIndex = 17;
            button4.Text = "Generate Printable Ad";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(1537, 535);
            Controls.Add(panel1);
            Name = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private TextBox textBox1;
        private Label Find;
        private TextBox textBox2;
        private Panel panel1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private Label label6;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private Button button2;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Label label4;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn Position;
        private DataGridViewTextBoxColumn Payment;
        private DataGridViewTextBoxColumn Housing;
        private DataGridViewTextBoxColumn Requirements;
        private Button button1;
    }
}
