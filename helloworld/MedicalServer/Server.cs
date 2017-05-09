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
using System.Threading.Tasks;
using Grpc.Core;
using Medical;
using System.Linq;
using System.Collections.Generic;

namespace MedicalServer
{
    class TechnicianImplementation : Technician.TechnicianBase
    {
        public override Task<Empty> AddNewResult(MedicalResult request, ServerCallContext context)
        {
            DataGenerator.Results.Add(request);
            return Task.FromResult(new Empty());
        }
    }

    class PatientImplementation : Patient.PatientBase
    {
        public override async Task GetResults(PatientRequest request, IServerStreamWriter<MedicalResult> responseStream, ServerCallContext context)
        {
            IEnumerable<MedicalResult> resultsToReturn = DataGenerator.Results.Where(x => x.PatientName.Equals(request.Name));
            foreach (var result in resultsToReturn)
            {
                await responseStream.WriteAsync(result);
                await Task.Delay(5000);
            }
        }
    }

    class DoctorImplementation : Doctor.DoctorBase
    {
        public override async Task GetResults(FilterRequest request, IServerStreamWriter<MedicalResult> responseStream, ServerCallContext context)
        {
            IEnumerable<MedicalResult> resultsToReturn = DataGenerator.Results;
            if (!string.IsNullOrWhiteSpace(request.PatientName))
            {
                resultsToReturn = resultsToReturn.Where(x => x.PatientName.Contains(request.PatientName));
            }
            if (request.StartDate != 0)
            {
                resultsToReturn = resultsToReturn.Where(x => x.Date > request.StartDate);
            }
            if (!string.IsNullOrWhiteSpace(request.RecordName))
            {
                resultsToReturn = resultsToReturn
                    .Where(x => x.Results.Select(y => y.Name).Contains(request.RecordName))
                    .Where(x => x.Results.Where(y => y.Name.Equals(request.RecordName))
                    .Any(y => y.Value > request.MinimalValue));
            }
            if (!string.IsNullOrWhiteSpace(request.DoctorName))
            {
                resultsToReturn = resultsToReturn
                    .Where(x => x.DoctorName == request.DoctorName);
            }

            foreach (var result in resultsToReturn)
            {
                await responseStream.WriteAsync(result);
                await Task.Delay(5000);
            }
        }
    }

    class ServerMain
    {
        const int Port = 50051;

        public static void Main(string[] args)
        {
            Server server = new Server
            {
                Services =
                {
                  Doctor.BindService(new DoctorImplementation()),
                  Technician.BindService(new TechnicianImplementation()),
                  Patient.BindService(new PatientImplementation())
                },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("---SERVER---");
            Console.WriteLine($"Medical server listening on port {Port} ");
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
