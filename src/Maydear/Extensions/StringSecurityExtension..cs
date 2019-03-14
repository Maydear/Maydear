/*****************************************************************************************
* Copyright 2014-2017 The Maydear Authors
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*     http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*****************************************************************************************/
using Maydear.Exceptions;
using System;
using System.Text;

/*****************************************************************************************
 * FileName:StringSecurityExtension.cs
 * Author:Kelvin
 * CreateDate:2014/09/22 15:02:45
 * Description:
 *        
 *        <version>	|	<author>	|<time>			        |	<desc>
 *        1		    |	Kelvin		|2014-09-22 15:20:00	|	创建文件
 ****************************************************************************************/

namespace System.Security.Cryptography
{
    /// <summary>
    /// 字符串安全扩展
    /// </summary>
    public static class StringSecurityExtension
    {
        /// <summary>
        /// 独有干扰MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns></returns>
        public static string HMACMD5(this string data, string key)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            HMACMD5 md5Provider = new HMACMD5(key.ToBytes());

            byte[] hashBuff = md5Provider.ComputeHash(data.ToUpper().ToBytes());

            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 独有干扰MD5加密并返回Base64格式
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns></returns>
        public static string HMACMD5ToBase64(this string data, string key)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            HMACMD5 md5Provider = new HMACMD5(key.ToBytes());

            byte[] hashBuff = md5Provider.ComputeHash(data.ToUpper().ToBytes());

            return hashBuff.ToBase64String();
        }

        /// <summary>
        /// 独有干扰MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns></returns>
        public static string HMACMD5(this string data, byte[] key)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            System.Security.Cryptography.HMACMD5 md5Provider = new System.Security.Cryptography.HMACMD5(key);

            byte[] hashBuff = md5Provider.ComputeHash(data.ToUpper().ToBytes());

            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 独有干扰MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns></returns>
        public static string HMACMD5ToBase64(this string data, byte[] key)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            System.Security.Cryptography.HMACMD5 md5Provider = new System.Security.Cryptography.HMACMD5(key);

            byte[] hashBuff = md5Provider.ComputeHash(data.ToUpper().ToBytes());

            return hashBuff.ToBase64String();
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回MD5加密后的密文</returns>
        public static string MD5(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            MD5 md5Provider = new MD5CryptoServiceProvider();
            byte[] buff = md5Provider.ComputeHash(UnicodeEncoding.UTF8.GetBytes(data));
            StringBuilder sb = new StringBuilder();
            foreach (byte item in buff)
            {
                sb.Append(string.Format("{0:x2}", item));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 独有干扰HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns></returns>
        public static string HMACSHA256(this string data, string key)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            System.Security.Cryptography.HMACSHA256 sha256Provider = new System.Security.Cryptography.HMACSHA256(key.ToUpper().ToBytes());

            byte[] hashBuff = sha256Provider.ComputeHash(data.ToUpper().ToBytes());

            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 独有干扰HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns></returns>
        public static string HMACSHA256(this string data, byte[] key)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            System.Security.Cryptography.HMACSHA256 sha256Provider = new System.Security.Cryptography.HMACSHA256(key);

            byte[] hashBuff = sha256Provider.ComputeHash(data.ToUpper().ToBytes());

            return hashBuff.ToHexString();
        }

        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA256加密后的Base64编码密文</returns>
        public static string SHA256(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SHA256Managed sHA256Managed = new SHA256Managed();
            byte[] inArray = sHA256Managed.ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }

        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA256加密后的Hex格式密文</returns>
        public static string SHA256Hex(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SHA256Managed sHA256Managed = new SHA256Managed();
            byte[] inArray = sHA256Managed.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in inArray)
            {
                sb.Append(string.Format("{0:x2}", item));
            }
            return sb.ToString();
        }
        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA1加密后的密文</returns>
        public static string SHA1(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SHA1 sha1Provider = System.Security.Cryptography.SHA1.Create();
            byte[] inArray = sha1Provider.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in inArray)
            {
                sb.Append(string.Format("{0:x2}", item));
            }
            return sb.ToString();
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个Base64编码的密文</returns>
        public static string AesEncrypt(this string data, string password)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(password))
            {
                return data;
            }

            byte[] keyBytes = password.ToBytes();
            byte[] toEncryptArray = data.ToBytes();
            Aes aesProvider = Aes.Create();

            if (keyBytes.Length < aesProvider.KeySize)
            {
                throw new KeySizeException();
            }

            aesProvider.Key = keyBytes;
            aesProvider.Mode = CipherMode.ECB;
            aesProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = aesProvider.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return resultArray.ToBase64String();
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecrypt(this string data, string password)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(password))
            {
                return data;
            }

            byte[] keyBytes = password.ToBytes();
            byte[] toEncryptArray = Convert.FromBase64String(data);
            Aes aesProvider = Aes.Create();

            if (keyBytes.Length < aesProvider.KeySize)
            {
                throw new KeySizeException();
            }

            aesProvider.Key = keyBytes;
            aesProvider.Mode = CipherMode.ECB;
            aesProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = aesProvider.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES加密【Cipher：ECB，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个Base64编码的密文</returns>
        public static string AesEncrypt(this string data, byte[] password)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            byte[] toEncryptArray = data.ToBytes();
            Aes aesProvider = Aes.Create();

            if (password.Length < aesProvider.KeySize)
            {
                throw new KeySizeException();
            }
            aesProvider.Key = password;
            aesProvider.Mode = CipherMode.ECB;
            aesProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = aesProvider.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return resultArray.ToBase64String();
        }

        /// <summary>
        /// AES解密【Cipher：ECB，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">密钥字节</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecrypt(this string data, byte[] password)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            byte[] toEncryptArray = Convert.FromBase64String(data);
            Aes aesProvider = Aes.Create();


            if (password.Length < aesProvider.KeySize)
            {
                throw new KeySizeException();
            }
            aesProvider.Key = password;
            aesProvider.Mode = CipherMode.ECB;
            aesProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = aesProvider.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptHex(this string data, string password)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(password))
            {
                return data;
            }

            byte[] toEncryptArray = new byte[data.Length / 2];

            for (int i = 0; i < data.Length; i += 2)
            {
                toEncryptArray[i / 2] = Convert.ToByte(data.Substring(i, 2), 16);
            }
            byte[] keyBytes = password.ToBytes();

            Aes aesProvider = Aes.Create();

            if (keyBytes.Length < aesProvider.KeySize)
            {
                throw new KeySizeException();
            }
            aesProvider.Key = keyBytes;
            aesProvider.Mode = CipherMode.ECB;
            aesProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = aesProvider.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个Base64编码的密文</returns>
        public static string AesEncryptHex(this string data, string password)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(password))
            {
                return data;
            }

            byte[] keyBytes = password.ToBytes();
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(data);
            Aes aesProvider = Aes.Create();
            if (keyBytes.Length < aesProvider.KeySize)
            {
                throw new KeySizeException();
            }
            aesProvider.Key = keyBytes;
            aesProvider.Mode = CipherMode.ECB;
            aesProvider.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = aesProvider.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in resultArray)
            {
                sb.Append(string.Format("{0:x2}", item));
            }
            return sb.ToString();
        }


    }
}
