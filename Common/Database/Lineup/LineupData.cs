using SqlSugar;

namespace KianaBH.Database.Lineup;

[SugarTable("Lineup")]
public class LineupData : BaseDatabaseDataHelper
{
    [SugarColumn(IsJson = true)] public Dictionary<int, LineupInfo> Lineups { get; set; } = [];
}

public class LineupInfo
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public uint AstraMateId { get; set; }
    public bool IsUsingAstraMate { get; set; }
    public List<uint> AvatarIds { get; set; } = [];
    public List<uint> ElfIds { get; set; } = [];
}