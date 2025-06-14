using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetPlayerCardRsp : BasePacket
{
    public PacketGetPlayerCardRsp() : base(CmdIds.GetPlayerCardRsp)
    {
        var proto = new GetPlayerCardRsp
        {
            Retcode = GetPlayerCardRsp.Types.Retcode.Fail, // set to fail to prevent null reference error pop up
        };

        SetData(proto);
    }
}
