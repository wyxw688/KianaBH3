using System.Text.Json.Serialization;

namespace KianaBH.Data.Excel;

[ResourceEntity("AvatarSubSkillData.json")]
public class AvatarSubSkillDataExcel : ExcelResource
{
    [JsonPropertyName("skillId")] public int SkillId { get; set; }
    [JsonPropertyName("unlockScoin")] public int UnlockScoin { get; set; }
    [JsonPropertyName("maxLv")] public int MaxLv { get; set; }
    [JsonPropertyName("avatarSubSkillId")] public int AvatarSubSkillId { get; set; }

    public override int GetId()
    {
        return AvatarSubSkillId;
    }

    public override void Loaded()
    {
      GameData.AvatarSubSkillData.Add(AvatarSubSkillId, this); 
    }
}