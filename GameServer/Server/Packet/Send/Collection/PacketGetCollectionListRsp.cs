using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Collection;

public class PacketGetCollectionListRsp : BasePacket
{
    public PacketGetCollectionListRsp() : base(CmdIds.GetCollectionListRsp)
    {
        var collections = GameData.CollectionData.Keys.Select(key => (uint)key);

        var proto = new GetCollectionListRsp 
        {
            CollectionIdList = { collections },
            ActiveCollectionIdList = { collections },
        };

        SetData(proto);
    }
}
