using KianaBH.GameServer.Server.Packet.Send.Event;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Event;

[Opcode(CmdIds.GetGalInteractTriggerEventReq)]
public class HandlerGetGalInteractTriggerEventReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetGalInteractTriggerEventReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGetGalInteractTriggerEventRsp(req.AvatarId));
    }
}
