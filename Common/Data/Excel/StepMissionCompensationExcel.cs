namespace KianaBH.Data.Excel;

[ResourceEntity("StepMissionCompensation.json")]
public class StepMissionCompensationExcel : ExcelResource
{
    public uint CompensationId { get; set; }
    public uint UnlockLevel { get; set; }
    public List<uint> MainLineStepIdList { get; set; } = [];
    public List<uint> NewChallengeStepIdList { get; set; } = [];
    public List<uint> OldChallengeStepIdList { get; set; } = [];

    public override int GetId()
    {
        return (int)CompensationId;
    }

    public override void Loaded()
    {
        GameData.StepMissionCompensationData.Add(GetId(), this);
    }
}