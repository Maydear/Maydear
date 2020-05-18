using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Maydear.Extensions
{
    /// <summary>
    /// 流扩展
    /// </summary>
    public static class StreamExtension
    {
        /// <summary>
        /// 转为bytes
        /// </summary>
        /// <param name="stream">流对象</param>
        /// <returns></returns>
        public static byte[] ToBytes(this Stream stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
            var bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            // 设置当前流的位置为流的开始 
            stream.Seek(0, SeekOrigin.Begin);
            return bytes;
        }
    }
}
