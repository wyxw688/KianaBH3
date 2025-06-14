using KianaBH.GameServer.Game.Player;
using KianaBH.GameServer.Server.Packet.Send.Client;
using KianaBH.Proto;
using KianaBH.Database.Client;

namespace KianaBH.GameServer.Server.Packet.Recv.Client;

[Opcode(CmdIds.SetClientDataReq)]
public class HandlerSetClientDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = SetClientDataReq.Parser.ParseFrom(data);
        PlayerInstance player = connection.Player!;
        var clientData = player.ClientData!.Clients.FirstOrDefault(c => c.Id == req.ClientData.Id && c.Type == req.ClientData.Type);
        if (clientData == null)
        {
            player.ClientData.Clients.Add(new ClientDBData
            {
                Id = req.ClientData.Id,
                Type = req.ClientData.Type,
                Data = req.ClientData.Data.ToByteArray(),
            });
        }
        await connection.SendPacket(new PacketSetClientDataRsp(req.ClientData.Id,req.ClientData.Type));
    }
}
