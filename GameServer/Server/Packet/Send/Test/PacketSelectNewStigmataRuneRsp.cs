using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketSelectNewStigmataRuneRsp : BasePacket
{
    public PacketSelectNewStigmataRuneRsp() : base(CmdIds.SelectNewStigmataRuneRsp)
    {
        var proto = new SelectNewStigmataRuneRsp
        {
        
        };

        SetData(proto);
    }
}
