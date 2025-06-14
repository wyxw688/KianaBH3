using KianaBH.GameServer.Server.Packet.Send.Activity;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Activity;

[Opcode(CmdIds.GeneralActivityGetMainInfoReq)]
public class HandlerGeneralActivityGetMainInfoReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GeneralActivityGetMainInfoReq.Parser.ParseFrom(data);
        await connection.SendPacket(new PacketGeneralActivityGetMainInfoRsp(req.ActivityIdList));
    }
}
