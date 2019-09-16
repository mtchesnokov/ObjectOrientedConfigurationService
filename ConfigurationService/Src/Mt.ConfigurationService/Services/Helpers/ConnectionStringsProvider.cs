using System.Collections.Generic;
using System.Configuration;
using Mt.ConfigurationService.Interfaces.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class ConnectionStringsProvider : IConnectionStringsProvider
   {
      public IDictionary<string, string> GetConnectionStrings()
      {
         var connectionStrings = ConfigurationManager.ConnectionStrings;

         var result = new Dictionary<string, string>(connectionStrings.Count);

         for (var i = 0; i < connectionStrings.Count; i++)
         {
            var connectionStringSettings = connectionStrings[i];

            var key = connectionStringSettings.Name;

            var value = connectionStringSettings.ConnectionString;

            result.Add(key, value);
         }

         return result;
      }
   }
}