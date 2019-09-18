using Mt.ConfigurationService.Domain.Helpers;

namespace Mt.ConfigurationService.Services.Helpers
{
   internal class ConnectionStringProvider : ConfigItemProviderBase<ConnectionString>
   {
      public ConnectionStringProvider() : base(new ConnectionStringsProvider())
      {
      }
   }
}