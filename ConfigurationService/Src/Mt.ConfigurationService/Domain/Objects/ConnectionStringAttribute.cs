using System;

namespace Mt.ConfigurationService.Domain.Objects
{
   [AttributeUsage(AttributeTargets.Property)]
   public class ConnectionStringAttribute : Attribute
   {
   }
}