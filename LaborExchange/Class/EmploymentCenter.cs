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

        // Збереження і завантаження даних (JSON, з підтримкою типів) 
        public static void SaveAllData(string filename)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                // Додаємо підтримку поліморфізму
                Converters = { new RecordBaseJsonConverter() }
            };
            File.WriteAllText(filename, JsonSerializer.Serialize(Records, options));
        }

        public static void LoadAllData(string filename)
        {
            if (File.Exists(filename))
            {
                var json = File.ReadAllText(filename);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    var options = new JsonSerializerOptions
                    {
                        Converters = { new RecordBaseJsonConverter() }
                    };
                    var items = JsonSerializer.Deserialize<List<RecordBase>>(json, options);
                    Records = items ?? new List<RecordBase>();
                }
            }
            else
            {
                Records = new List<RecordBase>();
            }
        }
    }

    // Поліморфний конвертер для RecordBase (JSON)
    public class RecordBaseJsonConverter : System.Text.Json.Serialization.JsonConverter<RecordBase>
    {
        public override RecordBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);
            var root = jsonDoc.RootElement;
            if (root.TryGetProperty("JobTitle", out _))
                return JsonSerializer.Deserialize<Vacancy>(root.GetRawText(), options);
            else
                return JsonSerializer.Deserialize<CandidateProfile>(root.GetRawText(), options);
        }

        public override void Write(Utf8JsonWriter writer, RecordBase value, JsonSerializerOptions options)
        {
            if (value is Vacancy v)
                JsonSerializer.Serialize(writer, v, options);
            else if (value is CandidateProfile c)
                JsonSerializer.Serialize(writer, c, options);
        }
    }
}