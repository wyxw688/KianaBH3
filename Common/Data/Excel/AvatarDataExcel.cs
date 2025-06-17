using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("AvatarData.json")]
public class AvatarDataExcel : ExcelResource
{
    [JsonPropertyName("avatarID")] public int AvatarID { get; set; }
    [JsonPropertyName("unlockStar")] public int UnlockStar { get; set; }
    [JsonPropertyName("initialWeapon")] public int InitialWeapon { get; set; }
    [JsonPropertyName("skillList")] public List<int> SkillList { get; set; } = [];
    public string FaceAnimationGroupName { get; set; } = "";
    public int DefaultDressId { get; set; }
    [JsonPropertyName("fullName")] public HashName FullName { get; set; } = new();

    public override int GetId()
    {
        return AvatarID;
    }

    public override void Loaded()
    {
        if (AvatarID != 316 && (AvatarID < 9000 || AvatarID > 20000))
        {
            GameData.AvatarData.Add(AvatarID, this);
        }
        
    }
}

public class HashName
{
    public long hash { get; set; } = 0;
}