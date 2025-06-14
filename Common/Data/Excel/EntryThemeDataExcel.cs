namespace KianaBH.Data.Excel;

[ResourceEntity("EntryThemeData.json")]
public class EntryThemeDataExcel : ExcelResource
{
    public uint SpaceShipConfigId { get; set; }
    public List<uint> ThemeBgmConfigList { get; set; } = [];
    public List<uint> ThemeTagList { get; set; } = [];
    public override int GetId()
    {
        return (int)SpaceShipConfigId;
    }

    public override void Loaded()
    {
        GameData.EntryThemeData.Add(GetId(), this);
    }
}