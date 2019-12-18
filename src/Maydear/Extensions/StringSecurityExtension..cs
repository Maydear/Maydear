/*****************************************************************************************
* Copyright 2014-2019 The Maydear Authors
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
using System.Collections.Generic;
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
        #region HmacMD5

        /// <summary>
        /// 独有干扰MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACMD5加密后的二进制数组</returns>
        public static byte[] HMACMD5(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return null;
            }

            HMACMD5 md5Provider = new HMACMD5(key);

            return md5Provider.ComputeHash(data.ToBytes());
        }

        /// <summary>
        /// 独有干扰MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACMD5加密后的十六进制编码字符串</returns>
        public static string HMACMD5ToHex(this string data, string key)
        {
            byte[] hashBuff = data.HMACMD5(key.ToBytes());
            if (hashBuff == null)
            {
                return data;
            }
            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 独有干扰MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACMD5加密后的十六进制编码字符串</returns>
        public static string HMACMD5ToHex(this string data, byte[] key)
        {
            byte[] hashBuff = data.HMACMD5(key);
            if (hashBuff == null)
            {
                return data;
            }
            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 独有干扰MD5加密并返回Base64格式
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACMD5加密后的Base64编码字符串</returns>
        public static string HMACMD5ToBase64(this string data, string key)
        {
            byte[] hashBuff = data.HMACMD5(key.ToBytes());
            if (hashBuff == null)
            {
                return data;
            }
            return hashBuff.ToBase64String();
        }

        /// <summary>
        /// 独有干扰MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACMD5加密后的Base64编码字符串</returns>
        public static string HMACMD5ToBase64(this string data, byte[] key)
        {
            byte[] hashBuff = data.HMACMD5(key);
            if (hashBuff == null)
            {
                return data;
            }
            return hashBuff.ToBase64String();
        }

        #endregion

        #region MD5

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回MD5加密后二进制数组</returns>
        public static byte[] MD5(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            MD5 md5Provider = new MD5CryptoServiceProvider();
            return md5Provider.ComputeHash(data.ToBytes());
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回MD5加密后的十六进制编码字符串</returns>
        public static string MD5ToHex(this string data)
        {
            byte[] buff = data.MD5();
            if (buff == null)
            {
                return data;
            }

            return buff.ToHexString();
        }

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回MD5加密后的Base64编码字符串</returns>
        public static string MD5ToBase64(this string data)
        {
            byte[] buff = data.MD5();
            if (buff == null)
            {
                return data;
            }

            return buff.ToBase64String();
        }

        #endregion

        #region HmacSha256

        /// <summary>
        /// 独有干扰HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA256加密后的二进制数组</returns>
        public static byte[] HMACSHA256(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return null;
            }

            System.Security.Cryptography.HMACSHA256 sha256Provider = new System.Security.Cryptography.HMACSHA256(key);

            return sha256Provider.ComputeHash(data.ToBytes());
        }

        /// <summary>
        /// 独有干扰HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA256加密后的十六进制编码字符串</returns>
        public static string HMACSHA256ToHex(this string data, string key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }

            byte[] hashBuff = data.HMACSHA256(key.ToBytes());

            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 独有干扰HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA256加密后的十六进制编码字符串</returns>
        public static string HMACSHA256ToHex(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }
            byte[] hashBuff = data.HMACSHA256(key);
            return hashBuff.ToHexString();
        }


        /// <summary>
        /// 独有干扰HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA256加密后的Base64编码字符串</returns>
        public static string HMACSHA256ToBase64(this string data, string key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }

            byte[] hashBuff = data.HMACSHA256(key.ToBytes());
            return hashBuff.ToBase64String();
        }

        /// <summary>
        /// 独有干扰HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA256加密后的十六进制编码字符串</returns>
        public static string HMACSHA256ToBase64(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }
            byte[] hashBuff = data.HMACSHA256(key);
            return hashBuff.ToBase64String();
        }

        #endregion

        #region SHA256

        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA256加密后的Base64编码密文</returns>
        public static byte[] SHA256(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }
            SHA256Managed sHA256Managed = new SHA256Managed();
            return sHA256Managed.ComputeHash(data.ToBytes());
        }


        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA256加密后的Base64编码密文</returns>
        public static string SHA256ToBase64(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }
            byte[] inArray = data.SHA256();
            return inArray.ToBase64String();
        }

        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA256加密后的十六进制格式密文</returns>
        public static string SHA256ToHex(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }
            byte[] inArray = data.SHA256();
            return inArray.ToHexString();
        }

        #endregion

        #region SHA1

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA1加密后的密文</returns>
        public static byte[] SHA1(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            byte[] bytes = Encoding.UTF8.GetBytes(data);
            SHA1 sha1Provider = System.Security.Cryptography.SHA1.Create();
            return sha1Provider.ComputeHash(bytes);
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA1加密后的密文</returns>
        public static string SHA1ToBase64(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }
            byte[] inArray = data.SHA1();
            return inArray.ToBase64String();
        }

        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA1加密后的密文</returns>
        public static string SHA1ToHex(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }
            byte[] inArray = data.SHA1();
            return inArray.ToHexString();
        }

        #endregion

        #region AesEncrypt
        /// <summary>
        /// AES加密【Cipher：CBC，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回AES加密后的Base64编码的密文</returns>
        public static string AesEncryptToBase64(this string data, string password)
        {
            return AesEncryptToBase64(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回AES加密后的Base64编码的密文</returns>
        public static string AesEncryptToBase64(this string data, string password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] keyBytes = password.ToBytes();
            return AesEncryptToBase64(data, keyBytes, mode, padding);
        }

        /// <summary>
        /// AES加密【Cipher：CBC，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回AES加密后的Base64编码的密文</returns>
        public static string AesEncryptToBase64(this string data, byte[] password)
        {
            return AesEncryptToBase64(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">填充模式</param>
        /// <returns>返回一个Base64编码的密文</returns>
        public static string AesEncryptToBase64(this string data, byte[] password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] toEncryptArray = data.ToBytes();
            Aes aesProvider = Aes.Create();
            int length = aesProvider.Key.Length;
            if (password.Length < length)
            {
                throw new KeySizeException(length);
            }
            aesProvider.Key = password;
            aesProvider.Mode = mode;
            aesProvider.Padding = padding;
            ICryptoTransform cTransform = aesProvider.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return resultArray.ToBase64String();
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个16进制字符编码的密文</returns>
        public static string AesEncryptToHex(this string data, string password)
        {
            return AesEncryptToHex(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个16进制字符编码的密文</returns>
        public static string AesEncryptToHex(this string data, string password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] keyBytes = password.ToBytes();
            return AesEncryptToHex(data, keyBytes, mode, padding);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个16进制字符编码的密文</returns>
        public static string AesEncryptToHex(this string data, byte[] password)
        {
            return AesEncryptToHex(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个16进制字符编码的密文</returns>
        public static string AesEncryptToHex(this string data, byte[] password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] toEncryptArray = Encoding.UTF8.GetBytes(data);
            Aes aesProvider = Aes.Create();
            int length = aesProvider.Key.Length;
            if (password.Length < length)
            {
                throw new KeySizeException(length);
            }
            aesProvider.Key = password;
            aesProvider.Mode = mode;
            aesProvider.Padding = padding;
            ICryptoTransform cTransform = aesProvider.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return resultArray.ToHexString();
        }

        #endregion

        #region AesDecrypt

        /// <summary>
        /// AES解密【Cipher：CBC，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormBase64(this string data, string password)
        {
            return AesDecryptFormBase64(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormBase64(this string data, string password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] keyBytes = password.ToBytes();
            return AesDecryptFormBase64(data, keyBytes, mode, padding);
        }

        /// <summary>
        /// AES解密【CipherMode：CBC，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">密钥字节</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormBase64(this string data, byte[] password)
        {
            return AesDecryptFormBase64(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">填充模式</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormBase64(this string data, byte[] password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] toEncryptArray = Convert.FromBase64String(data);
            Aes aesProvider = Aes.Create();

            int length = aesProvider.Key.Length;
            if (password.Length < length)
            {
                throw new KeySizeException(length);
            }
            aesProvider.Key = password;
            aesProvider.Mode = mode;
            aesProvider.Padding = padding;
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
        public static string AesDecryptFormHex(this string data, string password)
        {
            return AesDecryptFormHex(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormHex(this string data, byte[] password)
        {
            return AesDecryptFormHex(data, password, CipherMode.CBC, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormHex(this string data, string password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] keyBytes = password.ToBytes();
            return AesDecryptFormHex(data, keyBytes, mode, padding);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">填充模式</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormHex(this string data, byte[] password, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] toEncryptArray = new byte[data.Length / 2];

            for (int i = 0; i < data.Length; i += 2)
            {
                toEncryptArray[i / 2] = Convert.ToByte(data.Substring(i, 2), 16);
            }

            Aes aesProvider = Aes.Create();

            int length = aesProvider.Key.Length;
            if (password.Length < length)
            {
                throw new KeySizeException(length);
            }
            aesProvider.Key = password;
            aesProvider.Mode = mode;
            aesProvider.Padding = padding;
            ICryptoTransform cTransform = aesProvider.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        #endregion
    }
}
