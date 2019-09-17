namespace Mt.ConfigurationService.Interfaces
{
   public interface IConfigurationService<T>
   where T : new()
   {
      T Get();
   }
}