using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketPlayerLoginRsp : BasePacket
{
    public PacketPlayerLoginRsp(PlayerInstance player) : base(CmdIds.PlayerLoginRsp)
    {
        var proto = new PlayerLoginRsp
        {
            RegionId = 248,
            LoginSessionToken = (uint)player.Data.Uid,
            CgType = CGType.CgSevenChapter,
            RegionName = "overseas01"
        };

        SetData(proto);
    }
}
