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
            Console.WriteLine($"Doctor : {result.DoctorName}, Patient : {result.PatientName} Date: {new DateTime(result.Date).ToString()} {Environment.NewLine}");

            Console.WriteLine("Property        Value                   Unit");
            foreach (var record in result.Records)
            {
                Console.WriteLine($"{record.Name.PadRight(15, ' ')} {record.Value.ToString().PadRight(20, ' ')}    {record.Unit}");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
