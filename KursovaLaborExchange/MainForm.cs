using KursovaLaborExchange.Models;
using System.Windows.Forms;

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
            Житло = new TextBox();
            ЗаробітняПлата = new TextBox();
            label4 = new Label();
            label6 = new Label();
            findButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            PrintAdtoolStripMenuItem1 = new ToolStripMenuItem();
            додатковіДіїToolStripMenuItem = new ToolStripMenuItem();
            додатиToolStripMenuItem = new ToolStripMenuItem();
            анкетаБезробіньогоToolStripMenuItem = new ToolStripMenuItem();
            вакансіяToolStripMenuItem = new ToolStripMenuItem();
            змінитиToolStripMenuItem = new ToolStripMenuItem();
            видалитиПропозиціюToolStripMenuItem = new ToolStripMenuItem();
            працевлаштуватисяToolStripMenuItem = new ToolStripMenuItem();
            пошукРобітниківToolStripMenuItem = new ToolStripMenuItem();
            Results = new ListBox();
            panel2 = new Panel();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Посада";
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
            textBox2.Location = new Point(375, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(320, 39);
            textBox2.TabIndex = 2;
            textBox2.Text = "Місто";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Житло);
            panel1.Controls.Add(ЗаробітняПлата);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(findButton);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Find);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(51, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 180);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Житло
            // 
            Житло.Location = new Point(375, 126);
            Житло.Name = "Житло";
            Житло.Size = new Size(320, 39);
            Житло.TabIndex = 17;
            Житло.Text = "Житло";
            // 
            // ЗаробітняПлата
            // 
            ЗаробітняПлата.Location = new Point(21, 126);
            ЗаробітняПлата.Name = "ЗаробітняПлата";
            ЗаробітняПлата.Size = new Size(320, 39);
            ЗаробітняПлата.TabIndex = 16;
            ЗаробітняПлата.Text = "Заробітня плата";
            ЗаробітняПлата.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(408, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 32);
            label4.TabIndex = 15;
            label4.Text = "Пошук Роботи";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 250);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 9;
            // 
            // findButton
            // 
            findButton.Location = new Point(716, 87);
            findButton.Name = "findButton";
            findButton.Size = new Size(189, 39);
            findButton.TabIndex = 3;
            findButton.Text = "Шукати";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { PrintAdtoolStripMenuItem1, додатковіДіїToolStripMenuItem, видалитиПропозиціюToolStripMenuItem, працевлаштуватисяToolStripMenuItem, пошукРобітниківToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2174, 42);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // PrintAdtoolStripMenuItem1
            // 
            PrintAdtoolStripMenuItem1.Name = "PrintAdtoolStripMenuItem1";
            PrintAdtoolStripMenuItem1.Size = new Size(232, 38);
            PrintAdtoolStripMenuItem1.Text = "Друк оголошення";
            PrintAdtoolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // додатковіДіїToolStripMenuItem
            // 
            додатковіДіїToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { додатиToolStripMenuItem, змінитиToolStripMenuItem });
            додатковіДіїToolStripMenuItem.Name = "додатковіДіїToolStripMenuItem";
            додатковіДіїToolStripMenuItem.Size = new Size(177, 38);
            додатковіДіїToolStripMenuItem.Text = "Додаткові дії";
            // 
            // додатиToolStripMenuItem
            // 
            додатиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { анкетаБезробіньогоToolStripMenuItem, вакансіяToolStripMenuItem });
            додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            додатиToolStripMenuItem.Size = new Size(235, 44);
            додатиToolStripMenuItem.Text = "Додати";
            // 
            // анкетаБезробіньогоToolStripMenuItem
            // 
            анкетаБезробіньогоToolStripMenuItem.Name = "анкетаБезробіньогоToolStripMenuItem";
            анкетаБезробіньогоToolStripMenuItem.Size = new Size(391, 44);
            анкетаБезробіньогоToolStripMenuItem.Text = "Анкета безробітного";
            // 
            // вакансіяToolStripMenuItem
            // 
            вакансіяToolStripMenuItem.Name = "вакансіяToolStripMenuItem";
            вакансіяToolStripMenuItem.Size = new Size(391, 44);
            вакансіяToolStripMenuItem.Text = "Вакансія роботодавця";
            // 
            // змінитиToolStripMenuItem
            // 
            змінитиToolStripMenuItem.Name = "змінитиToolStripMenuItem";
            змінитиToolStripMenuItem.Size = new Size(235, 44);
            змінитиToolStripMenuItem.Text = "Змінити";
            // 
            // видалитиПропозиціюToolStripMenuItem
            // 
            видалитиПропозиціюToolStripMenuItem.Name = "видалитиПропозиціюToolStripMenuItem";
            видалитиПропозиціюToolStripMenuItem.Size = new Size(280, 38);
            видалитиПропозиціюToolStripMenuItem.Text = "Видалити пропозицію";
            // 
            // працевлаштуватисяToolStripMenuItem
            // 
            працевлаштуватисяToolStripMenuItem.Name = "працевлаштуватисяToolStripMenuItem";
            працевлаштуватисяToolStripMenuItem.Size = new Size(255, 38);
            працевлаштуватисяToolStripMenuItem.Text = "Працевлаштуватися";
            // 
            // пошукРобітниківToolStripMenuItem
            // 
            пошукРобітниківToolStripMenuItem.Name = "пошукРобітниківToolStripMenuItem";
            пошукРобітниківToolStripMenuItem.Size = new Size(232, 38);
            пошукРобітниківToolStripMenuItem.Text = "Пошук робітників";
            // 
            // Results
            // 
            Results.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Results.FormattingEnabled = true;
            Results.Location = new Point(-21, 268);
            Results.Name = "Results";
            Results.Size = new Size(2135, 324);
            Results.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(997, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 180);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(803, 75);
            button1.Name = "button1";
            button1.Size = new Size(189, 39);
            button1.TabIndex = 5;
            button1.Text = "Шукати";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(366, 52);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(425, 39);
            textBox6.TabIndex = 4;
            textBox6.Text = "Місце останньго працевлаштування";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(366, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(425, 39);
            textBox5.TabIndex = 3;
            textBox5.Text = "Посада останньго працевлаштування";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(19, 113);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(320, 39);
            textBox4.TabIndex = 2;
            textBox4.Text = "Освіта";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(19, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(320, 39);
            textBox3.TabIndex = 1;
            textBox3.Text = "Професія";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 2);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 0;
            label1.Text = "Пошук робітників";
            label1.Click += label1_Click_1;
            // 
            // MainForm
            // 
            ClientSize = new Size(2174, 629);
            Controls.Add(panel2);
            Controls.Add(Results);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(2200, 700);
            Name = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            library = new LaborExchangeFacade();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        // Обробник події закриття форми
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Бажаєте зберегти зміни перед виходом?",
                "Підтвердження виходу",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    SaveData();
                    // Дозволяємо закрити форму після збереження
                    break;
                case DialogResult.No:
                    // Виходимо без збереження
                    break;
                case DialogResult.Cancel:
                    // Скасовуємо закриття форми
                    e.Cancel = true;
                    break;
            }
        }

        private TextBox textBox1;
        private Label Find;
        private TextBox textBox2;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private Label label6;
        private Label label4;
        private MenuStrip menuStrip1;
        private ListBox Results;
        private Button findButton;
        private TextBox ЗаробітняПлата;
        private TextBox Житло;
        private ToolStripMenuItem видалитиПропозиціюToolStripMenuItem;
        private ToolStripMenuItem PrintAdtoolStripMenuItem1;
        private ToolStripMenuItem додатковіДіїToolStripMenuItem;
        private ToolStripMenuItem додатиToolStripMenuItem;
        private ToolStripMenuItem анкетаБезробіньогоToolStripMenuItem;
        private ToolStripMenuItem вакансіяToolStripMenuItem;
        private ToolStripMenuItem змінитиToolStripMenuItem;
        private ToolStripMenuItem працевлаштуватисяToolStripMenuItem;
        private ToolStripMenuItem пошукРобітниківToolStripMenuItem;
        private Panel panel2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button1;
        private LaborExchangeFacade library;

        // Метод для збереження даних
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                // Тут додайте вашу логіку збереження даних
                // Наприклад, збереження у файл або базу даних

                MessageBox.Show("Дані збережено успішно!", "Збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string jobTitle = textBox1.Text.Trim();
            string city = textBox2.Text.Trim();

            var filteredVacancies = library.Vacancies
                .Where(v => (string.IsNullOrEmpty(jobTitle) || v.Position.Contains(jobTitle, StringComparison.OrdinalIgnoreCase)) &&
                            (string.IsNullOrEmpty(city) || v.Employer.Address.Contains(city, StringComparison.OrdinalIgnoreCase)))
                .ToList();

            Results.Items.Clear();
            if (filteredVacancies.Count > 0)
            {
                foreach (var vacancy in filteredVacancies)
                {
                    Results.Items.Add($"{vacancy.Position} at {vacancy.Employer.CompanyName} - {vacancy.Employer.Address}");
                }
            }
            else
            {
                MessageBox.Show("No jobs found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Open the PrintAd form as a dialog
            var printAdForm = new PrintAd();
            printAdForm.ShowDialog();
        }
    }

}