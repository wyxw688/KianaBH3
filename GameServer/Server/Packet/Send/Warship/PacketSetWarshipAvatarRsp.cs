using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Warship;

public class PacketSetWarshipAvatarRsp : BasePacket
{
    public PacketSetWarshipAvatarRsp() : base(CmdIds.SetWarshipAvatarRsp)
    {
        var proto = new SetWarshipAvatarRsp
        {
            Retcode = SetWarshipAvatarRsp.Types.Retcode.Succ,
        };

        SetData(proto);
    }
}
