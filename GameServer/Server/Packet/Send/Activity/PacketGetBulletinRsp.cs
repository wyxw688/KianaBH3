using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetBulletinRsp : BasePacket
{
    public PacketGetBulletinRsp() : base(CmdIds.GetBulletinRsp)
    {
        var proto = new GetBulletinRsp
        {
            IsAll = true,
        };

        SetData(proto);
    }
}
