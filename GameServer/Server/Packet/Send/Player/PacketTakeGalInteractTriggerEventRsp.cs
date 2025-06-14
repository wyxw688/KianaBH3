using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketTakeGalInteractTriggerEventRsp : BasePacket
{
    public PacketTakeGalInteractTriggerEventRsp(uint AvatarId, uint EventId) : base(CmdIds.TakeGalInteractTriggerEventRsp)
    {
        var proto = new TakeGalInteractTriggerEventRsp
        {
            AvatarId = AvatarId,
            EventId = EventId
        };

        SetData(proto);
    }
}
