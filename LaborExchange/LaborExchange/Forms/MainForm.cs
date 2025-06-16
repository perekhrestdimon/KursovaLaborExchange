using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LaborExchange.Class;

namespace LaborExchange
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Прив'язка подій до кнопок пошуку
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            // Прив'язка події завантаження форми
            this.Load += MainForm_Load;
        }

        // Генерація тестових даних та початковий вивід
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Очищаємо старі записи перед генерацією тестових
            EmploymentCenter.Records.Clear();

            // Генеруємо 10 тестових пар: вакансій + кандидатів
            EmploymentCenter center = new EmploymentCenter();
            center.GenerateTestData(10);

            // Показуємо всі записи (і вакансії, і кандидати) у listBox1
            listBox1.DataSource = null;
            listBox1.DataSource = EmploymentCenter.Records;
            listBox1.DisplayMember = ""; // ToString() використовується для відображення
        }

        // Пошук вакансій
        private void Button1_Click(object sender, EventArgs e)
        {
            var vacancyPattern = new Vacancy
            {
                Employer = textBox1.Text.Trim(),
                JobTitle = textBox2.Text.Trim(),
                PayInfo = textBox3.Text.Trim(),
                Accommodation = textBox4.Text.Trim()
            };

            var found = EmploymentCenter.SearchRecords(vacancyPattern)
                .OfType<Vacancy>()
                .Where(v => !v.Archived)
                .ToList();

            if (found.Count == 0)
                MessageBox.Show("Вакансій за заданими критеріями не знайдено.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.DataSource = null;
            listBox1.DataSource = found;
            listBox1.DisplayMember = ""; // Використовується ToString()
        }

        // Пошук кандидатів (робітників)
        private void Button2_Click(object sender, EventArgs e)
        {
            var profilePattern = new CandidateProfile
            {
                Specialization = textBox5.Text.Trim(),
                EducationLevel = textBox6.Text.Trim(),
                PreviousPosition = textBox7.Text.Trim(),
                PreviousWorkplace = textBox8.Text.Trim()
            };

            var found = EmploymentCenter.SearchRecords(profilePattern)
                .OfType<CandidateProfile>()
                .Where(c => !c.Archived)
                .ToList();

            if (found.Count == 0)
                MessageBox.Show("Кандидатів за заданими критеріями не знайдено.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.DataSource = null;
            listBox1.DataSource = found;
            listBox1.DisplayMember = ""; // Використовується ToString()
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}