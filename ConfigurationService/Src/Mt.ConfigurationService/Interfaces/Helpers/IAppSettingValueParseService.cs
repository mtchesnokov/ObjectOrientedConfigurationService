using System;

namespace Mt.ConfigurationService.Interfaces.Helpers
{
   internal interface IAppSettingValueParseService
   {
      object Parse(string source, Type targetType);
   }
}