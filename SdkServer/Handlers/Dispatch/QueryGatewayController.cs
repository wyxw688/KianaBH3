using System.Text.RegularExpressions;
using KianaBH.Configuration;
using KianaBH.Data.Models.Dispatch;
using KianaBH.Util;
using KianaBH.Util.Crypto;
using Microsoft.AspNetCore.Mvc;

namespace KianaBH.SdkServer.Handlers.Dispatch;

[ApiController]
public class QueryGatewayController : ControllerBase
{
    [HttpGet("/query_gateway")]
    public IActionResult QueryGateway([FromQuery] DispatchQuery query, Logger logger)
    {
        var version = HotfixContainer.ExtractVersionNumber(query.Version);

        if (!ConfigManager.Hotfix.Hotfixes.TryGetValue(version, out var hotfix))
        {
            logger.Warn($"Client sent requesting unsupported game version: {version}");
            return BadRequest();
        }

        var serverInfo = new QueryGatewayResponse.ServerInfo
        {
            Ip = ConfigManager.Config.GameServer.PublicAddress,
            Port = ConfigManager.Config.GameServer.Port,
            IsKcp = true,
        };

        var assetBundleUrlList = UrlProvider.GetAssetBundleUrlList(query.Version!);
        var exResourceUrlList = UrlProvider.GetExResourceUrlList(query.Version!);
        var exAudioAndVideoUrlList = UrlProvider.GetExAudioAndVideoUrlList(query.Version!);

        var response = new QueryGatewayResponse
        {
            AccountUrl = $"{ConfigManager.Config.HttpServer.GetDisplayAddress()}/",
            Gameserver = serverInfo,
            Gateway = serverInfo,
            AssetBundleUrlList = assetBundleUrlList,
            ExResourceUrlList = exResourceUrlList,
            ExAudioAndVideoUrlList = exAudioAndVideoUrlList,
            Manifest = hotfix,
            Ext = new Dictionary<string, object>
            {
                { "ex_res_use_http", "0" },
                { "is_xxxx", "0" },
                { "elevator_model_path", "GameEntry/EVA/StartLoading_Model" },
                { "block_error_dialog", "1" },
                { "ex_res_pre_publish", "0" },
                { "ex_resource_url_list", exResourceUrlList },
                { "apm_switch_game_log", "1" },
                { "ex_audio_and_video_url_list", exAudioAndVideoUrlList },
                { "apm_log_dest", "2" },
                { "update_streaming_asb", "1" },
                { "use_multy_cdn", "1" },
                { "show_bulletin_empty_dialog_bg", "0" },
                { "ai_use_asset_boundle", "1" },
                { "res_use_asset_boundle", "1" },
                { "apm_log_level", "0" },
                { "apm_switch_crash", "1" },
                { "network_feedback_enable", "0" },
                { "new_audio_upload", "1" },
                { "apm_switch", "1" }
            }
        };

        return Ok(DispatchEncryption.EncryptDispatchContent(version, response));
    }
}

public static partial class UrlProvider
{
    [GeneratedRegex("^(.*?)_(os|gf|global)_(.*?)$")]
    private static partial Regex VersionRegex();

    public static List<string> GetAssetBundleUrlList(string version)
    {
        var match = VersionRegex().Match(version);
        if (!match.Success) return [];

        var type = match.Groups[2].Value;

        if (ConfigManager.Hotfix.UseLocalCache) return GetLocalUrlList(type, version);

        return type switch
        {
            "os" =>
            [
                "https://autopatchos.honkaiimpact3.com/asset_bundle/overseas01/1.1",
                "https://bundle-aliyun-os.honkaiimpact3.com/asset_bundle/overseas01/1.1",
            ],
            "gf" when version.Contains("beta") =>
            [
                "https://autopatchbeta.bh3.com/asset_bundle/beta_release/1.0",
                "https://autopatchbeta.bh3.com/asset_bundle/beta_release/1.0",
            ],
            "gf" =>
            [
                "https://bundle-qcloud.bh3.com/asset_bundle/android01/1.0",
                "https://bundle.bh3.com/asset_bundle/android01/1.0",
            ],
            "global" =>
            [
                "http://hk-bundle-west-mihayo.akamaized.net/asset_bundle/usa01/1.1",
                "http://bundle-aliyun-usa.honkaiimpact3.com/asset_bundle/usa01/1.1",
            ],
            _ =>
            [
                "https://bundle-aliyun-os.honkaiimpact3.com/asset_bundle/overseas01/1.1",
                "https://hk-bundle-os-mihayo.akamaized.net/asset_bundle/overseas01/1.1",
            ]
        };
    }

    public static List<string> GetExAudioAndVideoUrlList(string version)
    {
        var match = VersionRegex().Match(version);
        if (!match.Success) return [];

        var type = match.Groups[2].Value;

        if (ConfigManager.Hotfix.UseLocalCache) return GetLocalUrlList(type, version);

        return type switch
        {
            "os" =>
            [
                "autopatchos.honkaiimpact3.com/com.miHoYo.bh3oversea",
                "bigfile-aliyun-os.honkaiimpact3.com/com.miHoYo.bh3oversea",
            ],
            "gf" when version.Contains("beta") =>
            [
                "autopatchbeta.bh3.com/tmp/CGAudio",
                "autopatchbeta.bh3.com/tmp/CGAudio",
            ],
            _ =>
            [
                "bh3rd-beta-qcloud.bh3.com/tmp/CGAudio",
                "bh3rd-beta.bh3.com/tmp/CGAudio",
            ]
        };
    }

    public static List<string> GetExResourceUrlList(string version)
    {
        var match = VersionRegex().Match(version);
        if (!match.Success) return [];

        var type = match.Groups[2].Value;

        if (ConfigManager.Hotfix.UseLocalCache) return GetLocalUrlList(type, version);

        return type switch
        {
            "os" =>
            [
                "autopatchos.honkaiimpact3.com/com.miHoYo.bh3oversea",
                "bigfile-aliyun-os.honkaiimpact3.com/com.miHoYo.bh3oversea",
            ],
            "gf" when version.Contains("beta") =>
            [
                "autopatchbeta.bh3.com/tmp/beta",
                "autopatchbeta.bh3.com/tmp/beta",
            ],
            "gf" =>
            [
                "bundle-qcloud.bh3.com/tmp/Original",
                "bundle.bh3.com/tmp/Original",
            ],
            "global" =>
            [
                "hk-bundle-west-mihayo.akamaized.net/tmp/com.miHoYo.bh3global",
                "bigfile-aliyun-usa.honkaiimpact3.com/tmp/com.miHoYo.bh3global",
            ],
            _ =>
            [
                "bigfile-aliyun-os.honkaiimpact3.com/com.miHoYo.bh3oversea",
                "hk-bigfile-os-mihayo.akamaized.net/com.miHoYo.bh3oversea",
            ]
        };
    }

    private static List<string> GetLocalUrlList(string type, string version)
    {
        var formattedVersion = version.Replace(".", "_");
        var baseUrl =
            $"{ConfigManager.Config.HttpServer.GetDisplayAddress()}/statics/{type}/{formattedVersion}";
        return [baseUrl, baseUrl];
    }
}