using System.Collections.Generic;
using System.Configuration;
using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class AppSettingsProvider : IConfigItemsProvider<AppSetting>
   {
      public IEnumerable<AppSetting> GetAll()
      {
         var appSettings = ConfigurationManager.AppSettings;

         var allKeys = appSettings.AllKeys;

         var result = new List<AppSetting>(allKeys.Length);

         foreach (var key in allKeys)
         {
            var value = appSettings[key];

            result.Add(new AppSetting { Name = key, Value = value });
         }

         return result;
      }
   }
}