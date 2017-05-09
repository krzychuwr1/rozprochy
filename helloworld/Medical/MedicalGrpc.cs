// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: medical.proto
// Original file comments:
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
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Medical {
  public static partial class Doctor
  {
    static readonly string __ServiceName = "medical.Doctor";

    static readonly grpc::Marshaller<global::Medical.QueryParams> __Marshaller_QueryParams = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Medical.QueryParams.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Medical.MedicalResult> __Marshaller_MedicalResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Medical.MedicalResult.Parser.ParseFrom);

    static readonly grpc::Method<global::Medical.QueryParams, global::Medical.MedicalResult> __Method_GetResults = new grpc::Method<global::Medical.QueryParams, global::Medical.MedicalResult>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetResults",
        __Marshaller_QueryParams,
        __Marshaller_MedicalResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Medical.MedicalReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Doctor</summary>
    public abstract partial class DoctorBase
    {
      public virtual global::System.Threading.Tasks.Task GetResults(global::Medical.QueryParams request, grpc::IServerStreamWriter<global::Medical.MedicalResult> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Doctor</summary>
    public partial class DoctorClient : grpc::ClientBase<DoctorClient>
    {
      /// <summary>Creates a new client for Doctor</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DoctorClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Doctor that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DoctorClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DoctorClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DoctorClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Medical.MedicalResult> GetResults(global::Medical.QueryParams request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetResults(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Medical.MedicalResult> GetResults(global::Medical.QueryParams request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetResults, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DoctorClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DoctorClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DoctorBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetResults, serviceImpl.GetResults).Build();
    }

  }
  public static partial class Technician
  {
    static readonly string __ServiceName = "medical.Technician";

    static readonly grpc::Marshaller<global::Medical.MedicalResult> __Marshaller_MedicalResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Medical.MedicalResult.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Medical.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Medical.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Medical.MedicalResult, global::Medical.Empty> __Method_AddNewResult = new grpc::Method<global::Medical.MedicalResult, global::Medical.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddNewResult",
        __Marshaller_MedicalResult,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Medical.MedicalReflection.Descriptor.Services[1]; }
    }

    /// <summary>Base class for server-side implementations of Technician</summary>
    public abstract partial class TechnicianBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Medical.Empty> AddNewResult(global::Medical.MedicalResult request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Technician</summary>
    public partial class TechnicianClient : grpc::ClientBase<TechnicianClient>
    {
      /// <summary>Creates a new client for Technician</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TechnicianClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Technician that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TechnicianClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TechnicianClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TechnicianClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Medical.Empty AddNewResult(global::Medical.MedicalResult request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddNewResult(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Medical.Empty AddNewResult(global::Medical.MedicalResult request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddNewResult, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Medical.Empty> AddNewResultAsync(global::Medical.MedicalResult request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return AddNewResultAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Medical.Empty> AddNewResultAsync(global::Medical.MedicalResult request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddNewResult, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TechnicianClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TechnicianClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TechnicianBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_AddNewResult, serviceImpl.AddNewResult).Build();
    }

  }
  public static partial class Patient
  {
    static readonly string __ServiceName = "medical.Patient";

    static readonly grpc::Marshaller<global::Medical.PatientRequest> __Marshaller_PatientRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Medical.PatientRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Medical.MedicalResult> __Marshaller_MedicalResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Medical.MedicalResult.Parser.ParseFrom);

    static readonly grpc::Method<global::Medical.PatientRequest, global::Medical.MedicalResult> __Method_GetResults = new grpc::Method<global::Medical.PatientRequest, global::Medical.MedicalResult>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetResults",
        __Marshaller_PatientRequest,
        __Marshaller_MedicalResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Medical.MedicalReflection.Descriptor.Services[2]; }
    }

    /// <summary>Base class for server-side implementations of Patient</summary>
    public abstract partial class PatientBase
    {
      public virtual global::System.Threading.Tasks.Task GetResults(global::Medical.PatientRequest request, grpc::IServerStreamWriter<global::Medical.MedicalResult> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Patient</summary>
    public partial class PatientClient : grpc::ClientBase<PatientClient>
    {
      /// <summary>Creates a new client for Patient</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PatientClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Patient that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PatientClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PatientClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PatientClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Medical.MedicalResult> GetResults(global::Medical.PatientRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetResults(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Medical.MedicalResult> GetResults(global::Medical.PatientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetResults, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PatientClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PatientClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PatientBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetResults, serviceImpl.GetResults).Build();
    }

  }
}
#endregion
