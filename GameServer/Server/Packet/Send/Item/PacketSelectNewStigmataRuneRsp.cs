using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Item;

public class PacketSelectNewStigmataRuneRsp : BasePacket
{
    public PacketSelectNewStigmataRuneRsp(uint selectUniqueId, bool isSelect) : base(CmdIds.SelectNewStigmataRuneRsp)
    {
        var proto = new SelectNewStigmataRuneRsp
        {
            SelectUniqueId = selectUniqueId,
            IsSelect = isSelect
        };

        SetData(proto);
    }
}
