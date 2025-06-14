using KianaBH.Util.Extensions;
using KianaBH.Configuration;

namespace KianaBH.Data.Models.Dispatch;

public class QueryGatewayResponse
{
    public long ServerCurTime { get; set; } = Extensions.GetUnixSec();
    public int ServerCurTimezone { get; set; } = (int)TimeZoneInfo.Local.GetUtcOffset(DateTime.Now).TotalHours;
    public string RegionName { get; set; } = "KianaBH";
    public string Msg { get; set; } = "";
    public bool IsDataReady { get; set; } = true;
    public int Retcode { get; set; }

    public string? AccountUrl { get; set; }
    public ServerInfo? Gameserver { get; set; }
    public ServerInfo? Gateway { get; set; }
    public List<string> ExResourceUrlList { get; set; } = [];
    public List<string> ExAudioAndVideoUrlList { get; set; } = [];
    public List<string> AssetBundleUrlList { get; set; } = [];
    public HotfixManfiset? Manifest { get; set; }
    public Dictionary<string, object> Ext { get; set; } = new();

    public class ServerInfo
    {
        public string? Ip { get; set; }
        public bool IsKcp { get; set; }
        public int Port { get; set; }
    }
}