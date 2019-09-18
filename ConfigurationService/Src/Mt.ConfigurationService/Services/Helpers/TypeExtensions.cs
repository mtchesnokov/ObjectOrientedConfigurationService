using System;
using System.Reflection;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal static class TypeExtensions
   {
      public static PropertyInfo[] GetPublicProperties(this Type t)
      {
         return t.GetProperties(BindingFlags.Instance);
      }
   }
}