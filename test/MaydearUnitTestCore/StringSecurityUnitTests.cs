using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace MaydearUnitTestCore
{
    [TestClass]
    public class StringSecurityUnitTests
    {
        [TestMethod]
        public void AesEncryptToBase64()
        {
            var data = "1111";
            var key = "123aaa";
            data.AesEncryptToBase64(key.MD5ToHex());
        }
    }
}
