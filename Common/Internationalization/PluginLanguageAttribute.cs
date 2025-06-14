using KianaBH.Enums.Language;

namespace KianaBH.Internationalization;

[AttributeUsage(AttributeTargets.Class)]
public class PluginLanguageAttribute(ProgramLanguageTypeEnum languageType) : Attribute
{
    public ProgramLanguageTypeEnum LanguageType { get; } = languageType;
}