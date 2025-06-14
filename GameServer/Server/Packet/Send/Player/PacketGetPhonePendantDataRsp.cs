using KianaBH.Data;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetPhonePendantDataRsp : BasePacket
{
    public PacketGetPhonePendantDataRsp() : base(CmdIds.GetPhonePendantDataRsp)
    {
        //var proto = new GetPhonePendantDataRsp
        //{
        //    IsAll = true,
        //    PhonePendantList =
        //    {
        //        GameData.PhonePendantData.Keys.Select(Id => new PhonePendant
        //        {
        //            Id=(uint)Id
        //        })
        //    }
        //};

        // TODO: Hardcoded
        uint[] phones =
        [
            350005, 350011, 350012, 350013, 350014, 350015, 350026, 350041, 350044, 350045, 350049, 350051, 350053,
            350054, 350061, 350305
        ];

        var proto = new GetPhonePendantDataRsp
        {
            IsAll = true,
            PhonePendantList = { phones.Select(id => new PhonePendant { Id = id }) }
        };

        SetData(proto);
    }
}
