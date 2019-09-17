using System;
using System.Collections.Generic;
using System.Reflection;
using Mt.ConfigurationService.Interfaces;
using Mt.ConfigurationService.Services.Helpers;

namespace Mt.ConfigurationService.Services
{
   public class ConfigurationService<T> : IConfigurationService<T> 
      where T : new()
   {
      public T Get()
      {
         var type = typeof(T);
         var typeDescriptor = type.GetTypeDescriptor();

         var connectionStrings = typeDescriptor.ConnectionStrings;

         var result = new T();

         AddConnectionStrings(result, connectionStrings);

         return result;
      }

      private static void AddConnectionStrings(T result, List<Tuple<string, PropertyInfo>> connectionStrings)
      {
         throw new NotImplementedException();
      }
   }
}