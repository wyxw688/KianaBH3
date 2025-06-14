using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Player;

public class PacketGetPlayerTokenRsp : BasePacket
{
    public PacketGetPlayerTokenRsp(PlayerInstance player,string token, uint accountType) : base(CmdIds.GetPlayerTokenRsp)
    {
        var proto = new GetPlayerTokenRsp
        {
            Retcode = GetPlayerTokenRsp.Types.Retcode.Succ,
            Token = token,
            AccountType = accountType,
            Uid = (uint)player.Data.Uid,
            AccountUid = player.Data.Uid.ToString()
        };

        SetData(proto);
    }

    public PacketGetPlayerTokenRsp(GetPlayerTokenRsp.Types.Retcode retcode) : base(CmdIds.GetPlayerTokenRsp)
    {
        var proto = new GetPlayerTokenRsp
        {
            Retcode = retcode,
        };

        SetData(proto);
    }
}