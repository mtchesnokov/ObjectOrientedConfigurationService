using System.Collections.Generic;
using Mt.ConfigurationService.Domain.Helpers;

namespace Mt.ConfigurationService.Interfaces.Helpers
{
   internal interface IConfigItemsProvider<TConfigItem>
      where TConfigItem : ConfigItemBase
   {
      IEnumerable<TConfigItem> GetAll();
   }
}