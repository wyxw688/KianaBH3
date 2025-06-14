using Google.Protobuf.Collections;
using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Battle;

public class PacketGetBuffEffectRsp : BasePacket
{
    public PacketGetBuffEffectRsp(RepeatedField<uint> EffectIdList) : base(CmdIds.GetBuffEffectRsp)
    {
        var proto = new GetBuffEffectRsp
        {
            AuraEffectList = { EffectIdList },
            EffectList =
            {
                EffectIdList.Select(id => new BuffEffect
                {
                    EffectId = id,
                    EndTime = (uint)Extensions.GetUnixSec() + 3600,
                })
            }
        };

        SetData(proto);
    }
}
