using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Maydear.Infrastructure
{
    /// <summary>
    /// blob存储基础类库
    /// </summary>
    public interface IBlobFileInfrastructure
    {

        /// <summary>
        /// 通过流下载Blob文件
        /// </summary>
        /// <param name="blobFile">Blob文件信息</param>
        /// <param name="outputStream">输出的流对象</param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns></returns>
        Task DownloadStreamAsync(BlobFile blobFile, Stream outputStream, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 通过字节码下载Blob文件
        /// </summary>
        /// <param name="blobFile">Blob文件信息</param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns>返回指定Blob文件二进制字节码</returns>
        Task<byte[]> DownloadBytesAsync(BlobFile blobFile, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 通过异步流上传
        /// </summary>
        /// <param name="blobFile">Blob文件信息</param>
        /// <param name="intputStream">输入的流对象</param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns>异步返回Blob文件信息</returns>
        Task<BlobFile> UploadStreamAsync(BlobFile blobFile, Stream intputStream, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 通过字节码上传到Blob
        /// </summary>
        /// <param name="blobFile">Blob文件信息</param>
        /// <param name="intputBuffer">输入字节码数组</param>
        /// <param name="index">起始点</param>
        /// <param name="count">数量</param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns>异步返回Blob文件信息</returns>
        Task<BlobFile> UploadByteArrayAsync(BlobFile blobFile, byte[] intputBuffer, int index, int count, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 通过文件上传到Blob
        /// </summary>
        /// <param name="blobFile">Blob文件信息</param>
        /// <param name="filePath">文件路径</param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns>异步返回Blob文件信息</returns>
        Task<BlobFile> UploadFileAsync(BlobFile blobFile, string filePath, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 获取Blob文件信息
        /// </summary>
        /// <param name="blobUri">Blob文件资源地址</param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns>异步返回Blob文件信息</returns>
        Task<BlobFile> FetchAsync(string blobUri, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 检查Blob是否存在
        /// </summary>
        /// <param name="blobUri"></param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns>如果Uri资源已经在Blob上存在则返回true，反之则返回false</returns>
        Task<bool> ExistsAsync(string blobUri, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 删除blob文件
        /// </summary>
        /// <param name="blobFile">Blob文件信息</param>
        /// <param name="cancellationToken">线程取消令牌对象</param>
        /// <returns>如果blob删除成功则返回true，反之则返回false</returns>
        Task<bool> DeleteAsync(BlobFile blobFile, CancellationToken cancellationToken = default(CancellationToken));
    }
}
