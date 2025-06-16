using System;

namespace LaborExchange.Class
{
    /// <summary>
    /// Клас, що описує профіль кандидата (шукач роботи)
    /// </summary>
    public class CandidateProfile : RecordBase
    {
        public string FullName { get; set; } = "Невідомо";
        public int YearsOld { get; set; } = 18;
        public string Specialization { get; set; } = "Невідомо";
        public string EducationLevel { get; set; } = "Невідомо";
        public string PreviousWorkplace { get; set; } = "Невідомо";
        public string PreviousPosition { get; set; } = "Невідомо";
        public string DismissalCause { get; set; } = "Невідомо";
        public string FamilyState { get; set; } = "Невідомо";
        public string Accommodation { get; set; } = "Невідомо";
        public string ContactInfo { get; set; } = "Невідомо";
        public string JobWishes { get; set; } = "Невідомо";
        public bool Archived { get; set; } = false;

        /// <summary>
        /// Повертає рядкове подання профілю кандидата (з поміткою архівації)
        /// </summary>
        public override string ToString()
        {
            return (Archived ? "[АРХІВ] " : "") +
                   $"{FullName} | {YearsOld} | {Specialization} | {EducationLevel} | {PreviousWorkplace} | {PreviousPosition} | {DismissalCause} | {FamilyState} | {Accommodation} | {ContactInfo} | {JobWishes}";
        }

        /// <summary>
        /// Перевірка коректності заповнення профілю кандидата
        /// </summary>
        public string CheckProfile()
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(FullName))
                msg += "ПІБ обов'язково для заповнення.\n";
            if (YearsOld < 18 || YearsOld > 100)
                msg += "Вік повинен бути від 18 до 100.\n";
            if (string.IsNullOrWhiteSpace(Specialization))
                msg += "Вкажіть спеціалізацію.\n";
            if (string.IsNullOrWhiteSpace(EducationLevel))
                msg += "Освіта обов'язкова.\n";
            if (string.IsNullOrWhiteSpace(PreviousWorkplace))
                msg += "Попереднє місце роботи не вказано.\n";
            if (string.IsNullOrWhiteSpace(PreviousPosition))
                msg += "Попередня посада не вказана.\n";
            if (string.IsNullOrWhiteSpace(DismissalCause))
                msg += "Причина звільнення не вказана.\n";
            if (string.IsNullOrWhiteSpace(FamilyState))
                msg += "Сімейний стан не вказано.\n";
            if (string.IsNullOrWhiteSpace(Accommodation))
                msg += "Житлові умови не вказано.\n";
            if (string.IsNullOrWhiteSpace(ContactInfo))
                msg += "Контактна інформація не вказана.\n";
            if (string.IsNullOrWhiteSpace(JobWishes))
                msg += "Побажання до роботи не вказано.\n";
            return msg;
        }
    }
}