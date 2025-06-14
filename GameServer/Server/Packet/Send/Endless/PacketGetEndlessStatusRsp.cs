using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Endless;

public class PacketGetEndlessStatusRsp : BasePacket
{
    public PacketGetEndlessStatusRsp() : base(CmdIds.GetEndlessStatusRsp)
    {
        // TODO: Hardcoded
        var proto = new GetEndlessStatusRsp
        {
            CurStatus = new EndlessStatus
            {
                BeginTime = 1730098800,
                CanJoinIn = true,
                CloseTime = 1880308800,
                EndTime = 1880308800,
                EndlessType = EndlessType.Ultra
            },
            NextStatusList =
            {
                new EndlessStatus
                {
                    BeginTime = 1730444400,
                    CloseTime = 1880308800,
                    EndTime = 1880308800,
                    EndlessType = EndlessType.Ultra
                }
            }
        };

        SetData(proto);
    }
}
