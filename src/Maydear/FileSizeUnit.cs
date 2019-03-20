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
