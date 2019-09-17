using System.Linq;
using System.Reflection;
using Mt.ConfigurationService.Domain.Objects;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal static class PropertyInfoExtensions
   {
      public static string TryGetAppSettingName(this PropertyInfo propertyInfo)
      {
         var appSettingAttribute = propertyInfo.GetCustomAttributes<AppSettingAttribute>().FirstOrDefault();

         if (appSettingAttribute == null)
         {
            return string.Empty;
         }

         return propertyInfo.Name;
      }

      public static string TryGetConnectionStringName(this PropertyInfo propertyInfo)
      {
         var connectionStringAttribute = propertyInfo.GetCustomAttributes<ConnectionStringAttribute>().FirstOrDefault();

         if (connectionStringAttribute == null)
         {
            return string.Empty;
         }

         return propertyInfo.Name;
      }
   }
}