using System;
using System.Windows.Forms;
using LaborExchange.Class;

namespace LaborExchange.Forms
{
    /// <summary>
    /// Форма для додавання нового профілю кандидата (шукач роботи)
    /// </summary>
    public partial class ProfileAdd : Form
    {
        public CandidateProfile CandidateProfile { get; private set; }

        public ProfileAdd()
        {
            InitializeComponent();
            KeyPreview = true;
            this.KeyDown += ProfileAdd_KeyDown;
            this.FormClosing += ProfileAdd_FormClosing;
        }

        /// <summary>
        /// Створює CandidateProfile з даних, введених на формі
        /// </summary>
        private CandidateProfile GetProfileFromInputs()
        {
            return new CandidateProfile
            {
                FullName = textBox1.Text,
                YearsOld = int.TryParse(textBox2.Text, out var y) ? y : 18,
                Specialization = textBox3.Text,
                EducationLevel = textBox4.Text,
                PreviousWorkplace = textBox5.Text,
                PreviousPosition = textBox6.Text,
                DismissalCause = textBox7.Text,
                FamilyState = textBox8.Text,
                Accommodation = textBox9.Text,
                ContactInfo = textBox10.Text,
                JobWishes = textBox11.Text
            };
        }

        // При закритті форми зберігаємо профіль, якщо натиснуто OK
        private void ProfileAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                CandidateProfile = GetProfileFromInputs();

                // Перевірка валідності
                string check = CandidateProfile.CheckProfile();
                if (!string.IsNullOrWhiteSpace(check))
                {
                    MessageBox.Show(check, "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Обробка Enter та Escape
        private void ProfileAdd_KeyDown(object sender, KeyEventArgs e)
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
    }
}