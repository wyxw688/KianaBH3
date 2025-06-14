using KianaBH.GameServer.Server.Packet.Send.MasterPupil;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.MasterPupil;

[Opcode(CmdIds.GetMasterPupilMainDataReq)]
public class HandlerGetMasterPupilMainDataReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        await connection.SendPacket(new PacketGetMasterPupilMainDataRsp());
    }
}
