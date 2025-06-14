using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetThemeDataRsp : BasePacket
{
    public PacketGetThemeDataRsp() : base(CmdIds.GetThemeDataRsp)
    {

        var proto = new GetThemeDataRsp
        {
            ThemeList =
            {
                GameData.ThemeDataAvatar.Values.Select(x => new ThemeData
                {
                    BeginTime = 1583373600,
                    EndTime = 2080843200,
                    ThemeId = x.AvatarData
                })
            }
        };

        SetData(proto);
    }
}
