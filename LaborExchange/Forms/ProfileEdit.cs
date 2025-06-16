using System;
using System.Windows.Forms;
using LaborExchange.Class;

namespace LaborExchange.Forms
{
    /// <summary>
    /// Форма для редагування профілю кандидата (шукач роботи)
    /// </summary>
    public partial class ProfileEdit : Form
    {
        private readonly CandidateProfile _originalProfile;

        public ProfileEdit(CandidateProfile profile)
        {
            InitializeComponent();

           
            textBox1.Text = profile.FullName;
            textBox2.Text = profile.YearsOld.ToString();
            textBox3.Text = profile.Specialization;
            textBox4.Text = profile.EducationLevel;
            textBox5.Text = profile.PreviousWorkplace;   // Місце останнього працевлаштування
            textBox6.Text = profile.PreviousPosition;    // Посада останнього працевлаштування
            textBox7.Text = profile.DismissalCause;
            textBox8.Text = profile.FamilyState;
            textBox9.Text = profile.Accommodation;
            textBox10.Text = profile.ContactInfo;
            textBox11.Text = profile.JobWishes;

            _originalProfile = profile;

            KeyPreview = true;
            this.KeyDown += ProfileEdit_KeyDown;
            this.FormClosing += ProfileEdit_FormClosing;
        }

        // Валідація і збереження змін
        private void ProfileEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                _originalProfile.FullName = textBox1.Text;
                _originalProfile.YearsOld = int.TryParse(textBox2.Text, out var y) ? y : 18;
                _originalProfile.Specialization = textBox3.Text;
                _originalProfile.EducationLevel = textBox4.Text;
                _originalProfile.PreviousWorkplace = textBox5.Text;
                _originalProfile.PreviousPosition = textBox6.Text;
                _originalProfile.DismissalCause = textBox7.Text;
                _originalProfile.FamilyState = textBox8.Text;
                _originalProfile.Accommodation = textBox9.Text;
                _originalProfile.ContactInfo = textBox10.Text;
                _originalProfile.JobWishes = textBox11.Text;

                // Перевірка валідності
                string check = _originalProfile.CheckProfile();
                if (!string.IsNullOrWhiteSpace(check))
                {
                    MessageBox.Show(check, "Помилка заповнення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        // Обробка Enter та Escape
        private void ProfileEdit_KeyDown(object sender, KeyEventArgs e)
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