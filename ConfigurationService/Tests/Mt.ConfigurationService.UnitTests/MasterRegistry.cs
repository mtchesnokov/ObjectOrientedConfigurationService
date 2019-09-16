using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.Services.Helpers;
using StructureMap;

namespace Mt.ConfigurationService.UnitTests
{
   public class MasterRegistry : Registry
   {
      public MasterRegistry()
      {
         For<IAppSettingsProvider>().Use<AppSettingsProvider>();
         For<IConnectionStringsProvider>().Use<ConnectionStringsProvider>();
      }
   }
}