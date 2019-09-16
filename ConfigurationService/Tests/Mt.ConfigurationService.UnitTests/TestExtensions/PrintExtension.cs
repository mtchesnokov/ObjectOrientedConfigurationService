using System;
using Newtonsoft.Json;

namespace Mt.ConfigurationService.UnitTests.TestExtensions
{
   public static class PrintExtension
   {
      public static void Print(this object source)
      {
         var settings = new JsonSerializerSettings {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};
         Console.WriteLine(JsonConvert.SerializeObject(source, Formatting.Indented, settings));
      }
   }
}