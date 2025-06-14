using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Activity;

public class PacketGetBulletinActivityMissionRsp : BasePacket
{
    public PacketGetBulletinActivityMissionRsp() : base(CmdIds.GetBulletinActivityMissionRsp)
    {
        // TODO: Hardcoded

        var proto = new GetBulletinActivityMissionRsp
        {
            MissionGroupList =
            {
                new BulletinMissionGroup
                {
                    ActivityId = 5931
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5938,
                    MissionList =
                    {
                        new PanelMissionData
                        {
                            MissionId = 115679,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729828800,
                                    CycleId = 20006997,
                                    EndTime = 1880308800
                                }
                            }
                        }
                    }
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5941,
                    MissionList =
                    {
                        new PanelMissionData
                        {
                            MissionId = 687511,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729828800,
                                    CycleId = 20007074,
                                    EndTime = 1880308800
                                }
                            }
                        }
                    }
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5943,
                    MissionList =
                    {
                        new PanelMissionData
                        {
                            MissionId = 687521,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729828800,
                                    CycleId = 20007081,
                                    EndTime = 1880308800
                                }
                            }
                        }
                    }
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5944,
                    MissionList =
                    {
                        new PanelMissionData
                        {
                            MissionId = 687530,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007089,
                                    EndTime = 1880308800
                                }
                            }
                        }
                    }
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5949,
                    MissionList =
                    {
                        new PanelMissionData
                        {
                            MissionId = 687546,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007106,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687549,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007109,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687566,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007126,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687563,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007123,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687564,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007124,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687565,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007125,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687562,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007122,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687554,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007114,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687555,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007115,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687567,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007127,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687550,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007110,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687551,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007111,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687552,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007112,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687553,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007113,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687560,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007120,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687561,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007121,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687545,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007105,
                                    EndTime = 1880308800
                                }
                            }
                        }
                    }
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5952
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5953,
                    MissionList =
                    {
                        new PanelMissionData
                        {
                            MissionId = 687608,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007187,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687620,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007141,
                                    EndTime = 1880308800
                                }
                            }
                        },
                        new PanelMissionData
                        {
                            MissionId = 687716,
                            CycleList =
                            {
                                new PanelMissionData.Types.PanelMissionCycleData
                                {
                                    BeginTime = 1729108800,
                                    CycleId = 20007143,
                                    EndTime = 1880308800
                                }
                            }
                        }
                    }
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5959
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5962
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5963
                },
                new BulletinMissionGroup
                {
                    ActivityId = 5964
                }
            }
        };

        SetData(proto);
    }
}
