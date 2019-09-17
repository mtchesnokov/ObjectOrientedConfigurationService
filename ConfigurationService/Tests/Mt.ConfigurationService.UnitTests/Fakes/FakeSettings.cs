using Mt.ConfigurationService.Domain.Objects;

namespace Mt.ConfigurationService.UnitTests.Fakes
{
   public class FakeSettings
   {
      [AppSetting]
      public string AppSetting1 { get; set; }

      [ConnectionString]
      public string ConnectionString1 { get; set; }
   }
}