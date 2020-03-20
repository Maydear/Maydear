using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MaydearUnitTestCore
{
    [TestClass]
    public class StringSecurityUnitTests
    {
        #region MD5
        [TestMethod]
        public void MD5ToHex()
        {
            string data = "123456";
            string encryptTextAct = "e10adc3949ba59abbe56e057f20f883e";
            string encryptText = data.MD5ToHex();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void MD5ToBase64()
        {
            string data = "123456";
            string encryptTextAct = "4QrcOUm6Wau+VuBX8g+IPg==";
            string encryptText = data.MD5ToBase64();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACMD5ToHex()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "a5138829a808236d51f45983e43b4780";
            string encryptText = data.HMACMD5ToHex(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACMD5ToBase64()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "pROIKagII21R9FmD5DtHgA==";
            string encryptText = data.HMACMD5ToBase64(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        #endregion

        #region SHA1
        [TestMethod]
        public void SHA1ToHex()
        {
            string data = "123456";
            string encryptTextAct = "7c4a8d09ca3762af61e59520943dc26494f8941b";
            string encryptText = data.SHA1ToHex();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void SHA1ToBase64()
        {
            string data = "123456";
            string encryptTextAct = "fEqNCco3Yq9h5ZUglD3CZJT4lBs=";
            string encryptText = data.SHA1ToBase64();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACSHA1ToHex()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "a118fff823ed0d443d2da61618cc0095a709a3ea";
            string encryptText = data.HMACSHA1ToHex(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACSHA1ToBase64()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "oRj/+CPtDUQ9LaYWGMwAlacJo+o=";
            string encryptText = data.HMACSHA1ToBase64(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }
        #endregion

        #region SHA256
        [TestMethod]
        public void SHA256ToHex()
        {
            string data = "123456";
            string encryptTextAct = "7c4a8d09ca3762af61e59520943dc26494f8941b";
            string encryptText = data.SHA256ToHex();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void SHA256ToBase64()
        {
            string data = "123456";
            string encryptTextAct = "fEqNCco3Yq9h5ZUglD3CZJT4lBs=";
            string encryptText = data.SHA256ToBase64();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACSHA256ToHex()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "a118fff823ed0d443d2da61618cc0095a709a3ea";
            string encryptText = data.HMACSHA256ToHex(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACSHA256ToBase64()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "oRj/+CPtDUQ9LaYWGMwAlacJo+o=";
            string encryptText = data.HMACSHA256ToBase64(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }
        #endregion

        #region SHA512
        [TestMethod]
        public void SHA512ToHex()
        {
            string data = "123456";
            string encryptTextAct = "7c4a8d09ca3762af61e59520943dc26494f8941b";
            string encryptText = data.SHA512ToHex();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void SHA512ToBase64()
        {
            string data = "123456";
            string encryptTextAct = "fEqNCco3Yq9h5ZUglD3CZJT4lBs=";
            string encryptText = data.SHA512ToBase64();
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACSHA512ToHex()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "a118fff823ed0d443d2da61618cc0095a709a3ea";
            string encryptText = data.HMACSHA512ToHex(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }

        [TestMethod]
        public void HMACSHA512ToBase64()
        {
            string data = "123456";
            string key = "1234567890123456";
            string encryptTextAct = "oRj/+CPtDUQ9LaYWGMwAlacJo+o=";
            string encryptText = data.HMACSHA512ToBase64(key);
            Console.WriteLine(encryptText);
            Assert.AreEqual(encryptText, encryptTextAct);
        }
        #endregion

        #region AES
        [TestMethod]
        public void AesEncryptToBase64()
        {
            string data = "{\"visitorId\":1,\"visitorUid\":\"5a793d61-c93f-48b9-84fe-ac2f3c86d3f1\",\"name\":\"测试访客\" }";
            string key = "bc77ea2a00198995000000065df8e867";
            string encryptText = data.AesEncryptToBase64(key,CipherMode.CBC, PaddingMode.PKCS7);
            Console.WriteLine(encryptText);
        }

        [TestMethod]
        public void AesEncryptToHex()
        {
            string data = "realperson/510b0aeb86dc445297d0acb60e8bbb11.png";
            string key = "a8e841976f6a4fae9bb503cd5f6fb3e8";
            string encryptText = data.AesEncryptToHex(key);
            Console.WriteLine(encryptText);
        }

        [TestMethod]
        public void AesDecryptFormBase64()
        {
            string data = "ZgngBpaIc9dIcwaO+kewI0WfS31VQz9T7N+ZG05cYPuTUZEg1TxW6qaG8cTj8NswnxdZyui99FYFC/vfn2hp/9sMFzH+21IJwLhgGSVS2VW8mFYVlQjv74dlJC+7yQ4E";
            string key = "bc77ea2a00198995000000065df8e867";
            string encryptText = data.AesDecryptFormBase64(key, CipherMode.CBC, PaddingMode.PKCS7);
            Console.WriteLine(encryptText);
        }

        [TestMethod]
        public void AesEncryptToBase642()
        {
            string data = "realperson/510b0aeb86dc445297d0acb60e8bbb11.png";
            string key = "a8e841976f6a4fae9bb503cd5f6fb3e8";
            string encryptText = data.AesEncryptToBase64(key);
            Console.WriteLine(encryptText);
        }

        [TestMethod]
        public void AesDecryptToHex()
        {
            string data = "27f400b3774930b3f36e10568da241b2b8f3434eb081bee8e52235ea059835202844f0e26205eaadf809a6ca884a3e9b";
            string key = "a8e841976f6a4fae9bb503cd5f6fb3e8";
            data.AesDecryptFormHex(key);
        }

        #endregion
    }
}
