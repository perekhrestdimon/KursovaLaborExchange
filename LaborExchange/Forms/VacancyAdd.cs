using System;
using System.Windows.Forms;
using LaborExchange.Class;

namespace LaborExchange.Forms
{
    /// <summary>
    /// Форма для додавання нової вакансії
    /// </summary>
    public partial class VacancyAdd : Form
    {
        public Vacancy Vacancy { get; private set; }

        public VacancyAdd()
        {
            InitializeComponent();

            KeyPreview = true;
            this.KeyDown += VacancyAdd_KeyDown;
            this.FormClosing += VacancyAdd_FormClosing;
        }

        /// <summary>
        /// Формує Vacancy з полів введення
        /// </summary>
        private Vacancy GetVacancyFromInputs()
        {
            return new Vacancy
            {
                JobTitle = textBox1.Text,             // Фірма/Компанія
                Employer = textBox2.Text,             // Посада
                WorkTerms = textBox3.Text,            // Умови праці
                PayInfo = textBox4.Text,              // Оплата
                Accommodation = textBox5.Text,        // Житло
                CandidateCriteria = textBox6.Text     // Вимоги до працівника
            };
        }

        // Перевіряємо валідність та формуємо Vacancy при закритті форми
        private void VacancyAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Vacancy = GetVacancyFromInputs();

                
                string validation = Vacancy.CheckData();
                if (!string.IsNullOrWhiteSpace(validation))
                {
                    MessageBox.Show(validation, "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Обробка клавіш Enter/ESC
        private void VacancyAdd_KeyDown(object sender, KeyEventArgs e)
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
        private void VacancyAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}