using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("ThemeData_Avatar.json")]
public class ThemeDataAvatarExcel : ExcelResource
{
    public uint AvatarData { get; set; }
    public List<uint> BuffList { get; set; } = [];
    [JsonPropertyName("avatarIDList")] public List<uint> AvatarIDList { get; set; } = [];

    public override int GetId()
    {
        return (int)AvatarData;
    }

    public override void Loaded()
    {
        GameData.ThemeDataAvatar.Add(GetId(), this);
    }
}