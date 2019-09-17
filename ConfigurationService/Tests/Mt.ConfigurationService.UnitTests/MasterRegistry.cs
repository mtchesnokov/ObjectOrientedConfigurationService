using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.Services.Helpers;
using StructureMap;

namespace Mt.ConfigurationService.UnitTests
{
   public class MasterRegistry : Registry
   {
      public MasterRegistry()
      {
         For<IConfigItemsProvider<AppSetting>>().Use<AppSettingsProvider>();
         For<IConfigItemsProvider<ConnectionString>>().Use<ConnectionStringsProvider>();
      }
   }
}