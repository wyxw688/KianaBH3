using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace KianaBH.GameServer.Server.Packet.Send.Client;

public class PacketGetClientDataRsp : BasePacket
{
    public PacketGetClientDataRsp(uint id, ClientDataType type, PlayerInstance player) : base(CmdIds.GetClientDataRsp)
    {
        var proto = new GetClientDataRsp
        {
            Id = id,
            Type = type,
            ClientDataList = { player.ClientData!.Clients.Select(x => x.ToProto()) }
        };

        SetData(proto);
    }
}
