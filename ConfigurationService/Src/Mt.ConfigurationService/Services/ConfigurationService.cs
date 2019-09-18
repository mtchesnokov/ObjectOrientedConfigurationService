using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces;
using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.Services.Helpers;

namespace Mt.ConfigurationService.Services
{
   public class ConfigurationService<T> : IConfigurationService<T>
      where T : new()
   {
      private readonly IConfigItemProvider<ConnectionString> _connectionStringProvider;
      private readonly IConfigItemProvider<AppSetting> _appSettingProvider;
      private readonly IAppSettingValueParseService _appSettingValueParseService;

      #region ctor

      public ConfigurationService() : this(new ConnectionStringProvider(), new AppSettingProvider(), new AppSettingValueParseService())
      {
         
      }

      internal ConfigurationService(IConfigItemProvider<ConnectionString> connectionStringProvider, IConfigItemProvider<AppSetting> appSettingProvider, IAppSettingValueParseService appSettingValueParseService)
      {
         _connectionStringProvider = connectionStringProvider;
         _appSettingProvider = appSettingProvider;
         _appSettingValueParseService = appSettingValueParseService;
      }

      #endregion

      public T Get()
      {
         var result = new T();

         var resultType = result.GetType();

         var publicProperties = resultType.GetPublicProperties();

         foreach (var propertyInfo in publicProperties)
         {
            var connectionStringName = propertyInfo.TryGetConnectionStringName();

            if (!string.IsNullOrEmpty(connectionStringName))
            {
               var connectionString = _connectionStringProvider.Get(connectionStringName);
               propertyInfo.SetValue(result, connectionString);
               continue;
            }

            var appSettingName = propertyInfo.TryGetAppSettingName();

            if (!string.IsNullOrEmpty(appSettingName))
            {
               var appSettingStringValue = _appSettingProvider.Get(appSettingName);
               var propertyValue = _appSettingValueParseService.Parse(appSettingStringValue, propertyInfo.PropertyType);
               propertyInfo.SetValue(result, propertyValue);
            }
         }

         return result;
      }
   }
}