using KianaBH.GameServer.Server.Packet.Send.Stage;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Stage;

[Opcode(CmdIds.StageEndReq)]
public class HandlerStageEndReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = StageEndReq.Parser.ParseFrom(data);
        MemoryStream ms = new(req.Body.ToByteArray());
        using BinaryReader br = new(ms);
        byte[] body = br.ReadBytes((int)ms.Length);
        var reqBody = StageEndReqBody.Parser.ParseFrom(body);
        await connection.SendPacket(new PacketStageEndRsp(reqBody.StageId,reqBody.EndStatus));
    }
}
