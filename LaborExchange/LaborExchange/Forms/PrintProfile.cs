using System;
using System.Windows.Forms;
using LaborExchange.Class; 

namespace LaborExchange.Forms
{
    /// <summary>
    /// Форма для виводу оголошення профілю кандидата (шукач роботи)
    /// </summary>
    public partial class PrintProfile : Form
    {
        public CandidateProfile CandidateProfile { get; private set; }

        // Конструктор з параметром: передаємо профіль для друку
        public PrintProfile(CandidateProfile profile)
        {
            InitializeComponent();

            // Заповнюємо поля форми відповідно до твоєї розмітки
            textBox1.Text = profile.FullName;
            textBox2.Text = profile.YearsOld.ToString();
            textBox3.Text = profile.Specialization;
            textBox4.Text = profile.EducationLevel;
            textBox5.Text = profile.PreviousPosition;
            textBox6.Text = profile.PreviousWorkplace;
            textBox7.Text = profile.DismissalCause;
            textBox8.Text = profile.FamilyState;
            textBox9.Text = profile.Accommodation;
            textBox10.Text = profile.ContactInfo;
            textBox11.Text = profile.JobWishes;
            CandidateProfile = profile;
        }

        
        private void PrintProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}