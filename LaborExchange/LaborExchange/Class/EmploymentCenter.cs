using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;

namespace LaborExchange.Class
{
    public class EmploymentCenter
    {
        public static List<RecordBase> Records { get; set; } = new();

        // Пошук профілів кандидатів або вакансій за зразком
        public static List<RecordBase> SearchRecords(RecordBase pattern)
        {
            var result = new List<RecordBase>();

            foreach (var record in Records)
            {
                if (record is Vacancy vacancy && pattern is Vacancy vacancyPattern)
                {
                    if ((vacancy.Employer?.Contains(vacancyPattern.Employer ?? "", StringComparison.OrdinalIgnoreCase) ?? true) &&
                        (vacancy.JobTitle?.Contains(vacancyPattern.JobTitle ?? "", StringComparison.OrdinalIgnoreCase) ?? true) &&
                        (vacancy.PayInfo?.Contains(vacancyPattern.PayInfo ?? "", StringComparison.OrdinalIgnoreCase) ?? true) &&
                        (vacancy.Accommodation?.Contains(vacancyPattern.Accommodation ?? "", StringComparison.OrdinalIgnoreCase) ?? true))
                    {
                        result.Add(record);
                    }
                }
                else if (record is CandidateProfile profile && pattern is CandidateProfile profilePattern)
                {
                    if ((profile.Specialization?.Contains(profilePattern.Specialization ?? "", StringComparison.OrdinalIgnoreCase) ?? true) &&
                        (profile.EducationLevel?.Contains(profilePattern.EducationLevel ?? "", StringComparison.OrdinalIgnoreCase) ?? true) &&
                        (profile.PreviousWorkplace?.Contains(profilePattern.PreviousWorkplace ?? "", StringComparison.OrdinalIgnoreCase) ?? true) &&
                        (profile.PreviousPosition?.Contains(profilePattern.PreviousPosition ?? "", StringComparison.OrdinalIgnoreCase) ?? true))
                    {
                        result.Add(record);
                    }
                }
            }

            return result;
        }

        // Додавання нового запису
        public static void AddRecord(RecordBase record)
        {
            record.RecordId = GenerateId();
            Records.Add(record);
        }

        // Видалення запису
        public static void RemoveRecord(RecordBase record)
        {
            Records.Remove(record);
        }

        // Генерація нового унікального ідентифікатора
        private static int GenerateId()
        {
            return Records.Count == 0 ? 1 : Records.Max(r => r.RecordId) + 1;
        }

        // Генерація тестових даних
        public void GenerateTestData(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Records.Add(new Vacancy
                {
                    RecordId = i,
                    Employer = $"Компанія {i}",
                    JobTitle = $"Посада {i}",
                    WorkTerms = $"Умови роботи {i}",
                    PayInfo = $"Зарплата {i}",
                    Accommodation = $"Житло {i}",
                    CandidateCriteria = $"Вимоги {i}"
                });
                Records.Add(new CandidateProfile
                {
                    RecordId = i,
                    FullName = $"Кандидат {i}",
                    YearsOld = 18 + i,
                    Specialization = $"Спеціалізація {i}",
                    EducationLevel = $"Освіта {i}",
                    PreviousWorkplace = $"Колишнє місце роботи {i}",
                    PreviousPosition = $"Колишня посада {i}",
                    DismissalCause = $"Причина звільнення {i}",
                    FamilyState = $"Сімейний стан {i}",
                    Accommodation = $"Житлові умови {i}",
                    ContactInfo = $"Контакт {i}",
                    JobWishes = $"Побажання {i}"
                });
            }
        }

        // Збереження та завантаження даних можна залишити як є, якщо імена класів і властивостей співпадають.
    }
}