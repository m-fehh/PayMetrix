using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PayMetrix.Localization
{
    public static class PayMetrixLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PayMetrixConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PayMetrixLocalizationConfigurer).GetAssembly(),
                        "PayMetrix.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
