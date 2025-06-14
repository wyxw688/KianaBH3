using KianaBH.GameServer.Server.Packet.Send.Dummy;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Dummy;

[Opcode(CmdIds.GetPlotListReq)]
public class HandlerGetPlotListReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetPlotListRsp());
    }
}
