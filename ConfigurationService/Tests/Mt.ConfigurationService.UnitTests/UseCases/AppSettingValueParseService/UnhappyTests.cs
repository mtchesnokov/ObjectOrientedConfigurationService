using Mt.ConfigurationService.Domain.Exceptions;
using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.UnitTests.TestExtensions;
using NUnit.Framework;

namespace Mt.ConfigurationService.UnitTests.UseCases.AppSettingValueParseService
{
   public class UnhappyTests : TestBase
   {
      [Test]
      public void App_Setting_Not_Found()
      {
         //arrange
         var sut = Container.GetInstance<IConfigItemProvider<AppSetting>>();

         //act+assert
         MyAssert.ThrowsException<ConfigItemNotFoundException>(() => sut.Get("dummy"));
      }
   }
}