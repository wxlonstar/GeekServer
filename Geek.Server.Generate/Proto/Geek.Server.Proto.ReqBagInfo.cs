//auto generated, do not modify it

using Protocol;
using MessagePack;
using System.Collections.Generic;
using Geek.Server.Core.Net.BaseHandler;

namespace Geek.Server.Proto
{
    [MessagePackObject(true)]
	public class ReqBagInfo : Message
	{
		[IgnoreMember]
		public const int Sid = 1435193915;

		[IgnoreMember]
		public const int MsgID = Sid;
		[IgnoreMember]
		public override int MsgId => MsgID;

	}
}
