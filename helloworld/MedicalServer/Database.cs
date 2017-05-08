using Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalServer
{
    public static class DataBase
    {
        public static List<MedicalResult> Results { get; set; } = GenerateRandomResults().Take(1000).ToList();

        private static IEnumerable<MedicalResult> GenerateRandomResults()
        {
            var rand = new Random();
            var doctors = new List<string> { "Doctor 1", "Doctor 2", "Doctor 3" };
            var patients = new List<string> { "Patient 1", "Patient 2", "Patient 3" };
            while (true)
            {

                var t = new MedicalResult
                {
                    Date = DateTime.Now.Ticks - rand.Next(),
                    DoctorName = doctors[rand.Next(0, 2)],
                    PatientName = patients[rand.Next(0, 2)]
                };

                t.Records.AddRange(GenerateRecords().Take(rand.Next(16)));

                yield return t;

            }
        }

        private static IEnumerable<Record> GenerateRecords()
        {
            var rand = new Random();

            while (true)
            {
                var name = new byte[16];
                rand.NextBytes(name);
                yield return new Record
                {
                    Name = Encoding.UTF32.GetString(name),
                    Value = rand.NextDouble(),
                    Unit = "mg"
                };
            }
        }
    }
}
