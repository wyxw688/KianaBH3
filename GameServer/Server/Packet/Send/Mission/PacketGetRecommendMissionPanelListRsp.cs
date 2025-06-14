using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Mission;

public class PacketGetRecommendMissionPanelListRsp : BasePacket
{
    public PacketGetRecommendMissionPanelListRsp() : base(CmdIds.GetRecommendMissionPanelListRsp)
    {
        //var proto = new GetRecommendMissionPanelListRsp 
        //{
        //    Retcode = GetRecommendMissionPanelListRsp.Types.Retcode.NotOpen, // set to NotOpen to prevent null reference error pop up
        //    RecommendMissionPanelList = 
        //    {
        //        GameData.RecommendPanelData.Values.Select(x => new RecommendMissionPanel
        //        {
        //            PanelId = x.PanelId,
        //            IsPanelShow = true,
        //        })
        //    }
        //};

        var proto = new GetRecommendMissionPanelListRsp
        {
            Retcode = GetRecommendMissionPanelListRsp.Types.Retcode.NotOpen, // set to NotOpen to prevent null reference error pop up
        };

        SetData(proto);
    }
}
