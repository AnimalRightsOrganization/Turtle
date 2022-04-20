// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: CreateRoom.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HotFix {

  /// <summary>Holder for reflection information generated from CreateRoom.proto</summary>
  public static partial class CreateRoomReflection {

    #region Descriptor
    /// <summary>File descriptor for CreateRoom.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CreateRoomReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBDcmVhdGVSb29tLnByb3RvIkYKDkMyU19DcmVhdGVSb29tEhEKCXJvb21f",
            "bmFtZRgBIAEoCRIQCghyb29tX3B3ZBgCIAEoCRIPCgdtYXhfbnVtGAMgASgF",
            "Ih8KDEMyU19Kb2luUm9vbRIPCgdyb29tX2lkGAEgASgFIicKDFMyQ19Sb29t",
            "SW5mbxIXCgRyb29tGAEgASgLMgkuUm9vbUluZm8iUAoIUm9vbUluZm8SDwoH",
            "cm9vbV9pZBgBIAEoBRIRCglyb29tX25hbWUYAiABKAkSDwoHY3VyX251bRgD",
            "IAEoBRIPCgdtYXhfbnVtGAQgASgFIisKD1MyQ19HZXRSb29tTGlzdBIYCgVy",
            "b29tcxgBIAMoCzIJLlJvb21JbmZvQgmqAgZIb3RGaXhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HotFix.C2S_CreateRoom), global::HotFix.C2S_CreateRoom.Parser, new[]{ "RoomName", "RoomPwd", "MaxNum" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotFix.C2S_JoinRoom), global::HotFix.C2S_JoinRoom.Parser, new[]{ "RoomId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotFix.S2C_RoomInfo), global::HotFix.S2C_RoomInfo.Parser, new[]{ "Room" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotFix.RoomInfo), global::HotFix.RoomInfo.Parser, new[]{ "RoomId", "RoomName", "CurNum", "MaxNum" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HotFix.S2C_GetRoomList), global::HotFix.S2C_GetRoomList.Parser, new[]{ "Rooms" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class C2S_CreateRoom : pb::IMessage<C2S_CreateRoom> {
    private static readonly pb::MessageParser<C2S_CreateRoom> _parser = new pb::MessageParser<C2S_CreateRoom>(() => new C2S_CreateRoom());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2S_CreateRoom> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotFix.CreateRoomReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_CreateRoom() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_CreateRoom(C2S_CreateRoom other) : this() {
      roomName_ = other.roomName_;
      roomPwd_ = other.roomPwd_;
      maxNum_ = other.maxNum_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_CreateRoom Clone() {
      return new C2S_CreateRoom(this);
    }

    /// <summary>Field number for the "room_name" field.</summary>
    public const int RoomNameFieldNumber = 1;
    private string roomName_ = "";
    /// <summary>
    /// 房间名
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomName {
      get { return roomName_; }
      set {
        roomName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "room_pwd" field.</summary>
    public const int RoomPwdFieldNumber = 2;
    private string roomPwd_ = "";
    /// <summary>
    /// 房间密码
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomPwd {
      get { return roomPwd_; }
      set {
        roomPwd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "max_num" field.</summary>
    public const int MaxNumFieldNumber = 3;
    private int maxNum_;
    /// <summary>
    /// 玩家数
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxNum {
      get { return maxNum_; }
      set {
        maxNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as C2S_CreateRoom);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(C2S_CreateRoom other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomName != other.RoomName) return false;
      if (RoomPwd != other.RoomPwd) return false;
      if (MaxNum != other.MaxNum) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomName.Length != 0) hash ^= RoomName.GetHashCode();
      if (RoomPwd.Length != 0) hash ^= RoomPwd.GetHashCode();
      if (MaxNum != 0) hash ^= MaxNum.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RoomName);
      }
      if (RoomPwd.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RoomPwd);
      }
      if (MaxNum != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxNum);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomName);
      }
      if (RoomPwd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomPwd);
      }
      if (MaxNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxNum);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(C2S_CreateRoom other) {
      if (other == null) {
        return;
      }
      if (other.RoomName.Length != 0) {
        RoomName = other.RoomName;
      }
      if (other.RoomPwd.Length != 0) {
        RoomPwd = other.RoomPwd;
      }
      if (other.MaxNum != 0) {
        MaxNum = other.MaxNum;
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
            RoomName = input.ReadString();
            break;
          }
          case 18: {
            RoomPwd = input.ReadString();
            break;
          }
          case 24: {
            MaxNum = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class C2S_JoinRoom : pb::IMessage<C2S_JoinRoom> {
    private static readonly pb::MessageParser<C2S_JoinRoom> _parser = new pb::MessageParser<C2S_JoinRoom>(() => new C2S_JoinRoom());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2S_JoinRoom> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotFix.CreateRoomReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_JoinRoom() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_JoinRoom(C2S_JoinRoom other) : this() {
      roomId_ = other.roomId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S_JoinRoom Clone() {
      return new C2S_JoinRoom(this);
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private int roomId_;
    /// <summary>
    /// 房间Id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as C2S_JoinRoom);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(C2S_JoinRoom other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(C2S_JoinRoom other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
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
          case 8: {
            RoomId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class S2C_RoomInfo : pb::IMessage<S2C_RoomInfo> {
    private static readonly pb::MessageParser<S2C_RoomInfo> _parser = new pb::MessageParser<S2C_RoomInfo>(() => new S2C_RoomInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S2C_RoomInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotFix.CreateRoomReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_RoomInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_RoomInfo(S2C_RoomInfo other) : this() {
      Room = other.room_ != null ? other.Room.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_RoomInfo Clone() {
      return new S2C_RoomInfo(this);
    }

    /// <summary>Field number for the "room" field.</summary>
    public const int RoomFieldNumber = 1;
    private global::HotFix.RoomInfo room_;
    /// <summary>
    /// int32 room_id = 1; 	  //房间Id
    /// string room_name = 2; //房间名
    /// int32 max_num = 3;    //玩家数
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HotFix.RoomInfo Room {
      get { return room_; }
      set {
        room_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S2C_RoomInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S2C_RoomInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Room, other.Room)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (room_ != null) hash ^= Room.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (room_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Room);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (room_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Room);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S2C_RoomInfo other) {
      if (other == null) {
        return;
      }
      if (other.room_ != null) {
        if (room_ == null) {
          room_ = new global::HotFix.RoomInfo();
        }
        Room.MergeFrom(other.Room);
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
            if (room_ == null) {
              room_ = new global::HotFix.RoomInfo();
            }
            input.ReadMessage(room_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// message C2S_GetRoomList {} //传Empty就行
  /// </summary>
  public sealed partial class RoomInfo : pb::IMessage<RoomInfo> {
    private static readonly pb::MessageParser<RoomInfo> _parser = new pb::MessageParser<RoomInfo>(() => new RoomInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoomInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotFix.CreateRoomReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomInfo(RoomInfo other) : this() {
      roomId_ = other.roomId_;
      roomName_ = other.roomName_;
      curNum_ = other.curNum_;
      maxNum_ = other.maxNum_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoomInfo Clone() {
      return new RoomInfo(this);
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 1;
    private int roomId_;
    /// <summary>
    /// 房间Id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "room_name" field.</summary>
    public const int RoomNameFieldNumber = 2;
    private string roomName_ = "";
    /// <summary>
    /// 房间名
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RoomName {
      get { return roomName_; }
      set {
        roomName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cur_num" field.</summary>
    public const int CurNumFieldNumber = 3;
    private int curNum_;
    /// <summary>
    /// 当前玩家数
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CurNum {
      get { return curNum_; }
      set {
        curNum_ = value;
      }
    }

    /// <summary>Field number for the "max_num" field.</summary>
    public const int MaxNumFieldNumber = 4;
    private int maxNum_;
    /// <summary>
    /// 玩家总数
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxNum {
      get { return maxNum_; }
      set {
        maxNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoomInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoomInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoomId != other.RoomId) return false;
      if (RoomName != other.RoomName) return false;
      if (CurNum != other.CurNum) return false;
      if (MaxNum != other.MaxNum) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (RoomName.Length != 0) hash ^= RoomName.GetHashCode();
      if (CurNum != 0) hash ^= CurNum.GetHashCode();
      if (MaxNum != 0) hash ^= MaxNum.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoomId);
      }
      if (RoomName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RoomName);
      }
      if (CurNum != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CurNum);
      }
      if (MaxNum != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MaxNum);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoomId);
      }
      if (RoomName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomName);
      }
      if (CurNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurNum);
      }
      if (MaxNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxNum);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoomInfo other) {
      if (other == null) {
        return;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.RoomName.Length != 0) {
        RoomName = other.RoomName;
      }
      if (other.CurNum != 0) {
        CurNum = other.CurNum;
      }
      if (other.MaxNum != 0) {
        MaxNum = other.MaxNum;
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
          case 8: {
            RoomId = input.ReadInt32();
            break;
          }
          case 18: {
            RoomName = input.ReadString();
            break;
          }
          case 24: {
            CurNum = input.ReadInt32();
            break;
          }
          case 32: {
            MaxNum = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class S2C_GetRoomList : pb::IMessage<S2C_GetRoomList> {
    private static readonly pb::MessageParser<S2C_GetRoomList> _parser = new pb::MessageParser<S2C_GetRoomList>(() => new S2C_GetRoomList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S2C_GetRoomList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HotFix.CreateRoomReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_GetRoomList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_GetRoomList(S2C_GetRoomList other) : this() {
      rooms_ = other.rooms_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C_GetRoomList Clone() {
      return new S2C_GetRoomList(this);
    }

    /// <summary>Field number for the "rooms" field.</summary>
    public const int RoomsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HotFix.RoomInfo> _repeated_rooms_codec
        = pb::FieldCodec.ForMessage(10, global::HotFix.RoomInfo.Parser);
    private readonly pbc::RepeatedField<global::HotFix.RoomInfo> rooms_ = new pbc::RepeatedField<global::HotFix.RoomInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HotFix.RoomInfo> Rooms {
      get { return rooms_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S2C_GetRoomList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S2C_GetRoomList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!rooms_.Equals(other.rooms_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= rooms_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      rooms_.WriteTo(output, _repeated_rooms_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += rooms_.CalculateSize(_repeated_rooms_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S2C_GetRoomList other) {
      if (other == null) {
        return;
      }
      rooms_.Add(other.rooms_);
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
            rooms_.AddEntriesFrom(input, _repeated_rooms_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
