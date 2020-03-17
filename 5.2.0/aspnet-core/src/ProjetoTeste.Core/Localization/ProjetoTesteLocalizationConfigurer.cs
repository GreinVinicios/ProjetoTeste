using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ProjetoTeste.Localization
{
    public static class ProjetoTesteLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ProjetoTesteConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ProjetoTesteLocalizationConfigurer).GetAssembly(),
                        "ProjetoTeste.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
