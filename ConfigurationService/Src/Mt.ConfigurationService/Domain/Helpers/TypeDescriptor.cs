using System;
using System.Collections.Generic;
using System.Reflection;

namespace Mt.ConfigurationService.Domain.Helpers
{
   internal class TypeDescriptor
   {
      public List<Tuple<string, PropertyInfo>> AppSettings { get; set; }

      public List<Tuple<string, PropertyInfo>> ConnectionStrings { get; set; }
   }
}