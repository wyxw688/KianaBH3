using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGrandKeyActivateSkillRsp : BasePacket
{
    public PacketGrandKeyActivateSkillRsp() : base(CmdIds.GrandKeyActivateSkillRsp)
    {
        var proto = new GrandKeyActivateSkillRsp
        {
        
        };

        SetData(proto);
    }
}
