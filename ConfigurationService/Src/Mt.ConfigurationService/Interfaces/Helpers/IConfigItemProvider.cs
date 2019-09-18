using Mt.ConfigurationService.Domain.Helpers;

namespace Mt.ConfigurationService.Interfaces.Helpers
{
   internal interface IConfigItemProvider<TConfigItem>
      where TConfigItem : ConfigItemBase
   {
      string Get(string name);
   }
}