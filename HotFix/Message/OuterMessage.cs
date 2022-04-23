using ET;
using ProtoBuf;
using System.Collections.Generic;
namespace ET
{
//option csharp_namespace = "HotFix";
// 错误码
	[Message(OuterOpcode.ErrorPacket)]
	[ProtoContract]
	public partial class ErrorPacket: Object
	{
		[ProtoMember(1)]
		public int Code { get; set; }

		[ProtoMember(2)]
		public string Message { get; set; }

	}

//message Empty {} //注意括号不能写在一行，工具不认。
	[Message(OuterOpcode.EmptyPacket)]
	[ProtoContract]
	public partial class EmptyPacket: Object
	{
	}

// 聊天
	[Message(OuterOpcode.TheMsg)]
	[ProtoContract]
	public partial class TheMsg: Object
	{
		[ProtoMember(1)]
		public string Name { get; set; }

		[ProtoMember(2)]
		public string Content { get; set; }

	}

	[Message(OuterOpcode.TheMsgList)]
	[ProtoContract]
	public partial class TheMsgList: Object
	{
		[ProtoMember(1)]
		public int Id { get; set; }

		[ProtoMember(2)]
		public List<string> Content = new List<string>();

	}

// 登录
	[Message(OuterOpcode.C2S_Login)]
	[ProtoContract]
	public partial class C2S_Login: Object
	{
		[ProtoMember(1)]
		public string Username { get; set; }

		[ProtoMember(2)]
		public string Password { get; set; }

	}

	[Message(OuterOpcode.S2C_Login)]
	[ProtoContract]
	public partial class S2C_Login: Object
	{
		[ProtoMember(1)]
		public int Code { get; set; }

		[ProtoMember(2)]
		public string Username { get; set; }

		[ProtoMember(3)]
		public string Nickname { get; set; }

	}

// 房间
	[Message(OuterOpcode.C2S_CreateRoom)]
	[ProtoContract]
	public partial class C2S_CreateRoom: Object
	{
		[ProtoMember(1)]
		public string RoomName { get; set; }

		[ProtoMember(2)]
		public string RoomPwd { get; set; }

		[ProtoMember(3)]
		public int LimitNum { get; set; }

	}

	[Message(OuterOpcode.C2S_JoinRoom)]
	[ProtoContract]
	public partial class C2S_JoinRoom: Object
	{
		[ProtoMember(1)]
		public int RoomID { get; set; }

		[ProtoMember(2)]
		public string RoomPwd { get; set; }

	}

	[Message(OuterOpcode.S2C_RoomInfo)]
	[ProtoContract]
	public partial class S2C_RoomInfo: Object
	{
		[ProtoMember(1)]
		public RoomInfo Room { get; set; }

	}

//message C2S_GetRoomList {} //传Empty就行
	[Message(OuterOpcode.S2C_GetRoomList)]
	[ProtoContract]
	public partial class S2C_GetRoomList: Object
	{
		[ProtoMember(1)]
		public List<RoomInfo> Rooms = new List<RoomInfo>();

	}

//message C2S_LeaveRoom {} //传Empty就行
//message S2C_LeaveRoom {}
//房间信息
	[Message(OuterOpcode.RoomInfo)]
	[ProtoContract]
	public partial class RoomInfo: Object
	{
		[ProtoMember(1)]
		public int RoomID { get; set; }

		[ProtoMember(2)]
		public string RoomName { get; set; }

		[ProtoMember(3)]
		public int LimitNum { get; set; }

		[ProtoMember(4)]
		public List<PlayerInfo> Players = new List<PlayerInfo>();

	}

//房间内玩家信息
	[Message(OuterOpcode.PlayerInfo)]
	[ProtoContract]
	public partial class PlayerInfo: Object
	{
		[ProtoMember(1)]
		public string NickName { get; set; }

		[ProtoMember(2)]
		public int SeatID { get; set; }

	}

//出牌
	[Message(OuterOpcode.C2S_PlayCard)]
	[ProtoContract]
	public partial class C2S_PlayCard: Object
	{
		[ProtoMember(1)]
		public int CardID { get; set; }

	}

	[Message(OuterOpcode.S2C_PlayCard)]
	[ProtoContract]
	public partial class S2C_PlayCard: Object
	{
		[ProtoMember(1)]
		public int CardID { get; set; }

		[ProtoMember(2)]
		public int SeatID { get; set; }

	}

//发牌
	[Message(OuterOpcode.S2C_Deal)]
	[ProtoContract]
	public partial class S2C_Deal: Object
	{
		[ProtoMember(1)]
		public int CardID { get; set; }

		[ProtoMember(2)]
		public int SeatID { get; set; }

	}

}
