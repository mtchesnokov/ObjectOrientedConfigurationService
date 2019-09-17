using Mt.ConfigurationService.Domain.Helpers;
using Mt.ConfigurationService.Interfaces.Helpers;
using Mt.ConfigurationService.UnitTests.TestExtensions;
using NUnit.Framework;

namespace Mt.ConfigurationService.UnitTests.UseCases.ConnectionStringProvider
{
   public class HappyTests : TestBase
   {
      [Test]
      public void HappyCase()
      {
         //arrange
         var sut = Container.GetInstance<IConfigItemsProvider<ConnectionString>>();

         //act
         var appSettings = sut.Get();

         //assert
         Assert.IsNotNull(appSettings);

         //print 
         appSettings.Print();
      }
   }
}