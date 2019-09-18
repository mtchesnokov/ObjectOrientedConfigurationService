using System;
using Mt.ConfigurationService.Interfaces.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class AppSettingValueParseService : IAppSettingValueParseService
   {
      public object Parse(string source, Type targetType)
      {
         return Convert.ChangeType(source, targetType);
      }
   }
}