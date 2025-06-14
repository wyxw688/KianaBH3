using KianaBH.KcpSharp;
using KianaBH.Proto;
using KianaBH.Util;
using KianaBH.Util.Extensions;

namespace KianaBH.GameServer.Server.Packet.Send.Chat;

public class PacketRecvChatMsgNotify : BasePacket
{
    public PacketRecvChatMsgNotify(ChatMsg msgs) : base(CmdIds.RecvChatMsgNotify)
    {
        var proto = new RecvChatMsgNotify
        {
            ChatMsgList = { msgs }
        };

        SetData(proto);
    }

    public PacketRecvChatMsgNotify(string message) : base(CmdIds.RecvChatMsgNotify)
    {
        var proto = new RecvChatMsgNotify
        {
            ChatMsgList = 
            {
                new ChatMsg
                {
                    Uid = (uint)ConfigManager.Config.ServerOption.ServerProfile.Uid,
                    Nickname = ConfigManager.Config.ServerOption.ServerProfile.Name,
                    Time = (uint)Extensions.GetUnixSec(),
                    Msg = message,
                    Channel = ChatMsg.Types.MsgChannel.World,
                    AvatarId = (uint)ConfigManager.Config.ServerOption.ServerProfile.AvatarId,
                    DressId = (uint)ConfigManager.Config.ServerOption.ServerProfile.DressId,
                    FrameId = (uint)ConfigManager.Config.ServerOption.ServerProfile.FrameId,
                    CustomHeadId = (uint)ConfigManager.Config.ServerOption.ServerProfile.HeadId,
                    CheckResult = new ChatMsgSensitiveCheckResult
                    {
                        RewriteText = message
                    },
                    Content = new ChatMsgContent
                    {
                        Items =
                        {
                            new ChatMsgItem
                            {
                                MsgStr = message,
                            }
                        }
                    }
                }
            }
        };
        SetData(proto);
    }
}
