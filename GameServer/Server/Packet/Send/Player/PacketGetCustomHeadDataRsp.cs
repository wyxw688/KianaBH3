using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetCustomHeadDataRsp : BasePacket
{
    public PacketGetCustomHeadDataRsp() : base(CmdIds.GetCustomHeadDataRsp)
    {
        var proto = new GetCustomHeadDataRsp 
        { 
            CustomHeadList = 
            {
                GameData.CustomHeadData.Values.Select(x => new CustomHead
                {
                    Id=x.HeadID,
                })
            }
        };

        SetData(proto);
    }
}
