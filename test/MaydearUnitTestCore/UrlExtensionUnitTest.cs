using Maydear;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaydearUnitTest
{
    [TestClass]
    public class UrlExtensionUnitTest
    {
        /// <summary>
        /// 正例
        /// </summary>
        [TestMethod]
        public void ExtractHostCorrectTestMethod()
        {
            var page = new Page()
            {
                PageIndex = 2,
                PageSize = 100
            };

            Assert.AreEqual(page.Offset, 100);
        }

        [TestMethod]
        public void ExtractHostFailingTestMethod()
        {
            var page = new Page()
            {
                PageIndex = 1,
                PageSize = 100
            };

            Assert.AreEqual(page.Offset, 0);
        }
    }
}
