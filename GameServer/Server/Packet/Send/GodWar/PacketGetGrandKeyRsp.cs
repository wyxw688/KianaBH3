using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.GodWar;

public class PacketGetGrandKeyRsp : BasePacket
{
    public PacketGetGrandKeyRsp() : base(CmdIds.GetGrandKeyRsp)
    {
        // TODO: Hardcoded
        var proto = new GetGrandKeyRsp
        {
            IsAll = true,
            KeyList =
            {
                new GrandKey
                {
                    Id = 203,
                    Level = 10,
                    ActivateLevel = 10,
                    BreachLevel = 1,
                    EndTime = 1975780800,
                    UnlockLevel = 50,
                    Skill = new GrandKeySkill
                    {
                        SkillId = 20310
                    }
                },
                new GrandKey
                {
                    Id = 208,
                    Level = 1,
                    UnlockLevel = 65
                },
                new GrandKey
                {
                    Id = 205,
                    Level = 10,
                    ActivateLevel = 10,
                    BreachLevel = 1,
                    EndTime = 1975780800,
                    UnlockLevel = 65,
                    Skill = new GrandKeySkill
                    {
                        SkillId = 20509
                    }
                },
                new GrandKey
                {
                    Id = 202,
                    Level = 10,
                    ActivateLevel = 10,
                    BreachLevel = 2,
                    EndTime = 1975780800,
                    UnlockLevel = 50,
                    Skill = new GrandKeySkill
                    {
                        SkillId = 20209
                    }
                },
                new GrandKey
                {
                    Id = 207,
                    Level = 1,
                    BreachLevel = 1,
                    UnlockLevel = 65
                },
                new GrandKey
                {
                    Id = 204,
                    Level = 1,
                    BreachLevel = 1,
                    UnlockLevel = 65
                },
                new GrandKey
                {
                    Id = 201,
                    Level = 10,
                    ActivateLevel = 10,
                    EndTime = 1975780800,
                    UnlockLevel = 50,
                    Skill = new GrandKeySkill
                    {
                        SkillId = 20109
                    }
                },
                new GrandKey
                {
                    Id = 206,
                    Level = 1,
                    BreachLevel = 1,
                    UnlockLevel = 35
                }
            }
        };

        SetData(proto);
    }
}
