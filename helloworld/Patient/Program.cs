using Grpc.Core;
using Medical;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Medical
{
    class Client
    {
        private Patient.PatientClient _client { get; set; }

        public Client(Patient.PatientClient client)
        {
            _client = client;
        }

        public async void GetFilteredResults(string patientName)
        {
            using (var call = _client.GetResults(new PatientRequest { Name = patientName }))
            {
                int counter = 0;
                var responseStream = call.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    counter++;
                    MedicalHelpers.WriteResultToConsole(responseStream.Current);
                }
                if (counter == 0)
                {
                    Console.WriteLine("No results for this name!");
                }
            }
        }
    }
    class PatientMain
    {
        public static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Client(new Patient.PatientClient(channel));
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            client.GetFilteredResults(name);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
