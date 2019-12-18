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
        [TestMethod]
        public void AesEncryptToBase64()
        {
            string data = "{\"visitorId\":1,\"visitorUid\":\"5a793d61-c93f-48b9-84fe-ac2f3c86d3f1\",\"name\":\"测试访客\" }";
            string key = "bc77ea2a00198995000000065df8e867";
            string encryptText = data.AesEncryptToBase64(key,CipherMode.ECB,PaddingMode.PKCS7);
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
        public void AesEncryptToHex()
        {
            string data = "1111";
            string key = "bc77ea2a00198995000000065df8e867";
            data.AesEncryptToHex(key);
        }
    }
}
