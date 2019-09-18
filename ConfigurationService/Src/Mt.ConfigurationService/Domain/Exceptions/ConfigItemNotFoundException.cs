using System;

namespace Mt.ConfigurationService.Domain.Exceptions
{
   public class ConfigItemNotFoundException : Exception
   {
      public Type ConfigItemType { get; set; }

      public string ConfigItemName { get; set; }

      public ConfigItemNotFoundException() : base("Configuration item cannot be found")
      {
      }
   }
}