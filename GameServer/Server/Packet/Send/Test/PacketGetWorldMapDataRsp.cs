using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGetWorldMapDataRsp : BasePacket
{
    public PacketGetWorldMapDataRsp() : base(CmdIds.GetWorldMapDataRsp)
    {
        // TODO: Hardcoded
        var proto = new GetWorldMapDataRsp
        {
            WorldMapList =
            {
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 1,
                    WorldMapId = 1
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 2,
                    WorldMapId = 2
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    HighLightMaxLevel = 30,
                    HighLightMinLevel = 25,
                    Id = 3,
                    WorldMapId = 3
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 5,
                    Weight = 1,
                    WorldMapId = 5
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    HighLightMaxLevel = 88,
                    HighLightMinLevel = 15,
                    Id = 6,
                    Weight = 1,
                    WorldMapId = 6
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    HighLightMaxLevel = 40,
                    HighLightMinLevel = 30,
                    Id = 7,
                    Weight = 1,
                    WorldMapId = 7
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 8,
                    Weight = 1,
                    WorldMapId = 8
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 9,
                    Weight = 1,
                    WorldMapId = 9
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 10,
                    Weight = 1,
                    WorldMapId = 10
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 11,
                    Weight = 1,
                    WorldMapId = 11
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 49,
                    Weight = 1,
                    WorldMapId = 12
                },
                new WorldMapData
                {
                    AdvanceTime = 1563069600,
                    BeginTime = 1563069600,
                    EndTime = 2060107199,
                    HighLightMaxLevel = 99,
                    HighLightMinLevel = 20,
                    Id = 121,
                    Weight = 205,
                    WorldMapId = 2107
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    HighLightMaxLevel = 99,
                    HighLightMinLevel = 50,
                    Id = 286,
                    Weight = 1,
                    WorldMapId = 18
                },
                new WorldMapData
                {
                    AdvanceTime = 1611712800,
                    BeginTime = 1611712800,
                    EndTime = 2060107199,
                    HighLightMaxLevel = 88,
                    HighLightMinLevel = 15,
                    Id = 307,
                    Weight = 1,
                    WorldMapId = 2221
                },
                new WorldMapData
                {
                    AdvanceTime = 1705716000,
                    BeginTime = 1705716000,
                    EndTime = 2060107199,
                    Id = 1004,
                    Weight = 1,
                    WorldMapId = 1004
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    Id = 445,
                    Weight = 1000,
                    WorldMapId = 2313
                },
                new WorldMapData
                {
                    AdvanceTime = 1300046400,
                    BeginTime = 1300046400,
                    EndTime = 2060107199,
                    HighLightMaxLevel = 30,
                    HighLightMinLevel = 25,
                    Id = 451,
                    WorldMapId = 19
                },
                new WorldMapData
                {
                    AdvanceTime = 1730080800,
                    BeginTime = 1730080800,
                    EndTime = 1880308800,
                    Id = 452,
                    Weight = 1301,
                    WorldMapId = 2317
                },
                new WorldMapData
                {
                    AdvanceTime = 1729108800,
                    BeginTime = 1729108800,
                    EndTime = 1880308800,
                    Id = 458,
                    Weight = 122,
                    WorldMapId = 2320
                }
            }
        };

        SetData(proto);
    }
}
