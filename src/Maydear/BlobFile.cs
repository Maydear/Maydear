using System;
using System.Collections.Generic;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 二进制大对象文件信息
    /// </summary>
    public class BlobFile
    {
        /// <summary>
        /// 获取或设置对象记录唯一编号
        /// </summary>
        public Guid BlobFileUid { get; set; }

        /// <summary>
        /// 获取或设置文件资源地址
        /// </summary>
        public string BlobFileUri { get; set; }

        /// <summary>
        /// 获取或设置存储的文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 获取或设置原文件名
        /// </summary>
        public string SourceFileName { get; set; }

        /// <summary>
        /// 获取或设置存储的文件扩展名
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// 获取或设置容器名
        /// </summary>
        public string Container { get; set; }

        /// <summary>
        /// 获取或设置内容类型
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// 获取或设置内容识别码
        /// </summary>
        public string ContentMd5 { get; set; }

        /// <summary>
        /// 获取或设置内容长度（B）
        /// </summary>
        public long Length { get; set; }

        /// <summary>
        /// 获取或设置是否私密【0：公开，1：私密】
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// 获取或设置创建日期
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// 获取或设置最后修改日期
        /// </summary>
        public DateTimeOffset ModifyDate { get; set; }

        /// <summary>
        /// 缓存路径
        /// </summary>
        public string CacheFilePath => System.IO.Path.Combine(CacheDirectory, $"{BlobFileUid.ToString("N")}{ExtensionName}");

        /// <summary>
        /// 缓存目录
        /// </summary>
        public string CacheDirectory => $"{CreateDate.ToString("yyyy/MM")}";
    }
}
