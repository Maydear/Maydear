using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Maydear
{
    /// <summary>
    /// 文件大小单位
    /// </summary>
   public enum FileSizeUnit
    {
        /// <summary>
        /// Kb
        /// </summary>
        [Description("Kb")]
        KB = 10,

        /// <summary>
        /// MB
        /// </summary>
        [Description("Mb")]
        MB = 20,

        /// <summary>
        /// GB
        /// </summary>
        [Description("Gb")]
        GB = 30,

        /// <summary>
        /// TB
        /// </summary>
        [Description("Tb")]
        TB = 40,
    }
}
