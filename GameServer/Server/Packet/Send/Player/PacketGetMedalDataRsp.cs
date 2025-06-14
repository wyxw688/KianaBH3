using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetMedalDataRsp : BasePacket
{
    public PacketGetMedalDataRsp() : base(CmdIds.GetMedalDataRsp)
    {
        // TODO: Hardcoded
        var proto = new GetMedalDataRsp
        {
            MedalList =
            {
                new Medal { ExtraParam = 110, Id = 101113 },
                new Medal { Id = 101042 },
                new Medal { Id = 101089 },
                new Medal { Id = 101108 },
                new Medal { EndTime = 1757947552, Id = 101092 },
                new Medal { Id = 101115 },
                new Medal { Id = 101103 },
                new Medal { Id = 101112 },
                new Medal { ExtraParam = 30, Id = 101110 },
                new Medal { EndTime = 1743980267, Id = 101031 },
                new Medal { Id = 101125 },
                new Medal { Id = 101091 },
                new Medal { Id = 101047 },
                new Medal { EndTime = 1719062973, Id = 101094 },
                new Medal { Id = 101074 },
                new Medal { ExtraParam = 3010, Id = 101120 },
                new Medal { Id = 101026 },
                new Medal { Id = 101096 },
                new Medal { Id = 101085 },
                new Medal { Id = 101145 },
                new Medal { Id = 101098 },
                new Medal { Id = 101102 },
                new Medal { ExtraParam = 40, Id = 101117 },
                new Medal { Id = 101040 },
                new Medal { Id = 101134 },
                new Medal { Id = 101090 },
                new Medal { Id = 101067 },
                new Medal { Id = 101111 },
                new Medal { Id = 101088 },
                new Medal { EndTime = 1684342752, Id = 101121 },
                new Medal { Id = 101024 },
                new Medal { Id = 101118 },
                new Medal { ExtraParam = 268, Id = 101124 },
                new Medal { EndTime = 1681312396, Id = 101083 },
                new Medal { EndTime = 1675728702, Id = 101036 },
                new Medal { Id = 101106 },
                new Medal { Id = 101059 },
                new Medal { Id = 101105 },
                new Medal { Id = 101104 },
                new Medal { EndTime = 1757949121, Id = 101093 },
                new Medal { Id = 101116 },
                new Medal { EndTime = 1661813717, Id = 101069 },
                new Medal { EndTime = 1719448204, Id = 101030 },
                new Medal { ExtraParam = 49, Id = 101127 },
                new Medal { Id = 101109 },
                new Medal { ExtraParam = 1593836710, Id = 101142 },
                new Medal { Id = 101025 },
                new Medal { ExtraParam = 4, Id = 101122 },
                new Medal { Id = 101099 },
                new Medal { Id = 101146 },
                new Medal { Id = 101107 },
                new Medal { Id = 101100 },
                new Medal { Id = 101126 },
                new Medal { EndTime = 1664198688, Id = 101079 }
            }
        };

        SetData(proto);
    }
}
