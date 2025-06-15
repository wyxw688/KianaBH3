using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Item;

public class PacketRefineStigmataRuneRsp : BasePacket
{
    public PacketRefineStigmataRuneRsp(PlayerInstance player,int uniqueId, StigmataRefineTimesType type) : base(CmdIds.RefineStigmataRuneRsp)
    {
        var proto = new RefineStigmataRuneRsp
        {
            RuneGroupList = { player.InventoryManager!.Data!.StigmataItems.Find(x => x.UniqueId == uniqueId)!.ToWaitSelectRuneGroup() },
            TimesType = type
        };

        SetData(proto);
    }
}
