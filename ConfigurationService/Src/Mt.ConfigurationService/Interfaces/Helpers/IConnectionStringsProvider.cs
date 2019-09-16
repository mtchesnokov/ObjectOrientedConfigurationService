using System.Collections.Generic;

namespace Mt.ConfigurationService.Interfaces.Helpers
{
   internal interface IConnectionStringsProvider
   {
      IDictionary<string, string> GetConnectionStrings();
   }
}