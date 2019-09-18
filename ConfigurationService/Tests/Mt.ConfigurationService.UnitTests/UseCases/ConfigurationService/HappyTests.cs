using Mt.ConfigurationService.Interfaces;
using Mt.ConfigurationService.UnitTests.Fakes;
using Mt.ConfigurationService.UnitTests.TestExtensions;
using NUnit.Framework;

namespace Mt.ConfigurationService.UnitTests.UseCases.ConfigurationService
{
   public class HappyTests : TestBase<IConfigurationService<FakeSettings>>
   {
      [Test]
      public void HappyCase()
      {
         //act
         var fakeSettings = SUT.Get();

         //assert
         Assert.IsNotNull(fakeSettings);

         //print 
         fakeSettings.Print();
      }
   }
}