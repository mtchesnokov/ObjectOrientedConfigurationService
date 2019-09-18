using System;
using System.Linq;
using Mt.ConfigurationService.Domain.Exceptions;
using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class ConfigItemProvider<TConfigItem> : IConfigItemProvider<TConfigItem> where TConfigItem : ConfigItemBase
   {
      private readonly IConfigItemsProvider<TConfigItem> _configItemsProvider;

      #region ctor

      public ConfigItemProvider(IConfigItemsProvider<TConfigItem> configItemsProvider)
      {
         _configItemsProvider = configItemsProvider;
      }

      #endregion

      public string Get(string name)
      {
         var allItems = _configItemsProvider.GetAll();

         var selectedItem = allItems.FirstOrDefault(i => string.Equals(i.Name, name, StringComparison.InvariantCultureIgnoreCase));

         if (selectedItem == null)
         {
            throw new ConfigItemNotFoundException
            {
               ConfigItemName = name,
               ConfigItemType = typeof(TConfigItem)
            };
         }

         return selectedItem.Name;
      }
   }
}