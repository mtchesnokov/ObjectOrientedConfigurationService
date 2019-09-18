using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces;
using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.Services;
using Mt.ConfigurationService.Services.Helpers;
using StructureMap;

namespace Mt.ConfigurationService.UnitTests
{
   public class MasterRegistry : Registry
   {
      public MasterRegistry()
      {
         For<IAppSettingValueParseService>().Use<AppSettingValueParseService>();
         For(typeof(IConfigurationService<>)).Use(typeof(ConfigurationService<>));
         For(typeof(IConfigItemProvider<>)).Use(typeof(ConfigItemProviderBase<>));
         For<IConfigItemsProvider<AppSetting>>().Use<AppSettingsProvider>();
         For<IConfigItemsProvider<ConnectionString>>().Use<ConnectionStringsProvider>();
      }
   }
}