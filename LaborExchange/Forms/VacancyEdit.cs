using System;
using System.Windows.Forms;
using LaborExchange.Class;

namespace LaborExchange.Forms
{
    /// <summary>
    /// Форма для редагування даних про вакансію
    /// </summary>
    public partial class VacancyEdit : Form
    {
        private readonly Vacancy _vacancy;

        public VacancyEdit(Vacancy vacancy)
        {
            InitializeComponent();

            
            textBox1.Text = vacancy.JobTitle;         // Назва організації
            textBox2.Text = vacancy.Employer;         // Посада
            textBox3.Text = vacancy.WorkTerms;        // Умови праці
            textBox4.Text = vacancy.PayInfo;          // Оплата праці
            textBox5.Text = vacancy.Accommodation;    // Житло
            textBox6.Text = vacancy.CandidateCriteria;// Вимоги до кандидата

            _vacancy = vacancy;

            KeyPreview = true;
            this.KeyDown += VacancyEdit_KeyDown;
            this.FormClosing += VacancyEdit_FormClosing;
        }

        // Збереження змін та валідація
        private void VacancyEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                _vacancy.Employer = textBox1.Text;
                _vacancy.JobTitle = textBox2.Text;
                _vacancy.WorkTerms = textBox3.Text;
                _vacancy.PayInfo = textBox4.Text;
                _vacancy.Accommodation = textBox5.Text;
                _vacancy.CandidateCriteria = textBox6.Text;

                // Перевірка правильності введення
                string report = _vacancy.CheckData();
                if (!string.IsNullOrWhiteSpace(report))
                {
                    MessageBox.Show(report, "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Enter - OK, Escape - Cancel
        private void VacancyEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                e.Handled = true;
            }
        }
        private void VacancyEdit_Load(object sender, EventArgs e)
        {
            
        }
    }
}