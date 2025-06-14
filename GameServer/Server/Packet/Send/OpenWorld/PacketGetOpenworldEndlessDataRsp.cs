using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.OpenWorld;

public class PacketGetOpenworldEndlessDataRsp : BasePacket
{
    public PacketGetOpenworldEndlessDataRsp(uint level, EndlessType type) : base(CmdIds.GetOpenworldEndlessDataRsp)
    {
        var random = new Random();
        var proto = new GetOpenworldEndlessDataRsp
        {
            BeginTime = 0,
            EndTime = (uint)(Extensions.GetUnixSec() + 3600 * 24 * 7),
            CloseTime = (uint)(Extensions.GetUnixSec() + 3600 * 24 * 7 + 1200),
            RandomSeed = (uint)random.Next(1, 1000001),
            HardLevel = level,
            Type = type,
        };

        SetData(proto);
    }
}
