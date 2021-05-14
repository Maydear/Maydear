using Maydear.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace MaydearUnitTestCore
{
    [TestClass]
    public class StringFilterExtensionUnitTest
    {
        [TestMethod]
        public void IsChinaMobilePhone()
        {
            var result = "19120635417".IsChinaMobilePhone();
            System.Console.WriteLine(result);
            Assert.IsTrue(result);
        }

    }
}
