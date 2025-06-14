using SqlSugar;

namespace KianaBH.Database.Player;

[SugarTable("player_guide")]
public class GuideData : BaseDatabaseDataHelper
{
    [SugarColumn(IsJson = true)] public List<uint> GuideFinishList { get; set; } = [];
}