using System;
using NUnit.Framework;

namespace Mt.ConfigurationService.UnitTests.TestExtensions
{
   public class MyAssert : Assert
   {
      public static void ThrowsException<TException>(TestDelegate testDelegate)
         where TException : Exception
      {
         try
         {
            testDelegate();
            Fail("No exception thrown");
         }
         catch (TException e)
         {
            e.Print();
            Pass();
         }
         catch (Exception e)
         {
            Fail($"Wrong exception type thrown... Expected '{typeof(TException).Name}' Actual: '{e.GetType().Name}'");
         }
      }
   }
}