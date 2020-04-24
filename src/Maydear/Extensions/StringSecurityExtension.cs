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
        /// 带密钥MD5加密
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

            HMACMD5 hmacMd5 = new HMACMD5(key);
            return hmacMd5.ComputeHash(data.ToBytes());
        }

        /// <summary>
        /// 带密钥MD5加密
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
        /// 带密钥MD5加密
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
        /// 带密钥MD5加密并返回Base64格式
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
        /// 带密钥MD5加密
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
            MD5 md5Provider = System.Security.Cryptography.MD5.Create();
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

        #region HmacSHA512

        /// <summary>
        /// 带密钥SHA512加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA512加密后的二进制数组</returns>
        public static byte[] HMACSHA512(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return null;
            }
            HMACSHA512 sha512Provider = new HMACSHA512(key);
            return sha512Provider.ComputeHash(data.ToBytes());
        }

        /// <summary>
        /// 带密钥SHA512加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA512加密后的十六进制编码字符串</returns>
        public static string HMACSHA512ToHex(this string data, string key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }

            byte[] hashBuff = data.HMACSHA512(key.ToBytes());

            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 带密钥SHA512加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA512加密后的十六进制编码字符串</returns>
        public static string HMACSHA512ToHex(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }
            byte[] hashBuff = data.HMACSHA512(key);
            return hashBuff.ToHexString();
        }


        /// <summary>
        /// 带密钥SHA512加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA512加密后的Base64编码字符串</returns>
        public static string HMACSHA512ToBase64(this string data, string key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }

            byte[] hashBuff = data.HMACSHA512(key.ToBytes());
            return hashBuff.ToBase64String();
        }

        /// <summary>
        /// 带密钥SHA512加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA512加密后的十六进制编码字符串</returns>
        public static string HMACSHA512ToBase64(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }
            byte[] hashBuff = data.HMACSHA512(key);
            return hashBuff.ToBase64String();
        }

        #endregion

        #region SHA512

        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA512加密后的Base64编码密文</returns>
        public static byte[] SHA512(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }
            var sha512 = System.Security.Cryptography.SHA512.Create();
            return sha512.ComputeHash(data.ToBytes());
        }


        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA512加密后的Base64编码密文</returns>
        public static string SHA512ToBase64(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }
            byte[] inArray = data.SHA512();
            return inArray.ToBase64String();
        }

        /// <summary>
        /// HA256加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <returns>返回SHA512加密后的十六进制格式密文</returns>
        public static string SHA512ToHex(this string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return string.Empty;
            }
            byte[] inArray = data.SHA512();
            return inArray.ToHexString();
        }

        #endregion

        #region HmacSha256

        /// <summary>
        /// 带密钥SHA256加密
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
            HMACSHA256 sha256Provider = new HMACSHA256(key);
            
            return sha256Provider.ComputeHash(data.ToBytes());
        }

        /// <summary>
        /// 带密钥SHA256加密
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
        /// 带密钥SHA256加密
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
        /// 带密钥SHA256加密
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
        /// 带密钥SHA256加密
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
            var sHA256 = System.Security.Cryptography.SHA256.Create();
            return sHA256.ComputeHash(data.ToBytes());
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

            byte[] bytes = data.ToBytes();
            var sha1Provider = System.Security.Cryptography.SHA1.Create();
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

        #region HmacSha1

        /// <summary>
        /// 带密钥SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA1加密后的二进制数组</returns>
        public static byte[] HMACSHA1(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return null;
            }
            HMACSHA1 hmacSha1 = new HMACSHA1(key);
            return hmacSha1.ComputeHash(data.ToBytes());
        }

        /// <summary>
        /// 带密钥SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA1加密后的十六进制编码字符串</returns>
        public static string HMACSHA1ToHex(this string data, string key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }

            byte[] hashBuff = data.HMACSHA1(key.ToBytes());

            return hashBuff.ToHexString();
        }

        /// <summary>
        /// 带密钥SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA1加密后的十六进制编码字符串</returns>
        public static string HMACSHA1ToHex(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }
            byte[] hashBuff = data.HMACSHA1(key);
            return hashBuff.ToHexString();
        }


        /// <summary>
        /// 带密钥SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA1加密后的Base64编码字符串</returns>
        public static string HMACSHA1ToBase64(this string data, string key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }

            byte[] hashBuff = data.HMACSHA1(key.ToBytes());
            return hashBuff.ToBase64String();
        }

        /// <summary>
        /// 带密钥SHA1加密
        /// </summary>
        /// <param name="data">待加密的数据</param>
        /// <param name="key">加密的密钥</param>
        /// <returns>返回HMACSHA1加密后的十六进制编码字符串</returns>
        public static string HMACSHA1ToBase64(this string data, byte[] key)
        {
            if (data.IsNullOrEmpty() || key.IsNullOrEmpty())
            {
                return data;
            }
            byte[] hashBuff = data.HMACSHA1(key);
            return hashBuff.ToBase64String();
        }

        #endregion

        #region AesEncrypt

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="iv">向量</param>
        /// <param name="mode">加密模式(CFB/OFB将在netstandard2.1后不可用)</param>
        /// <param name="padding">排列模式</param>
        /// <returns>返回一个二进制数组的密文</returns>
        public static byte[] AesEncrypt(this string data, byte[] password, byte[] iv, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return null;
            }
            if (iv.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(iv));
            }

            byte[] toEncryptArray = data.ToBytes();
            Aes aesProvider = Aes.Create();
            int length = aesProvider.Key.Length;
            if (password.Length < length)
            {
                throw new KeySizeException(length);
            }
            aesProvider.Key = password;
            aesProvider.IV = iv;
            aesProvider.Mode = mode;
            aesProvider.Padding = padding;
            ICryptoTransform cTransform = aesProvider.CreateEncryptor();
            return cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
        }
        
        /// <summary>
        /// AES加密【Cipher：ECB，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回AES加密后的Base64编码的密文</returns>
        public static string AesEncryptToBase64(this string data, string password)
        {
            return AesEncryptToBase64(data, password, CipherMode.ECB, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode"></param>
        /// <param name="padding"></param>
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
        /// AES加密【Cipher：ECB，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回AES加密后的Base64编码的密文</returns>
        public static string AesEncryptToBase64(this string data, byte[] password)
        {
            return AesEncryptToBase64(data, password, CipherMode.ECB, PaddingMode.PKCS7);
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
            return AesEncryptToBase64(data, password, Encoding.UTF8.GetBytes("0000000000000000"), mode, padding);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="iv"></param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">填充模式</param>
        /// <returns>返回一个Base64编码的密文</returns>
        public static string AesEncryptToBase64(this string data, byte[] password, byte[] iv, CipherMode mode, PaddingMode padding)
        {
            return AesEncrypt(data, password, iv, mode, padding)?.ToBase64String();
        }


        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个16进制字符编码的密文</returns>
        public static string AesEncryptToHex(this string data, string password)
        {
            return AesEncryptToHex(data, password, CipherMode.ECB, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode"></param>
        /// <param name="padding"></param>
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
            return AesEncryptToHex(data, password, CipherMode.ECB, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode"></param>
        /// <param name="padding"></param>
        /// <returns>返回一个16进制字符编码的密文</returns>
        public static string AesEncryptToHex(this string data, byte[] password, CipherMode mode, PaddingMode padding)
        {
            return AesEncryptToHex(data, password, Encoding.UTF8.GetBytes("0000000000000000"), mode, padding);
        }

        /// <summary>
        /// AES加密
        /// </summary>
        /// <param name="data">待加密的明文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="iv">向量</param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">排列模式</param>
        /// <returns>返回一个16进制字符编码的密文</returns>
        public static string AesEncryptToHex(this string data, byte[] password, byte[] iv, CipherMode mode, PaddingMode padding)
        {
            return AesEncrypt(data, password, iv, mode, padding)?.ToHexString();
        }

        #endregion

        #region AesDecrypt

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="iv">向量</param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">填充模式</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecrypt(this byte[] data, byte[] password, byte[] iv, CipherMode mode, PaddingMode padding)
        {
            Aes aesProvider = Aes.Create();

            int length = aesProvider.Key.Length;
            if (password.Length < length)
            {
                throw new KeySizeException(length);
            }
            aesProvider.IV = iv;
            aesProvider.Key = password;
            aesProvider.Mode = mode;
            aesProvider.Padding = padding;
            ICryptoTransform cTransform = aesProvider.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(data, 0, data.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES解密【Cipher：ECB，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormBase64(this string data, string password)
        {
            return AesDecryptFormBase64(data, password, CipherMode.ECB, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode"></param>
        /// <param name="padding"></param>
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
        /// AES解密【CipherMode：ECB，Padding：PKCS7】
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">密钥字节</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormBase64(this string data, byte[] password)
        {
            return AesDecryptFormBase64(data, password, CipherMode.ECB, PaddingMode.PKCS7);
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
            return AesDecryptFormBase64(data, password, Encoding.UTF8.GetBytes("0000000000000000"), mode, padding);
        }


        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="iv">向量</param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">填充模式</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormBase64(this string data, byte[] password, byte[] iv, CipherMode mode, PaddingMode padding)
        {
            if (data.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return data;
            }

            byte[] toEncryptArray = Convert.FromBase64String(data);
            return AesDecrypt(toEncryptArray, password, iv, mode, padding);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormHex(this string data, string password)
        {
            return AesDecryptFormHex(data, password, CipherMode.ECB, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormHex(this string data, byte[] password)
        {
            return AesDecryptFormHex(data, password, CipherMode.ECB, PaddingMode.PKCS7);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="mode"></param>
        /// <param name="padding"></param>
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
            return AesDecryptFormHex(data, password, Encoding.UTF8.GetBytes("0000000000000000"), mode, padding);
        }

        /// <summary>
        /// AES解密
        /// </summary>
        /// <param name="data">待解密的密文</param>
        /// <param name="password">加密公钥</param>
        /// <param name="iv">向量</param>
        /// <param name="mode">加密模式</param>
        /// <param name="padding">填充模式</param>
        /// <returns>返回一个由AesEncrypt加密而得到的明文</returns>
        public static string AesDecryptFormHex(this string data, byte[] password, byte[] iv, CipherMode mode, PaddingMode padding)
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

            return AesDecrypt(toEncryptArray, password, iv, mode, padding);
        }

        #endregion
    }
}
