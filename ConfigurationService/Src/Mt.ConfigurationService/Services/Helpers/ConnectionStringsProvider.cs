using System.Collections.Generic;
using System.Configuration;
using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class ConnectionStringsProvider : IConfigItemsProvider<ConnectionString>
   {
      public IEnumerable<ConnectionString> Get()
      {
         var connectionStrings = ConfigurationManager.ConnectionStrings;

         var result = new List<ConnectionString>(connectionStrings.Count);

         for (var i = 0; i < connectionStrings.Count; i++)
         {
            var connectionStringSettings = connectionStrings[i];

            var key = connectionStringSettings.Name;

            var value = connectionStringSettings.ConnectionString;

            result.Add(new ConnectionString {Name = key, Value = value});
         }

         return result;
      }
   }
}