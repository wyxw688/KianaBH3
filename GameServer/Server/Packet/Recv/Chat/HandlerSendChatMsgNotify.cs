using KianaBH.GameServer.Command;
using KianaBH.GameServer.Server.Packet.Send.Chat;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Recv.Chat;

[Opcode(CmdIds.SendChatMsgNotify)]
public class HandlerSendChatMsgNotify : Handler
{
    public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
    {
        var req = SendChatMsgNotify.Parser.ParseFrom(data);
        var player = connection.Player!;
        if (player == null) return;

        string msg = req.ChatMsg.Content.Items.Where(item => item.MsgStr != null).FirstOrDefault()?.MsgStr!;
        if (msg == null) return;

        await player.WorldChatManager!.SendMessage(msg,req.ChatMsg);
    }
}
