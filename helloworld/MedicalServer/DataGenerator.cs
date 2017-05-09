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
                ("Glucose", "mmol/L" ),
                ("Calcium", "mmol/L" ),
                ("Albumin", "g/L" )
            };

        public static List<MedicalResult> Results { get; set; } = GenerateRandomResults().Take(100).ToList();

        private static IEnumerable<Record> GenerateRecords()
        {
            var rand = new Random();

            while (true)
            {
                var type = dataTypes[rand.Next(0, dataTypes.Count)];

                yield return new Record
                {
                    Name = type.property,
                    Value = rand.NextDouble(),
                    Unit = type.unit
                };
            }
        }

        private static IEnumerable<MedicalResult> GenerateRandomResults()
        {
            var rand = new Random();
            var doctors = new List<string> { "D1", "D2", "D3", "D4" };
            var patients = new List<string> { "P1", "P2", "P3", "P4" };
            while (true)
            {

                var t = new MedicalResult
                {
                    Date = DateTime.Now.AddDays(-rand.Next(0, 1000)).Ticks,
                    DoctorName = doctors[rand.Next(0, doctors.Count - 1)],
                    PatientName = patients[rand.Next(0, patients.Count - 1)],
                };

                t.Records.AddRange(GenerateRecords().Take(rand.Next(16)));

                yield return t;

            }
        }
    }
}
