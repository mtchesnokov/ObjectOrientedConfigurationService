using Mt.ConfigurationService.Domain.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class AppSettingProvider : ConfigItemProviderBase<AppSetting>
   {
      public AppSettingProvider() : base(new AppSettingsProvider())
      {
      }
   }
}