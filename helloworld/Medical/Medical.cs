// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: medical.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Medical {

  /// <summary>Holder for reflection information generated from medical.proto</summary>
  public static partial class MedicalReflection {

    #region Descriptor
    /// <summary>File descriptor for medical.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MedicalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1tZWRpY2FsLnByb3RvEgdtZWRpY2FsIgcKBUVtcHR5ImgKDU1lZGljYWxS",
            "ZXN1bHQSEwoLUGF0aWVudE5hbWUYASABKAkSEgoKRG9jdG9yTmFtZRgCIAEo",
            "CRIMCgREYXRlGAMgASgDEiAKB1JlY29yZHMYBCADKAsyDy5tZWRpY2FsLlJl",
            "Y29yZCIzCgZSZWNvcmQSDAoETmFtZRgBIAEoCRINCgVWYWx1ZRgCIAEoARIM",
            "CgRVbml0GAMgASgJIh4KDlBhdGllbnRSZXF1ZXN0EgwKBG5hbWUYASABKAki",
            "dQoNRmlsdGVyUmVxdWVzdBITCgtwYXRpZW50TmFtZRgBIAEoCRISCgpyZWNv",
            "cmROYW1lGAIgASgJEhIKCmRvY3Rvck5hbWUYAyABKAkSEQoJc3RhcnREYXRl",
            "GAQgASgDEhQKDG1pbmltYWxWYWx1ZRgFIAEoATJKCgZEb2N0b3ISQAoKR2V0",
            "UmVzdWx0cxIWLm1lZGljYWwuRmlsdGVyUmVxdWVzdBoWLm1lZGljYWwuTWVk",
            "aWNhbFJlc3VsdCIAMAEyRgoKVGVjaG5pY2lhbhI4CgxBZGROZXdSZXN1bHQS",
            "Fi5tZWRpY2FsLk1lZGljYWxSZXN1bHQaDi5tZWRpY2FsLkVtcHR5IgAyTAoH",
            "UGF0aWVudBJBCgpHZXRSZXN1bHRzEhcubWVkaWNhbC5QYXRpZW50UmVxdWVz",
            "dBoWLm1lZGljYWwuTWVkaWNhbFJlc3VsdCIAMAFCMAoYaW8uZ3JwYy5leGFt",
            "cGxlcy5tZWRpY2FsQgxtZWRpY2FsUHJvdG9QAaICA0hMV2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Medical.Empty), global::Medical.Empty.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Medical.MedicalResult), global::Medical.MedicalResult.Parser, new[]{ "PatientName", "DoctorName", "Date", "Records" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Medical.Record), global::Medical.Record.Parser, new[]{ "Name", "Value", "Unit" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Medical.PatientRequest), global::Medical.PatientRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Medical.FilterRequest), global::Medical.FilterRequest.Parser, new[]{ "PatientName", "RecordName", "DoctorName", "StartDate", "MinimalValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Empty : pb::IMessage<Empty> {
    private static readonly pb::MessageParser<Empty> _parser = new pb::MessageParser<Empty>(() => new Empty());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Empty> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Medical.MedicalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty(Empty other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Empty Clone() {
      return new Empty(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Empty);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Empty other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Empty other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed partial class MedicalResult : pb::IMessage<MedicalResult> {
    private static readonly pb::MessageParser<MedicalResult> _parser = new pb::MessageParser<MedicalResult>(() => new MedicalResult());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MedicalResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Medical.MedicalReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MedicalResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MedicalResult(MedicalResult other) : this() {
      patientName_ = other.patientName_;
      doctorName_ = other.doctorName_;
      date_ = other.date_;
      records_ = other.records_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MedicalResult Clone() {
      return new MedicalResult(this);
    }

    /// <summary>Field number for the "PatientName" field.</summary>
    public const int PatientNameFieldNumber = 1;
    private string patientName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PatientName {
      get { return patientName_; }
      set {
        patientName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "DoctorName" field.</summary>
    public const int DoctorNameFieldNumber = 2;
    private string doctorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DoctorName {
      get { return doctorName_; }
      set {
        doctorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Date" field.</summary>
    public const int DateFieldNumber = 3;
    private long date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    /// <summary>Field number for the "Records" field.</summary>
    public const int RecordsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Medical.Record> _repeated_records_codec
        = pb::FieldCodec.ForMessage(34, global::Medical.Record.Parser);
    private readonly pbc::RepeatedField<global::Medical.Record> records_ = new pbc::RepeatedField<global::Medical.Record>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Medical.Record> Records {
      get { return records_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MedicalResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MedicalResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PatientName != other.PatientName) return false;
      if (DoctorName != other.DoctorName) return false;
      if (Date != other.Date) return false;
      if(!records_.Equals(other.records_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PatientName.Length != 0) hash ^= PatientName.GetHashCode();
      if (DoctorName.Length != 0) hash ^= DoctorName.GetHashCode();
      if (Date != 0L) hash ^= Date.GetHashCode();
      hash ^= records_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PatientName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PatientName);
      }
      if (DoctorName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DoctorName);
      }
      if (Date != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Date);
      }
      records_.WriteTo(output, _repeated_records_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PatientName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PatientName);
      }
      if (DoctorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DoctorName);
      }
      if (Date != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Date);
      }
      size += records_.CalculateSize(_repeated_records_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MedicalResult other) {
      if (other == null) {
        return;
      }
      if (other.PatientName.Length != 0) {
        PatientName = other.PatientName;
      }
      if (other.DoctorName.Length != 0) {
        DoctorName = other.DoctorName;
      }
      if (other.Date != 0L) {
        Date = other.Date;
      }
      records_.Add(other.records_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            PatientName = input.ReadString();
            break;
          }
          case 18: {
            DoctorName = input.ReadString();
            break;
          }
          case 24: {
            Date = input.ReadInt64();
            break;
          }
          case 34: {
            records_.AddEntriesFrom(input, _repeated_records_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Record : pb::IMessage<Record> {
    private static readonly pb::MessageParser<Record> _parser = new pb::MessageParser<Record>(() => new Record());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Record> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Medical.MedicalReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Record() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Record(Record other) : this() {
      name_ = other.name_;
      value_ = other.value_;
      unit_ = other.unit_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Record Clone() {
      return new Record(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Value" field.</summary>
    public const int ValueFieldNumber = 2;
    private double value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    /// <summary>Field number for the "Unit" field.</summary>
    public const int UnitFieldNumber = 3;
    private string unit_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Unit {
      get { return unit_; }
      set {
        unit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Record);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Record other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Value != other.Value) return false;
      if (Unit != other.Unit) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Value != 0D) hash ^= Value.GetHashCode();
      if (Unit.Length != 0) hash ^= Unit.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Value != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Value);
      }
      if (Unit.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Unit);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Value != 0D) {
        size += 1 + 8;
      }
      if (Unit.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unit);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Record other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Value != 0D) {
        Value = other.Value;
      }
      if (other.Unit.Length != 0) {
        Unit = other.Unit;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 17: {
            Value = input.ReadDouble();
            break;
          }
          case 26: {
            Unit = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PatientRequest : pb::IMessage<PatientRequest> {
    private static readonly pb::MessageParser<PatientRequest> _parser = new pb::MessageParser<PatientRequest>(() => new PatientRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PatientRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Medical.MedicalReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PatientRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PatientRequest(PatientRequest other) : this() {
      name_ = other.name_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PatientRequest Clone() {
      return new PatientRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PatientRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PatientRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PatientRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class FilterRequest : pb::IMessage<FilterRequest> {
    private static readonly pb::MessageParser<FilterRequest> _parser = new pb::MessageParser<FilterRequest>(() => new FilterRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FilterRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Medical.MedicalReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FilterRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FilterRequest(FilterRequest other) : this() {
      patientName_ = other.patientName_;
      recordName_ = other.recordName_;
      doctorName_ = other.doctorName_;
      startDate_ = other.startDate_;
      minimalValue_ = other.minimalValue_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FilterRequest Clone() {
      return new FilterRequest(this);
    }

    /// <summary>Field number for the "patientName" field.</summary>
    public const int PatientNameFieldNumber = 1;
    private string patientName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PatientName {
      get { return patientName_; }
      set {
        patientName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "recordName" field.</summary>
    public const int RecordNameFieldNumber = 2;
    private string recordName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RecordName {
      get { return recordName_; }
      set {
        recordName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "doctorName" field.</summary>
    public const int DoctorNameFieldNumber = 3;
    private string doctorName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DoctorName {
      get { return doctorName_; }
      set {
        doctorName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "startDate" field.</summary>
    public const int StartDateFieldNumber = 4;
    private long startDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }

    /// <summary>Field number for the "minimalValue" field.</summary>
    public const int MinimalValueFieldNumber = 5;
    private double minimalValue_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MinimalValue {
      get { return minimalValue_; }
      set {
        minimalValue_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FilterRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FilterRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PatientName != other.PatientName) return false;
      if (RecordName != other.RecordName) return false;
      if (DoctorName != other.DoctorName) return false;
      if (StartDate != other.StartDate) return false;
      if (MinimalValue != other.MinimalValue) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PatientName.Length != 0) hash ^= PatientName.GetHashCode();
      if (RecordName.Length != 0) hash ^= RecordName.GetHashCode();
      if (DoctorName.Length != 0) hash ^= DoctorName.GetHashCode();
      if (StartDate != 0L) hash ^= StartDate.GetHashCode();
      if (MinimalValue != 0D) hash ^= MinimalValue.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PatientName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PatientName);
      }
      if (RecordName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RecordName);
      }
      if (DoctorName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DoctorName);
      }
      if (StartDate != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(StartDate);
      }
      if (MinimalValue != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(MinimalValue);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PatientName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PatientName);
      }
      if (RecordName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RecordName);
      }
      if (DoctorName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DoctorName);
      }
      if (StartDate != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StartDate);
      }
      if (MinimalValue != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FilterRequest other) {
      if (other == null) {
        return;
      }
      if (other.PatientName.Length != 0) {
        PatientName = other.PatientName;
      }
      if (other.RecordName.Length != 0) {
        RecordName = other.RecordName;
      }
      if (other.DoctorName.Length != 0) {
        DoctorName = other.DoctorName;
      }
      if (other.StartDate != 0L) {
        StartDate = other.StartDate;
      }
      if (other.MinimalValue != 0D) {
        MinimalValue = other.MinimalValue;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            PatientName = input.ReadString();
            break;
          }
          case 18: {
            RecordName = input.ReadString();
            break;
          }
          case 26: {
            DoctorName = input.ReadString();
            break;
          }
          case 32: {
            StartDate = input.ReadInt64();
            break;
          }
          case 41: {
            MinimalValue = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
