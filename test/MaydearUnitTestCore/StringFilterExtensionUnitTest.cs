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

        [TestMethod]
        public void IsDomainName()
        {
            var result = "qq.com".IsDomainName();
            System.Console.WriteLine(result);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsDomainNameFail()
        {
            var result = "111111".IsDomainName();
            System.Console.WriteLine(result);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsIPv4()
        {
            var result = "192.168.1.2".IsIPv4();
            System.Console.WriteLine(result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsIPv4Fail1()
        {
            var result = "192.168.1.2292".IsIPv4();
            System.Console.WriteLine(result);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsIPv4Fail2()
        {
            var result = "192.168.1".IsIPv4();
            System.Console.WriteLine(result);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsIPv4Fail3()
        {
            var result = "19A.168.1".IsIPv4();
            System.Console.WriteLine(result);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsIPv4Fail4()
        {
            var result = "192.168.1.A".IsIPv4();
            System.Console.WriteLine(result);
            Assert.IsFalse(result);
        }
    }
}
