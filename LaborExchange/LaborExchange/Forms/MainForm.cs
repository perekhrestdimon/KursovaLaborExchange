using System;
using System.Linq;
using System.Windows.Forms;
using LaborExchange.Class;
using LaborExchange.Forms;

namespace LaborExchange
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Прив'язка кнопок пошуку
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;

            // Пошук по Enter для вакансій
            textBox1.KeyDown += VacancySearch_Enter;
            textBox2.KeyDown += VacancySearch_Enter;
            textBox3.KeyDown += VacancySearch_Enter;
            textBox4.KeyDown += VacancySearch_Enter;

            // Пошук по Enter для кандидатів
            textBox5.KeyDown += CandidateSearch_Enter;
            textBox6.KeyDown += CandidateSearch_Enter;
            textBox7.KeyDown += CandidateSearch_Enter;
            textBox8.KeyDown += CandidateSearch_Enter;

            // Меню
            анкетуToolStripMenuItem.Click += AddCandidate_Click;
            вакансіюToolStripMenuItem.Click += AddVacancy_Click;
            працевлаштуватисяToolStripMenuItem.Click += ArchiveSelected_Click;
            звільнитисяToolStripMenuItem.Click += DeleteSelected_Click;
            друкОголошенняToolStripMenuItem.Click += PrintSelected_Click;
            змінитиToolStripMenuItem.Click += EditSelected_Click; // Додаємо підписку на "Змінити"

            // Завантаження форми
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EmploymentCenter.Records.Clear();
            new EmploymentCenter().GenerateTestData(10);
            ShowAllRecords();
        }

        // Пошук вакансій
        private void Button1_Click(object sender, EventArgs e)
        {
            var pattern = new Vacancy
            {
                Employer = textBox1.Text.Trim(),
                JobTitle = textBox2.Text.Trim(),
                PayInfo = textBox3.Text.Trim(),
                Accommodation = textBox4.Text.Trim()
            };

            var found = EmploymentCenter.SearchRecords(pattern)
                .OfType<Vacancy>()
                .Where(v => !v.Archived)
                .ToList();

            if (found.Count == 0)
                MessageBox.Show("Вакансій не знайдено!", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.DataSource = null;
            listBox1.DataSource = found;
        }

        // Пошук кандидатів
        private void Button2_Click(object sender, EventArgs e)
        {
            var pattern = new CandidateProfile
            {
                Specialization = textBox5.Text.Trim(),
                EducationLevel = textBox6.Text.Trim(),
                PreviousPosition = textBox7.Text.Trim(),
                PreviousWorkplace = textBox8.Text.Trim()
            };

            var found = EmploymentCenter.SearchRecords(pattern)
                .OfType<CandidateProfile>()
                .Where(c => !c.Archived)
                .ToList();

            if (found.Count == 0)
                MessageBox.Show("Кандидатів не знайдено!", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.DataSource = null;
            listBox1.DataSource = found;
        }

        // Пошук вакансій по Enter
        private void VacancySearch_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Пошук кандидатів по Enter
        private void CandidateSearch_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button2_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Додати кандидата
        private void AddCandidate_Click(object sender, EventArgs e)
        {
            using (var form = new ProfileAdd())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    EmploymentCenter.AddRecord(form.CandidateProfile);
                    MessageBox.Show("Анкету додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllRecords();
                }
            }
        }

        // Додати вакансію
        private void AddVacancy_Click(object sender, EventArgs e)
        {
            using (var form = new VacancyAdd())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    EmploymentCenter.AddRecord(form.Vacancy);
                    MessageBox.Show("Вакансію додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllRecords();
                }
            }
        }

        // Архівація (працевлаштуватися)
        private void ArchiveSelected_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem;
            if (selected is Vacancy v)
            {
                v.Archived = true;
                MessageBox.Show("Вакансію архівовано!", "Архів", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selected is CandidateProfile c)
            {
                c.Archived = true;
                MessageBox.Show("Кандидата архівовано!", "Архів", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Оберіть запис зі списку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ShowAllRecords();
        }

        // Видалення
        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem;
            if (selected is RecordBase rec)
            {
                EmploymentCenter.RemoveRecord(rec);
                MessageBox.Show("Запис видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllRecords();
            }
            else
            {
                MessageBox.Show("Оберіть запис зі списку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Друк
        private void PrintSelected_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem;
            if (selected is CandidateProfile prof)
            {
                using (var form = new PrintProfile(prof))
                    form.ShowDialog();
            }
            else if (selected is Vacancy vac)
            {
                using (var form = new PrintVacancy(vac))
                    form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Оберіть запис для друку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ЗМІНИТИ (редагування)
        private void EditSelected_Click(object sender, EventArgs e)
        {
            var selected = listBox1.SelectedItem;
            if (selected is CandidateProfile candidate)
            {
                using (var editForm = new ProfileEdit(candidate))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Анкету оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllRecords();
                    }
                }
            }
            else if (selected is Vacancy vacancy)
            {
                using (var editForm = new VacancyEdit(vacancy))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Вакансію оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowAllRecords();
                    }
                }
            }
            else
            {
                MessageBox.Show("Оберіть анкету або вакансію для редагування!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Показати всі неархівовані записи (початковий вивід і після змін)
        private void ShowAllRecords()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = EmploymentCenter.Records
                .Where(r => (r is Vacancy v && !v.Archived) || (r is CandidateProfile c && !c.Archived))
                .ToList();
        }
    }
}