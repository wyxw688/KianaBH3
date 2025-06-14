namespace KianaBH.Data.Models.Dispatch;

public class QueryDispatchResponse
{
    public int Retcode { get; set; }
    public List<RegionInfo> RegionList { get; set; } = [];


    public class RegionInfo
    {
        public string? DispatchUrl { get; set; }
        public object? Ext { get; set; }
        public string? Name { get; set; }
        public int Retcode { get; set; }
        public string? Title { get; set; }
    }
}