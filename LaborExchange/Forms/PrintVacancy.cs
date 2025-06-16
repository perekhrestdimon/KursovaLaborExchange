using System;
using System.Windows.Forms;
using LaborExchange.Class;

namespace LaborExchange.Forms
{
    /// <summary>
    /// Форма для перегляду (друку) оголошення про вакансію
    /// </summary>
    public partial class PrintVacancy : Form
    {
        public Vacancy Vacancy { get; private set; }

        public PrintVacancy(Vacancy vacancy)
        {
            InitializeComponent();

            // Заповнюємо поля форми значеннями вакансії
            textBox1.Text = vacancy.JobTitle;         // Назва компанії/фірми
            textBox2.Text = vacancy.Employer;         // Посада
            textBox3.Text = vacancy.WorkTerms;        // Умови праці
            textBox4.Text = vacancy.PayInfo;          // Зарплата
            textBox5.Text = vacancy.Accommodation;    // Житло
            textBox6.Text = vacancy.CandidateCriteria;// Вимоги до кандидата

            Vacancy = vacancy;
        }

        private void PrintVacancy_Load(object sender, EventArgs e)
        {
            
        }
    }
}