using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Test;

public class PacketLoginWishGetMainDataRsp : BasePacket
{
    public PacketLoginWishGetMainDataRsp() : base(CmdIds.LoginWishGetMainDataRsp)
    {
        // TODO: Hardcoded
        var proto = new LoginWishGetMainDataRsp
        {
            ActivityList =
            {
                new LoginWishActivity
                {
                    ActivityId = 19,
                    BeginTime = 1729540800,
                    EndTime = 1880308800,
                    LoginDays = 1,
                    ShowBeginTime = 1729454400,
                    ShowEndTime = 1880308800
                }
            }
        };

        SetData(proto);
    }
}
