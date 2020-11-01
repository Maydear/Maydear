using Maydear.Exceptions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace System.Security.Cryptography
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringRSAExtension
    {
        /// <summary>
        /// RSA签名
        /// </summary>
        /// <param name="content">数据</param>
        /// <param name="privateKeyPath">RSA私钥路径</param>
        /// <param name="password">RSA私钥密码</param>
        /// <returns></returns>
        public static string BuildRsaSHA1SignatureToHex(this string content, string privateKeyPath, string password)
        {
            return BuildRsaSHA1Signature(content, privateKeyPath, password)?.ToHexString();
        }

        /// <summary>
        /// RSA签名
        /// </summary>
        /// <param name="content">数据</param>
        /// <param name="privateKeyPath">RSA私钥路径</param>
        /// <param name="password">RSA私钥密码</param>
        /// <returns></returns>
        public static string BuildRsaSHA1SignatureToBase64(this string content, string privateKeyPath, string password)
        {
            return BuildRsaSHA1Signature(content, privateKeyPath, password)?.ToBase64String();
        }

        /// <summary>
        /// 生成RSA签名
        /// </summary>
        /// <param name="content">数据</param>
        /// <param name="privateKeyPath">RSA私钥路径</param>
        /// <param name="password">RSA私钥密码</param>
        /// <returns></returns>
        public static byte[] BuildRsaSHA1Signature(this string content, string privateKeyPath, string password)
        {
            if (!System.IO.File.Exists(privateKeyPath))
            {
                throw new FileNotExistsException(privateKeyPath);
            }

            if (!System.IO.File.Exists(privateKeyPath))
            {
                throw new Maydear.Exceptions.ArgumentNullException(privateKeyPath);
            }

            X509Certificate2 x509Certificate = new X509Certificate2(privateKeyPath, password);

            var signatureFormatter = new RSAPKCS1SignatureFormatter(x509Certificate.PrivateKey);
            signatureFormatter.SetHashAlgorithm(HashAlgorithmName.SHA1.Name);
            byte[] bytes = signatureFormatter.CreateSignature(content.ToBytes());
            return bytes;
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="content">验证内容</param>
        /// <param name="publicKeyPath">公钥路径</param>
        /// <param name="signature">签名信息</param>
        /// <returns>验证成功则返回true,失败则返回false</returns>
        public static bool RsaSHA1Verify(this string content, string publicKeyPath, byte[] signature)
        {
            try
            {
                X509Certificate2 x509Certificate = new X509Certificate2(publicKeyPath);
                var signatureDeformatter = new RSAPKCS1SignatureDeformatter(x509Certificate.PublicKey.Key);
                signatureDeformatter.SetHashAlgorithm(HashAlgorithmName.SHA1.Name);
                return signatureDeformatter.VerifySignature(content.ToBytes(), signature);
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (SystemException ex2)
            {
                throw ex2;
            }
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="content">验证内容</param>
        /// <param name="publicKeyPath">公钥路径</param>
        /// <param name="signature">通过十六进制编码的签名信息</param>
        /// <returns>验证成功则返回true,失败则返回false</returns>
        public static bool RsaSHA1VerifyFromHex(this string content, string publicKeyPath, string signature)
        {
            if (content.IsNullOrEmpty() || signature.IsNullOrEmpty())
            {
                return false;
            }

            byte[] signatureBytes = new byte[signature.Length / 2];

            for (int i = 0; i < signature.Length; i += 2)
            {
                signatureBytes[i / 2] = Convert.ToByte(signature.Substring(i, 2), 16);
            }
            return RsaSHA1Verify(content, publicKeyPath, signatureBytes);
        }

        /// <summary>
        /// 验证签名
        /// </summary>
        /// <param name="content">验证内容</param>
        /// <param name="publicKeyPath">公钥路径</param>
        /// <param name="signature">通过base64编码的签名信息</param>
        /// <returns>验证成功则返回true,失败则返回false</returns>
        public static bool RsaSHA1VerifyFromBase64(this string content, string publicKeyPath, string signature)
        {
            if (content.IsNullOrEmpty() || signature.IsNullOrEmpty())
            {
                return false;
            }

            byte[] signatureBytes = Convert.FromBase64String(signature);
            return RsaSHA1Verify(content, publicKeyPath, signatureBytes);
        }

    }
}
