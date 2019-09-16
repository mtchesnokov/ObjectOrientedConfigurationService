using System.Collections.Generic;

namespace Mt.ConfigurationService.Interfaces.Helpers
{
   internal interface IAppSettingsProvider
   {
      IDictionary<string, string> GetAppSettings();
   }
}