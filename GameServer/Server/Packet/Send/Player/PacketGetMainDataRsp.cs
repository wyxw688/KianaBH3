using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetMainDataRsp : BasePacket
{
    public PacketGetMainDataRsp(PlayerInstance player) : base(CmdIds.GetMainDataRsp)
    {
        SetData(player.ToProto());
    }

    public PacketGetMainDataRsp(uint FirstAvatarId, uint SecondAvatarId) : base(CmdIds.GetMainDataRsp)
    {
        var proto = new GetMainDataRsp
        {
            WarshipAvatar = new WarshipAvatarData
            {
                WarshipFirstAvatarId = FirstAvatarId,
                WarshipSecondAvatarId = SecondAvatarId,
            },
            TypeList = { 35 },
        };

        SetData(proto);
    }
}
