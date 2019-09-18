using Mt.ConfigurationService.Domain.Helpers;
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
         var sut = Container.GetInstance<IConfigItemsProvider<AppSetting>>();

         //act
         var appSettings = sut.GetAll();

         //assert
         Assert.IsNotNull(appSettings);

         //print 
         appSettings.Print();
      }
   }
}