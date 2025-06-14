using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Warship;

public class PacketGetWarshipDataRsp : BasePacket
{
    public PacketGetWarshipDataRsp() : base(CmdIds.GetWarshipDataRsp)
    {
        var proto = new GetWarshipDataRsp
        {
            IsAll = true,
            WarshipList =
            {
                GameData.EntryThemeData.Values
                .Select(theme => new WarshipThemeData
                {
                    WarshipId = theme.SpaceShipConfigId,
                    BgmPlayMode = 1,
                    IsWeatherFixed = false,
                    ComponentList =
                    {
                        theme.ThemeBgmConfigList.Count > 0
                            ? new List<WarshipComponent>
                            {
                                new()
                                {
                                    ComponentId = theme.ThemeBgmConfigList[0],
                                    Type = 2
                                }
                            }
                            : new List<WarshipComponent>()
                    },
                    WeatherIdx = theme.ThemeTagList.Count > 0 ? theme.ThemeTagList[0] : 0
                })
            }
        };
        SetData(proto);
    }
}
