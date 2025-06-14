using KianaBH.Util.Extensions;
using Google.Protobuf;

namespace KianaBH.KcpSharp;

public class BasePacket(ushort cmdId)
{
    private const uint HEADER_CONST = 0x01234567;
    private const uint TAIL_CONST = 0x89ABCDEF;

    private uint HeadMagic { get; set; }
    private ushort PacketVersion { get; set; } = 1;
    private ushort ClientVersion { get; set; }
    private uint PacketId { get; set; }
    public uint UserId { get; set; }
    private uint UserIp { get; set; }
    private uint Sign { get; set; }
    private ushort SignType { get; set; }
    public ushort CmdId { get; set; } = cmdId;
    private ushort HeaderLength { get; set; }
    private uint BodyLength { get; set; }
    private byte[] Header { get; set; } = [];
    public byte[] Body { get; set; } = [];
    private uint TailMagic { get; set; }

    public void SetData(byte[] data)
    {
        Body = data;
    }

    public void SetData(IMessage message)
    {
        Body = message.ToByteArray();
    }

    public void SetData(string base64)
    {
        SetData(Convert.FromBase64String(base64));
    }

    public byte[] BuildPacket()
    {
        using MemoryStream? ms = new();
        using BinaryWriter? bw = new(ms);

        bw.WriteUInt32BE(HEADER_CONST);
        bw.WriteUInt16BE(PacketVersion);
        bw.WriteUInt16BE(ClientVersion);
        bw.WriteUInt32BE(PacketId);
        bw.WriteUInt32BE(UserId);
        bw.WriteUInt32BE(UserIp);
        bw.WriteUInt32BE(Sign);
        bw.WriteUInt16BE(SignType);
        bw.WriteUInt16BE(CmdId);
        bw.WriteUInt16BE((ushort)(Header.Length));
        bw.WriteUInt32BE((uint)(Body.Length));

        bw.Write(Header.ToArray());
        bw.Write(Body.ToArray());

        bw.WriteUInt32BE(TAIL_CONST);

        var packet = ms.ToArray();

        return packet;
    }
}