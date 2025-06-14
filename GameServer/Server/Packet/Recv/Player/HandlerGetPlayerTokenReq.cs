using KianaBH.Data;
using KianaBH.Database;
using KianaBH.Database.Account;
using KianaBH.Database.Player;
using KianaBH.GameServer.Game.Player;
using KianaBH.GameServer.Server.Packet.Send.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util;

namespace KianaBH.GameServer.Server.Packet.Recv.Player;

[Opcode(CmdIds.GetPlayerTokenReq)]
public class HandlerGetPlayerTokenReq : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = GetPlayerTokenReq.Parser.ParseFrom(data);
        var account = AccountData.GetAccountByUid(int.Parse(req.AccountUid));
        if (account == null) 
        {
            await connection.SendPacket(new PacketGetPlayerTokenRsp(GetPlayerTokenRsp.Types.Retcode.AccountTypeError));
            return;
        }
        if (!ResourceManager.IsLoaded)
            // resource manager not loaded, return
            return;
        var prev = Listener.GetActiveConnection(account.Uid);
        if (prev != null)
        {
            await connection.SendPacket(new PacketGetPlayerTokenRsp(GetPlayerTokenRsp.Types.Retcode.ForbidVisitor));
            prev.Stop();
        }

        connection.State = SessionStateEnum.WAITING_FOR_LOGIN;
        var pd = DatabaseHelper.GetInstance<PlayerData>(int.Parse(req.AccountUid));
        connection.Player = pd == null ? new PlayerInstance(int.Parse(req.AccountUid)) : new PlayerInstance(pd);

        connection.DebugFile = Path.Combine(ConfigManager.Config.Path.LogPath, "Debug/", $"{req.AccountUid}/",
            $"Debug-{DateTime.Now:yyyy-MM-dd HH-mm-ss}.log");

        await connection.Player.OnGetToken();
        connection.Player.Connection = connection;

        await connection.SendPacket(new PacketGetPlayerTokenRsp(connection.Player!,req.Token,req.AccountType));
    }
}