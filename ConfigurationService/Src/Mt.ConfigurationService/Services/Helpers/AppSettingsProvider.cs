using System.Collections.Generic;
using System.Configuration;
using Mt.ConfigurationService.Interfaces.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class AppSettingsProvider : IAppSettingsProvider
   {
      public IDictionary<string, string> GetAppSettings()
      {
         var appSettings = ConfigurationManager.AppSettings;

         var allKeys = appSettings.AllKeys;

         var result = new Dictionary<string, string>(allKeys.Length);

         foreach (var key in allKeys)
         {
            var value = appSettings[key];

            result.Add(key, value);
         }

         return result;
      }
   }
}