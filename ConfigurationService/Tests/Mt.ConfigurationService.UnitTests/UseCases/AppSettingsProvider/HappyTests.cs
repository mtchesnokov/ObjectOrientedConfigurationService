using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.UnitTests.TestExtensions;
using NUnit.Framework;

namespace Mt.ConfigurationService.UnitTests.UseCases.AppSettingsProvider
{
   public class HappyTests : TestBase
   {
      [Test]
      public void HappyCase()
      {
         //arrange
         var sut = Container.GetInstance<IAppSettingsProvider>();

         //act
         var appSettings = sut.GetAppSettings();

         //assert
         Assert.IsNotNull(appSettings);

         //print 
         appSettings.Print();
      }
   }
}