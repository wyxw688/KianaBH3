using Google.Protobuf;
using KianaBH.Proto;
using SqlSugar;

namespace KianaBH.Database.Client;

[SugarTable("client_data")]
public class ClientData : BaseDatabaseDataHelper
{
    [SugarColumn(IsJson = true)] public List<ClientDBData> Clients { get; set; } = [];
}

public class ClientDBData
{
    public uint Id { get; set; }
    public ClientDataType Type { get; set; } = ClientDataType.ClientDataNone;
    public byte[] Data { get; set; } = Array.Empty<byte>();
    public Proto.ClientData ToProto()
    {
        var proto = new Proto.ClientData
        {
            Id = Id,
            Type = Type,
            Data = ByteString.CopyFrom(Data)
        };
        return proto;
    }
}