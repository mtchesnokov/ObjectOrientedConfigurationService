using Mt.ConfigurationService.Interfaces;

namespace Mt.ConfigurationService.Services
{
   public abstract class ConfigurationServiceBase<T> : IConfigurationService<T>
   {
      public T Get()
      {
         throw new System.NotImplementedException();
      }
   }
}