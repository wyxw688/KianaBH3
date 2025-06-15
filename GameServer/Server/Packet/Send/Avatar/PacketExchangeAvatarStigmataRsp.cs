using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Avatar;

public class PacketExchangeAvatarStigmataRsp : BasePacket
{
    public PacketExchangeAvatarStigmataRsp(uint avatarId1, uint avatarId2, EquipmentSlot slot) : base(CmdIds.ExchangeAvatarStigmataRsp)
    {
        var proto = new ExchangeAvatarStigmataRsp
        {
            AvatarId1 = avatarId1,
            AvatarId2 = avatarId2,
            Slot = slot
        };

        SetData(proto);
    }
}
