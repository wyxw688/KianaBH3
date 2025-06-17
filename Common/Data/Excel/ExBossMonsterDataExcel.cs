namespace KianaBH.Data.Excel;

[ResourceEntity("ExBossMonsterData.json")]
public class ExBossMonsterDataExcel : ExcelResource
{
    public int BossId { get; set; }
    public override int GetId()
    {
        return BossId;
    }

    public override void Loaded()
    {
        GameData.ExBossMonsterData.Add(BossId, this);
    }
}