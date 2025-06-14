using KianaBH.Data;
using KianaBH.GameServer.Command;
using KianaBH.Internationalization;
using KianaBH.Util;
using Newtonsoft.Json;
using System.Text;

namespace KianaBH.KianaBH.Tool;

public static class HandbookGenerator
{
    public static void GenerateAll()
    {
        var directory = new DirectoryInfo(ConfigManager.Config.Path.ResourcePath + "/TextMap");
        var handbook = new DirectoryInfo(ConfigManager.Config.Path.HandbookPath);
        if (!handbook.Exists) handbook.Create();
        if (!directory.Exists) return;

        foreach (var langFile in directory.GetFiles())
        {
            if (langFile.Extension != ".json") continue;
            var lang = langFile.Name.Replace("TextMap", "").Replace(".json", "");

            // Check if handbook needs to regenerate
            var handbookPath = $"{ConfigManager.Config.Path.HandbookPath}/Handbook{lang}.txt";
            if (File.Exists(handbookPath))
            {
                var handbookInfo = new FileInfo(handbookPath);
                if (handbookInfo.LastWriteTime >= langFile.LastWriteTime)
                    continue; // Skip if handbook is newer than language file
            }

            Generate(lang);
        }

        Logger.GetByClassName()
            .Info(I18NManager.Translate("Server.ServerInfo.GeneratedItem", I18NManager.Translate("Word.Handbook")));
    }

    public static void Generate(string lang)
    {
        var textMapPath = ConfigManager.Config.Path.ResourcePath + "/TextMap/TextMap" + lang + ".json";
        var fallbackTextMapPath = ConfigManager.Config.Path.ResourcePath + "/TextMap/TextMap" +
                                  ConfigManager.Config.ServerOption.FallbackLanguage + ".json";
        if (!File.Exists(textMapPath))
        {
            Logger.GetByClassName().Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", textMapPath,
                I18NManager.Translate("Word.NotFound")));
            return;
        }

        if (!File.Exists(fallbackTextMapPath))
        {
            Logger.GetByClassName().Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", textMapPath,
                I18NManager.Translate("Word.NotFound")));
            return;
        }

        var textMap = JsonConvert.DeserializeObject<Dictionary<long, string>>(File.ReadAllText(textMapPath));
        var fallbackTextMap =
            JsonConvert.DeserializeObject<Dictionary<long, string>>(File.ReadAllText(fallbackTextMapPath));

        if (textMap == null || fallbackTextMap == null)
        {
            Logger.GetByClassName().Error(I18NManager.Translate("Server.ServerInfo.FailedToReadItem", textMapPath,
                I18NManager.Translate("Word.Error")));
            return;
        }

        var builder = new StringBuilder();
        builder.AppendLine("#Handbook generated in " + DateTime.Now.ToString("yyyy/MM/dd HH:mm"));
        builder.AppendLine();
        builder.AppendLine("#Command");
        builder.AppendLine();
        GenerateCmd(builder, lang);

        builder.AppendLine();
        WriteToFile(lang, builder.ToString());
    }

    public static void GenerateCmd(StringBuilder builder, string lang)
    {
        foreach (var cmd in CommandManager.CommandInfo)
        {
            builder.Append("\t" + cmd.Key);
            var desc = I18NManager.TranslateAsCertainLang(lang, cmd.Value.Description).Replace("\n", "\n\t\t");
            builder.AppendLine(": " + desc);
        }
    }

    public static void WriteToFile(string lang, string content)
    {
        File.WriteAllText($"{ConfigManager.Config.Path.HandbookPath}/Handbook{lang}.txt", content);
    }
}