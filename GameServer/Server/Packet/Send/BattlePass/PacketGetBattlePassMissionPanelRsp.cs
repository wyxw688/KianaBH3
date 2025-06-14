using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.BattlePass;

public class PacketGetBattlePassMissionPanelRsp : BasePacket
{
    public PacketGetBattlePassMissionPanelRsp() : base(CmdIds.GetBattlePassMissionPanelRsp)
    {
        var proto = new GetBattlePassMissionPanelRsp
        {
        
        };

        SetData(proto);
    }
}
