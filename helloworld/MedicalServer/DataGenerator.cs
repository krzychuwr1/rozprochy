using Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalServer
{
    public static class DataGenerator
    {
        private static List<(string property, string unit)> dataTypes = new List<(string, string)>()
            {
                ("Weight", "kg"),
                ("Height", "cm"),
                ("Glucose", "mmol/L" ),
                ("Calcium", "mmol/L" ),
                ("Albumin", "g/L" ),
                ("Cholesterol", "mg/dL"),
                ("Urea", "mmol/L"),
                ("Sodium", "mmol/L"),
                ("Chloride", "mmol/L"),
                ("Potassium", "mmol/L"),
                ("Globulin", "g/L" ),
                ("Na++", "mEq/L"),
                ("Protein", "g/L")
            };

        private static List<string> doctors = new List<string> { "D1", "D2", "D3", "D4" };

        private static List<string> patients = new List<string> { "P1", "P2", "P3", "P4" };

        private static Random rand = new Random();

        public static List<MedicalData> Results { get; set; } = GenerateRandomResults().Take(100).ToList();

        private static IEnumerable<SingleTestResult> GenerateRecords()
        {
            var rand = new Random();

            while (true)
            {
                var type = dataTypes[rand.Next(0, dataTypes.Count)];

                yield return new SingleTestResult
                {
                    Name = type.property,
                    Value = rand.NextDouble(),
                    Unit = type.unit
                };
            }
        }

        private static IEnumerable<MedicalData> GenerateRandomResults()
        {
            while (true)
            {

                var MedicalData = new MedicalData
                {
                    Date = DateTime.Now.AddDays(-rand.Next(0, 1000)).Ticks,
                    DoctorName = doctors[rand.Next(0, doctors.Count - 1)],
                    PatientName = patients[rand.Next(0, patients.Count - 1)],
                };

                MedicalData.Results.AddRange(GenerateRecords().Take(rand.Next(1, 6)));

                yield return MedicalData;

            }
        }
    }
}
