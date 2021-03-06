// Copyright 2015, Google Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without
// modification, are permitted provided that the following conditions are
// met:
//
//     * Redistributions of source code must retain the above copyright
// notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above
// copyright notice, this list of conditions and the following disclaimer
// in the documentation and/or other materials provided with the
// distribution.
//     * Neither the name of Google Inc. nor the names of its
// contributors may be used to endorse or promote products derived from
// this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
// OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
// SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
// LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
// THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
// OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using Grpc.Core;
using Medical;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Doctor
{
    class Client
    {
        private Medical.DoctorResultsGetter.DoctorResultsGetterClient _client { get; set; }

        public Client(Medical.DoctorResultsGetter.DoctorResultsGetterClient client)
        {
            _client = client;
        }

        public async Task GetFilteredResults(FilterRequest filteringParameters)
        {
            using (var call = _client.GetResults(filteringParameters))
            {
                var responseStream = call.ResponseStream;
                while (await responseStream.MoveNext())
                {
                    MedicalHelpers.WriteResultToConsole(responseStream.Current);
                }
            }
        }

        public async void GetAllResults()
        {
            await GetFilteredResults(new FilterRequest());
        }
    }
    class DoctorMain
    {
        public static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new Client(new Medical.DoctorResultsGetter.DoctorResultsGetterClient(channel));
            Console.WriteLine("---DOCTOR---");
            while (true)
            {
                Console.WriteLine("Filter results?");
                if (Console.ReadLine().Equals("No"))
                {
                    client.GetAllResults();
                }
                else
                {
                    var query = new FilterRequest();
                    Console.WriteLine("Filter by patient:");
                    query.PatientName = Console.ReadLine();

                    Console.WriteLine("Filter by doctor:");
                    query.DoctorName = Console.ReadLine(); 

                    Console.WriteLine("Filter by test type:");
                    query.RecordName = Console.ReadLine();

                    Console.WriteLine("Filter by test result minimum value:");
                    Double.TryParse(Console.ReadLine(), out double value);
                    query.MinimalValue = value;

                    Console.WriteLine("Filter by start date:");
                    DateTime result;
                    var dateString = Console.ReadLine();
                    while (!DateTime.TryParse(dateString, out result) && !string.IsNullOrEmpty(dateString))
                    {
                        dateString = Console.ReadLine();
                        Console.WriteLine("Incorrect date format!");
                    }
                    query.StartDate = result.Ticks;

                    Task.Run(() => client.GetFilteredResults(query));
                }
            }
        }
    }
}
