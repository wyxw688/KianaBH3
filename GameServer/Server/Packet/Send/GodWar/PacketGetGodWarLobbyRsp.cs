using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.GodWar;

public class PacketGetGodWarLobbyRsp : BasePacket
{
    public PacketGetGodWarLobbyRsp() : base(CmdIds.GetGodWarLobbyRsp)
    {
        // TODO: Hardcoded

        var proto = new GetGodWarLobbyRsp
        {
            GodWarId = 1,
            LobbyId = 2
        };

        SetData(proto);
    }
}
