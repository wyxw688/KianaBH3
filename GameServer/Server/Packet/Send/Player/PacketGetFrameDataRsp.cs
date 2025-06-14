using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetFrameDataRsp : BasePacket
{
    public PacketGetFrameDataRsp() : base(CmdIds.GetFrameDataRsp)
    {
        var proto = new GetFrameDataRsp 
        { 
            IsAll = true,
            FrameList =
            {
                GameData.FrameData.Values.Select(x => new FrameData
                {
                    Id=x.Id,
                    ExpireTime = (uint)Extensions.GetUnixSec() + 3600 * 24 * 7,
                })
            }
        };

        SetData(proto);
    }
}
