using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Client;

public class PacketGetClientSettingRsp : BasePacket
{
    public PacketGetClientSettingRsp(uint ClientSettingType) : base(CmdIds.GetClientSettingRsp)
    {
        var proto = new GetClientSettingRsp
        {
            ClientSettingType = ClientSettingType,
            IsWeeklyGuideSwitchOn = true,
        };

        SetData(proto);
    }
}
