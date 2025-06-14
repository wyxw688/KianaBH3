using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Auth;

public class PacketGetAuthkeyRsp : BasePacket
{
    public PacketGetAuthkeyRsp(string AuthAppid) : base(CmdIds.GetAuthkeyRsp)
    {
        var proto = new GetAuthkeyRsp
        {
            AuthAppid = AuthAppid,
            Authkey = "0",
            SignType = 2,
            AuthkeyVer = 1,
        };

        SetData(proto);
    }
}
