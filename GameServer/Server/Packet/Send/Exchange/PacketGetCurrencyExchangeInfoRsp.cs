using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Exchange;

public class PacketGetCurrencyExchangeInfoRsp : BasePacket
{
    public PacketGetCurrencyExchangeInfoRsp() : base(CmdIds.GetCurrencyExchangeInfoRsp)
    {
        var proto = new GetCurrencyExchangeInfoRsp
        {
        
        };

        SetData(proto);
    }
}
