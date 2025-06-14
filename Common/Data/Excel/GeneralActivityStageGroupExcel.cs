using System;

namespace KianaBH.Data.Excel;

[ResourceEntity("GeneralActivityStageGroup.json")]
public class GeneralActivityStageGroupExcel : ExcelResource
{
    public uint AcitivityId { get; set; }
    public uint StageGroupId { get; set; }

    public override int GetId()
    {
        return (int)AcitivityId;
    }

    public override void Loaded()
    {
        if (!GameData.GeneralActivityStageGroupData.ContainsKey(GetId()))
        {
            GameData.GeneralActivityStageGroupData[GetId()] = new List<GeneralActivityStageGroupExcel>();
        }
        GameData.GeneralActivityStageGroupData[GetId()].Add(this);
    }
}