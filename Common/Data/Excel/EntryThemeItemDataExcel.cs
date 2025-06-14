namespace KianaBH.Data.Excel;

[ResourceEntity("EntryThemeItemData.json")]
public class EntryThemeItemDataExcel : ExcelResource
{
    public int ThemeItemID { get; set; }
    public override int GetId()
    {
        return ThemeItemID;
    }

    public override void Loaded()
    {
        GameData.EntryThemeItemData.Add(ThemeItemID, this);
    }
}