using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketSyncTimeRsp : BasePacket
{
    public PacketSyncTimeRsp(uint seq) : base(CmdIds.SyncTimeRsp)
    {
        var proto = new SyncTimeRsp
        {
            CurTime = (uint)Extensions.GetUnixSec(),
            Seq = seq
        };

        SetData(proto);
    }
}
