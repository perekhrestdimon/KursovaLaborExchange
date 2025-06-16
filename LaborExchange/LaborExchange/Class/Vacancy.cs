using System;

namespace LaborExchange.Class
{
    /// <summary>
    /// Клас, що представляє вакансію роботодавця
    /// </summary>
    public class Vacancy : RecordBase
    {
        public string Employer { get; set; } = "Невідомо";
        public string JobTitle { get; set; } = "Невідомо";
        public string WorkTerms { get; set; } = "Невідомо";
        public string PayInfo { get; set; } = "Невідомо";
        public string Accommodation { get; set; } = "Невідомо";
        public string CandidateCriteria { get; set; } = "Невідомо";
        public bool Archived { get; set; } = false;

        /// <summary>
        /// Повертає текстове представлення вакансії (з позначкою "Архів")
        /// </summary>
        public override string ToString()
        {
            return (Archived ? "[АРХІВ] " : "") + $"{Employer} | {JobTitle} | {WorkTerms} | {PayInfo} | {Accommodation} | {CandidateCriteria}";
        }

        /// <summary>
        /// Перевірка правильності заповнення полів вакансії
        /// </summary>
        public string CheckData()
        {
            string msg = "";
            if (string.IsNullOrWhiteSpace(Employer))
                msg += "Назва організації обов'язкова.\n";
            if (string.IsNullOrWhiteSpace(JobTitle))
                msg += "Посада обов'язкова.\n";
            if (string.IsNullOrWhiteSpace(WorkTerms))
                msg += "Умови праці необхідні.\n";
            if (string.IsNullOrWhiteSpace(PayInfo))
                msg += "Вкажіть оплату праці.\n";
            if (string.IsNullOrWhiteSpace(Accommodation))
                msg += "Опишіть житлові умови.\n";
            if (string.IsNullOrWhiteSpace(CandidateCriteria))
                msg += "Вкажіть вимоги до кандидата.\n";
            return msg;
        }
    }
}