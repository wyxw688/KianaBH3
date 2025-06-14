using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Mission;

public class PacketGetMissionThemeDataRsp : BasePacket
{
    public PacketGetMissionThemeDataRsp() : base(CmdIds.GetMissionThemeDataRsp)
    {
        // TODO: Implement

        var proto = new GetMissionThemeDataRsp
        {
            IsGetAll = true,
        };

        SetData(proto);
    }
}
