namespace Maydear.Extensions
{
    /// <summary>
    /// 文件大小单位扩展
    /// </summary>
    public static class FileSizeUnitExtension
    {
        /// <summary>
        /// 将B单位转换为1024内的长度
        /// </summary>
        /// <param name="fileSizeForBytes">文件字节长度</param>
        /// <param name="fileSizeUnit">单位类型</param>
        /// <returns></returns>
        public static string ChangeFileSizeUnit(this long fileSizeForBytes, FileSizeUnit fileSizeUnit)
        {
            return $"{(fileSizeForBytes >> (int)fileSizeUnit)}{fileSizeUnit.ToString()}";
        }

        /// <summary>
        /// 将B单位转换为1024内的长度
        /// </summary>
        /// <param name="fileSizeForBytes">文件字节长度</param>
        /// <param name="fileSizeUnit">单位类型</param>
        /// <returns></returns>
        public static string ChangeFileSizeUnit2Decimal (this long fileSizeForBytes, FileSizeUnit fileSizeUnit)
        {
            decimal fileSizeUnitResult = 0M;

            switch (fileSizeUnit) {
                case FileSizeUnit.KB:
                    fileSizeUnitResult = fileSizeForBytes / 1024M;
                    break;
                case FileSizeUnit.MB:
                    fileSizeUnitResult = fileSizeForBytes / (1024M*1024M);
                    break;
                case FileSizeUnit.GB:
                    fileSizeUnitResult = fileSizeForBytes / (1024M * 1024M * 1024M);
                    break;
                case FileSizeUnit.TB:
                    fileSizeUnitResult = fileSizeForBytes / (1024M * 1024M * 1024M* 1024M);
                    break;
            }

            return fileSizeUnitResult.ToString("F2");
        }
    }
}
