using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Elf;

public class PacketGetElfDataRsp : BasePacket
{
    public PacketGetElfDataRsp() : base(CmdIds.GetElfDataRsp)
    {
        var proto = new GetElfDataRsp // TODO: GET FROM DB
        {
            ElfList =
            {
                new Proto.Elf
                {
                    ElfId = 101,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 10101,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10102,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10103,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10105,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10106,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10107,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 101011,
                        SkillLevel = 6
                        },
                        new ElfSkill
                        {
                        SkillId = 101021,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 101032,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 101033,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 101034,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 101035,
                        SkillLevel = 4
                        }
                    },
                    Star = 7
                },
                new Proto.Elf
                {
                    ElfId = 102,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 10201,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10202,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10203,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 10205,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10206,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10207,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 102011,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 102031,
                        SkillLevel = 6
                        },
                        new ElfSkill
                        {
                        SkillId = 102032,
                        SkillLevel = 6
                        },
                        new ElfSkill
                        {
                        SkillId = 102033,
                        SkillLevel = 6
                        },
                        new ElfSkill
                        {
                        SkillId = 102034,
                        SkillLevel = 6
                        }
                    },
                    Star = 7
                },
                new Proto.Elf
                {
                    ElfId = 106,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 10601,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10602,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10603,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10604,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 10605,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10606,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10607,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 106011,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 106012,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 106013,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 106021,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 106022,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 106031,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 106032,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 106041,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 106042,
                        SkillLevel = 4
                        }
                    },
                    Star = 4
                },
                new Proto.Elf
                {
                    ElfId = 108,
                    Exp = 1,
                    Level = 80,
                    SkillList = {
                        new ElfSkill
                        {
                        SkillId = 10801,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10802,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10803,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10804,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10805,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10806,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 10807,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 108011,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 108012,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 108013,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 108021,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 108022,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 108023,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 108031,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 108032,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 108041,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 108042,
                        SkillLevel = 5
                        }
                    },
                    Star = 7
                },
                new Proto.Elf
                {
                    ElfId = 110,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 11001,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 11002,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 11003,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 11004,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 11005,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 11006,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 11007,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 110011,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 110021,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 110031,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 110041,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 110051,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 110071,
                        SkillLevel = 5
                        }
                    },
                    Star = 2
                },
                new Proto.Elf
                {
                    ElfId = 111,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 12001,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 12002,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 12003,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 12004,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 12005,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 12006,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 12007,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 120011,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 120021,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 120031,
                        SkillLevel = 6
                        },
                        new ElfSkill
                        {
                        SkillId = 120041,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 120042,
                        SkillLevel = 4
                        }
                    },
                    Star = 2
                },
                new Proto.Elf
                {
                    ElfId = 112,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 13001,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 13002,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 13003,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 13004,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 13005,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 13006,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 13007,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 130011,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 130012,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 130013,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 130021,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 130022,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 130023,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 130031,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 130032,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 130033,
                        SkillLevel = 4
                        },
                        new ElfSkill
                        {
                        SkillId = 130041,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 130042,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 130043,
                        SkillLevel = 3
                        }
                    },
                    Star = 7
                },
                new Proto.Elf
                {
                    ElfId = 113,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 14001,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 14002,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 14003,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 14004,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 14005,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 14006,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 14007,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 140011,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 140021,
                        SkillLevel = 5
                        },
                        new ElfSkill
                        {
                        SkillId = 140031,
                        SkillLevel = 5
                        }
                    },
                    Star = 2
                },
                new Proto.Elf
                {
                    ElfId = 120,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 20005,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 20006,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 20007,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 200051,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 200071,
                        SkillLevel = 2
                        }
                    },
                    Star = 1
                },
                new Proto.Elf
                {
                    ElfId = 130,
                    Exp = 1,
                    Level = 80,
                    SkillList =
                    {
                        new ElfSkill
                        {
                        SkillId = 20005,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 20006,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 20007,
                        SkillLevel = 1
                        },
                        new ElfSkill
                        {
                        SkillId = 200051,
                        SkillLevel = 3
                        },
                        new ElfSkill
                        {
                        SkillId = 200071,
                        SkillLevel = 2
                        }
                    },
                    Star = 1
                }
            }
            
        };

        SetData(proto);
    }
}
