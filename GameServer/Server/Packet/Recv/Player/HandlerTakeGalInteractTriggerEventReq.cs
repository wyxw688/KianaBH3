using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Player;

[Opcode(CmdIds.TakeGalInteractTriggerEventReq)]
public class HandlerTakeGalInteractTriggerEventReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = TakeGalInteractTriggerEventReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketTakeGalInteractTriggerEventRsp(req.AvatarId,req.EventId));
    }
}
