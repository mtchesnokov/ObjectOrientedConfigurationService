using NUnit.Framework;
using StructureMap;

namespace Mt.ConfigurationService.UnitTests
{
   [TestFixture]
   public abstract class TestBase
   {
      protected IContainer Container { get; private set; }

      [SetUp]
      public void SetUp()
      {
         Container = new Container(cfg => cfg.AddRegistry<MasterRegistry>());
      }

      [TearDown]
      public void TearDown()
      {
         Container?.Dispose();
         Container = null;
      }
   }

   [TestFixture]
   public abstract class TestBase<TSUT> : TestBase
   {
      public TSUT SUT => Container.GetInstance<TSUT>();
   }
}