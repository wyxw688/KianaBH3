using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetTowerRaidActivityRsp : BasePacket
{
    public PacketGetTowerRaidActivityRsp() : base(CmdIds.GetTowerRaidActivityRsp)
    {
        var proto = new GetTowerRaidActivityRsp
        {
            Retcode = GetTowerRaidActivityRsp.Types.Retcode.NotOpen, // set to NotOpen to prevent null reference error pop up
        };

        SetData(proto);
    }
}
