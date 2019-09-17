using System;
using System.Collections.Generic;
using System.Reflection;
using Mt.ConfigurationService.Domain.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal static class TypeExtensions
   {
      public static TypeDescriptor GetTypeDescriptor(this Type t)
      {
         var propertyInfos = t.GetProperties(BindingFlags.Instance);
         var appSettings = new List<Tuple<string, PropertyInfo>>(propertyInfos.Length);
         var connectionStrings = new List<Tuple<string, PropertyInfo>>(propertyInfos.Length);

         foreach (var propertyInfo in propertyInfos)
         {
            var appSettingName = propertyInfo.TryGetAppSettingName();

            if (!string.IsNullOrEmpty(appSettingName))
            {
               appSettings.Add(new Tuple<string, PropertyInfo>(appSettingName, propertyInfo));
               continue;
            }

            var connectionStringName = propertyInfo.TryGetConnectionStringName();

            if (!string.IsNullOrEmpty(connectionStringName))
            {
               connectionStrings.Add(new Tuple<string, PropertyInfo>(connectionStringName, propertyInfo));
            }
         }

         return new TypeDescriptor {AppSettings = appSettings, ConnectionStrings = connectionStrings};
      }
   }
}