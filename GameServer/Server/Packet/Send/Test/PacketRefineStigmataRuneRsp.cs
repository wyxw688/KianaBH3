using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketRefineStigmataRuneRsp : BasePacket
{
    public PacketRefineStigmataRuneRsp() : base(CmdIds.RefineStigmataRuneRsp)
    {
        var proto = new RefineStigmataRuneRsp
        {
        
        };

        SetData(proto);
    }
}
