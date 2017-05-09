using System;
using Grpc.Core;
using System.Collections.Generic;
using Medical;

namespace Medical
{
    class Client
    {
        private Technician.TechnicianClient _client { get; set; }

        public Client(Technician.TechnicianClient client)
        {
            _client = client;
        }

        public async void SaveNewResult(MedicalResult result)
        {
            await _client.AddNewResultAsync(result);
        }
    }
    class TechnicianMain
    {
        public static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Client(new Technician.TechnicianClient(channel));
            Console.WriteLine("---TECHNICIAN---");
            while (true)
            {
                var resultToAdd = new MedicalResult
                {
                    Date = DateTime.Now.Ticks
                };
                Console.WriteLine("Doctor:");
                resultToAdd.DoctorName = Console.ReadLine();
                Console.WriteLine("Patient:");
                resultToAdd.PatientName = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Add record?");
                    if (Console.ReadLine().ToLower().StartsWith("n"))
                    {
                        break;
                    }

                    var recordToAdd = new SingleTestResult();
                    Console.WriteLine("Record name:");
                    recordToAdd.Name = Console.ReadLine();

                    Console.WriteLine("Value:");
                    double value;
                    Double.TryParse(Console.ReadLine(), out value);
                    recordToAdd.Value = value;

                    Console.WriteLine("Unit:");
                    recordToAdd.Unit = Console.ReadLine();
                    resultToAdd.Results.Add(recordToAdd);

                }
                client.SaveNewResult(resultToAdd);
                Console.WriteLine("Result has been sent to the server !");
            }
        }
    }
}
