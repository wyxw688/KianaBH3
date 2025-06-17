
namespace KianaBH.Data.Excel;

[ResourceEntity("UltraEndlessFloor.json")]
public class UltraEndlessFloorExcel : ExcelResource
{
    public int NeedScore { get; set; }
    public int MaxScore { get; set; }
    public int FloorID { get; set; }
    public int StageID { get; set; }

    public override int GetId()
    {
        return StageID;
    }

    public override void Loaded()
    {
        if (!GameData.UltraEndlessFloorData.ContainsKey(StageID))
        {
            GameData.UltraEndlessFloorData[StageID] = new List<UltraEndlessFloorExcel>();
        }
        GameData.UltraEndlessFloorData[StageID].Add(this);
    }
}
