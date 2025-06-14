using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketGetWorldMapRecommendRsp : BasePacket
{
    public PacketGetWorldMapRecommendRsp() : base(CmdIds.GetWorldMapRecommendRsp)
    {
        // TODO: Hardcoded
        var proto = new GetWorldMapRecommendRsp
        {
            ActivityRecommendList =
            {
                new WorldMapRecommend
                {
                    Weight = 110,
                    WorldMapId = 2317
                },
                new WorldMapRecommend
                {
                    Weight = 100,
                    WorldMapId = 2321
                }
            },
            PermanentRecommendList =
            {
                new WorldMapRecommend
                {
                    ActiveConditionList = { 201 },
                    Weight = 2,
                    WorldMapId = 9
                },
                new WorldMapRecommend
                {
                    Weight = 100,
                    WorldMapId = 7
                },
                new WorldMapRecommend
                {
                    ActiveConditionList = { 207 },
                    Weight = -100,
                    WorldMapId = 7
                },
                new WorldMapRecommend
                {
                    Weight = 86,
                    WorldMapId = 8
                },
                new WorldMapRecommend
                {
                    ActiveConditionList = { 214, 215 },
                    Weight = 1,
                    WorldMapId = 11
                },
                new WorldMapRecommend
                {
                    ActiveConditionList = { 216 },
                    Weight = 45,
                    WorldMapId = 18
                },
                new WorldMapRecommend
                {
                    Weight = 60,
                    WorldMapId = 1
                },
                new WorldMapRecommend
                {
                    Weight = 50,
                    WorldMapId = 2107
                },
                new WorldMapRecommend
                {
                    Weight = 70,
                    WorldMapId = 1004
                }
            }
        };

        SetData(proto);
    }
}
