using Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical
{
    public static class MedicalHelpers
    {
        public static void WriteResultToConsole(MedicalResult result)
        {
            Console.WriteLine($"Doctor Name: {result.DoctorName}    Patient Name: {result.PatientName}    Date: {new DateTime(result.Date).ToString()}");
            foreach (var record in result.Records)
            {
                Console.WriteLine($"{record.Name}   {record.Value}    {record.Unit}");
            }
        }
    }
}
