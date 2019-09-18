using System;
using Mt.ConfigurationService.Interfaces.Helpers;
using NUnit.Framework;

namespace Mt.ConfigurationService.UnitTests.UseCases.AppSettingValueParseService
{
   public class HappyTests : TestBase
   {
      [Test]
      public void Target_Type_String()
      {
         //arrange
         var sut = Container.GetInstance<IAppSettingValueParseService>();

         //act
         var appSetting = sut.Parse("appSetting1", typeof(string));

         //assert
         Assert.IsNotNull(appSetting);

         //print 
         Console.WriteLine(appSetting);
      }
   }
}