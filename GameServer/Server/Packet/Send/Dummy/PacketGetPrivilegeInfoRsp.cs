using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Dummy;

public class PacketGetPrivilegeInfoRsp : BasePacket
{
    public PacketGetPrivilegeInfoRsp() : base(CmdIds.GetPrivilegeInfoRsp)
    {
        var proto = new GetPrivilegeInfoRsp
        {
            PrivilegeList =
            {
                new PrivilegeInfo
                {
                    ExpireTime = 1734001367,
                    PrivilegeId = 6,
                    RightInfoList =
                    {
                        new PrivilegeRightInfo
                        {
                            MaxUseTimes = 10,
                            NextAutoRefreshTime = 1730145600,
                            RightId = 4,
                            Type = 1
                        }
                    }
                },
                new PrivilegeInfo
                {
                    ExpireTime = 1668139199,
                    PrivilegeId = 19,
                    RightInfoList =
                    {
                        new PrivilegeRightInfo
                        {
                            MaxUseTimes = 10,
                            NextAutoRefreshTime = 1730145600,
                            RightId = 17,
                            TotalUsedTimes = 10,
                            Type = 4
                        }
                    }
                },
                new PrivilegeInfo
                {
                    ExpireTime = 1685678400,
                    PrivilegeId = 23,
                    RightInfoList =
                    {
                        new PrivilegeRightInfo
                        {
                            MaxUseTimes = 10,
                            NextAutoRefreshTime = 1730145600,
                            RightId = 21,
                            TotalUsedTimes = 10,
                            Type = 4
                        }
                    }
                },
                new PrivilegeInfo
                {
                    ExpireTime = 1700798399,
                    PrivilegeId = 25,
                    RightInfoList =
                    {
                        new PrivilegeRightInfo
                        {
                            MaxUseTimes = 10,
                            NextAutoRefreshTime = 1730145600,
                            RightId = 23,
                            TotalUsedTimes = 10,
                            Type = 4
                        }
                    }
                },
                new PrivilegeInfo
                {
                    ExpireTime = 1731643200,
                    PrivilegeId = 34,
                    RightInfoList =
                    {
                        new PrivilegeRightInfo
                        {
                            MaxUseTimes = 10,
                            NextAutoRefreshTime = 1730145600,
                            RightId = 32,
                            Type = 4
                        }
                    }
                }
            }
        };

        SetData(proto);
    }
}
