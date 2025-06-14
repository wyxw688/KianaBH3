using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetLoginActivityRsp : BasePacket
{
    public PacketGetLoginActivityRsp() : base(CmdIds.GetLoginActivityRsp)
    {
        // TODO: Hardcoded
        var now = (uint)Extensions.GetUnixSec();

        var proto = new GetLoginActivityRsp
        {
            LoginList =
            {
                new LoginActivityData
                {
                    Id = 581,
                    LoginDays = now,
                    AcceptTime = now,
                    DurationEndTime = now + 604800 * 2
                }
            }
        };

        SetData(proto);
    }
}
