using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Event;

public class PacketGetGalInteractTriggerEventRsp : BasePacket
{
    public PacketGetGalInteractTriggerEventRsp(uint avatarId) : base(CmdIds.GetGalInteractTriggerEventRsp)
    {
        var proto = new GetGalInteractTriggerEventRsp
        {
            AvatarId = avatarId
        };

        SetData(proto);
    }
}
