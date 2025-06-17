using KianaBH.GameServer.Game.Player;
using KianaBH.KcpSharp;
using KianaBH.Proto;

namespace KianaBH.GameServer.Server.Packet.Send.Elf;

public class PacketGetElfDataRsp : BasePacket
{
    public PacketGetElfDataRsp(PlayerInstance player) : base(CmdIds.GetElfDataRsp)
    {
        var proto = new GetElfDataRsp
        {
            ElfList = { player.ElfManager!.ElfData.Elfs.Select(x => x.ToProto()) }
        };

        SetData(proto);
    }
}
