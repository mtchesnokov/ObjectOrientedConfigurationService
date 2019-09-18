using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.UnitTests.TestExtensions;
using NUnit.Framework;

namespace Mt.ConfigurationService.UnitTests.UseCases.AppSettingProvider
{
   public class HappyTests : TestBase
   {
      [Test]
      public void HappyCase()
      {
         //arrange
         var sut = Container.GetInstance<IConfigItemProvider<AppSetting>>();

         //act
         var appSetting = sut.Get("appSetting1");

         //assert
         Assert.IsNotNull(appSetting);

         //print 
         appSetting.Print();
      }
   }
}