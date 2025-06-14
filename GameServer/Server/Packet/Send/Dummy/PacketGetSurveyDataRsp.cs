using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetSurveyDataRsp : BasePacket
{
    public PacketGetSurveyDataRsp() : base(CmdIds.GetSurveyDataRsp)
    {
        var proto = new GetSurveyDataRsp
        {
        
        };

        SetData(proto);
    }
}
