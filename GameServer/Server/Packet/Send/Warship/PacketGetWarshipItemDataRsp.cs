using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Warship;

public class PacketGetWarshipItemDataRsp : BasePacket
{
    public PacketGetWarshipItemDataRsp() : base(CmdIds.GetWarshipItemDataRsp)
    {
        var proto = new GetWarshipItemDataRsp 
        { 
            IsAll = true,
            WarshipItemIdList = { GameData.EntryThemeItemData.Values.Select(x => (uint)x.ThemeItemID) }
        };

        SetData(proto);
    }
}
