using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Client;

public class PacketSetClientDataRsp : BasePacket
{
    public PacketSetClientDataRsp(uint Id, ClientDataType Type) : base(CmdIds.SetClientDataRsp)
    {
        var proto = new SetClientDataRsp
        {
            Id = Id,
            Type = Type
        };

        SetData(proto);
    }
}
