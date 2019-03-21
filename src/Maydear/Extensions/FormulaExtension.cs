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
using System.Collections;
using System.Text.RegularExpressions;

/*****************************************************************************************
 * FileName:EnumExtension.cs
 * Author:Kelvin
 * CreateDate:2014/09/22 15:02:45
 * Description:
 *        
 *        <version>	|	<author>	|<time>			        |	<desc>
 *        1		    |	Kelvin		|2014-09-22 15:20:00	|	创建文件
 ****************************************************************************************/

namespace Maydear.Extensions
{
    /// <summary>
    /// 字符串四则运算扩展
    /// </summary>
    public static class FormulaExtension
    {
        private const string NUM_REGEX = "(\\-?\\d+\\.?\\d*)";
        private const string FUNC1_REGEX = "(exp|log|log10|abs|sqr|sqrt|sin|cos|tan|asin|acos|atan)";
        private const string FUNC2_REGEX = "(atan2)";
        private const string FUNC3_REGEX = "(min|max)";
        private const string Constants = "(e|pi)";

        /// <summary>
        /// 公式运算
        /// </summary>
        /// <param name="expr">计算公式</param>
        /// <returns>返回计算结果</returns>
        public static decimal Evaluate(string expr)
        {
            if (string.IsNullOrEmpty(expr))
                return 0;

            Regex rePower = new Regex(NUM_REGEX + "\\s*(\\^)\\s*" + NUM_REGEX);
            Regex reAddSub = new Regex(NUM_REGEX + "\\s*([-+])\\s*" + NUM_REGEX);
            Regex reMulDiv = new Regex(NUM_REGEX + "\\s*([*/])\\s*" + NUM_REGEX);
            Regex reFunc1 = new Regex(FUNC1_REGEX + "\\(\\s*" + NUM_REGEX + "\\s*\\)", RegexOptions.IgnoreCase);
            Regex reFunc2 = new Regex(FUNC2_REGEX + "\\(\\s*" + NUM_REGEX + "\\s*,\\s*" + NUM_REGEX + "\\s*\\)", RegexOptions.IgnoreCase);
            Regex reFuncN = new Regex(FUNC3_REGEX + "\\((\\s*" + NUM_REGEX + "\\s*,)+\\s*" + NUM_REGEX + "\\s*\\)", RegexOptions.IgnoreCase);
            Regex reSign1 = new Regex("([-+/*^])\\s*\\+");
            Regex reSign2 = new Regex("\\-\\s*\\-");
            Regex rePar = new Regex("(?<![A-Za-z0-9])\\(\\s*([-+]?\\d+.?\\d*)\\s*\\)");
            Regex reNum = new Regex("^\\s*[-+]?\\d+\\.?\\d*\\s*$");
            Regex reConst = new Regex("\\s*" + Constants + "\\s*");

            expr = reConst.Replace(expr, DoConstants(reConst.Match(expr)));

            while (!reNum.IsMatch(expr))
            {
                string saveExpr = expr;
                expr = rePower.Replace(expr, DoPower(rePower.Match(expr)), rePower.Matches(expr).Count);

                expr = reMulDiv.Replace(expr, DoMulDiv(reMulDiv.Match(expr)), reMulDiv.Matches(expr).Count);

                expr = reFuncN.Replace(expr, DoFunc3(reFuncN.Match(expr)), reFuncN.Matches(expr).Count);

                expr = reFunc2.Replace(expr, DoFunc2(reFunc2.Match(expr)), reFunc2.Matches(expr).Count);

                expr = reFunc1.Replace(expr, DoFunc1(reFunc1.Match(expr)), reFunc1.Matches(expr).Count);

                expr = reSign1.Replace(expr, "$1");
                expr = reSign2.Replace(expr, "+");
                expr = reAddSub.Replace(expr, DoAddSub(reAddSub.Match(expr)), reAddSub.Matches(expr).Count);
                expr = rePar.Replace(expr, "$1");
                if (saveExpr == expr)
                    return 0;
            }

            return decimal.Parse(expr);
        }

        /// <summary>
        /// PI,E
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private static string DoConstants(Match m)
        {
            string V = "";
            switch (m.Groups[1].Value.ToUpper())
            {
                case "PI":
                    V = Math.PI.ToString();
                    break;
                case "E":
                    V = Math.E.ToString();
                    break;
                default:
                    break;
            }
            return V;
        }

        /// <summary>
        /// 指数运算
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private static string DoPower(Match m)
        {
            decimal n1 = decimal.Parse(m.Groups[1].Value), n2 = decimal.Parse(m.Groups[3].Value);
            return Math.Pow((double)n1, (double)n2).ToString();
        }

        /// <summary>
        /// 乘除
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private static string DoMulDiv(Match m)
        {
            decimal n1 = decimal.Parse(m.Groups[1].Value), n2 = decimal.Parse(m.Groups[3].Value);
            string V = "";
            switch (m.Groups[2].Value.ToUpper())
            {
                case "/":
                    V = (n1 / n2).ToString();
                    break;
                case "*":
                    V = (n1 * n2).ToString();
                    break;
                default:
                    break;
            }
            return V;
        }

        /// <summary>
        /// 加减
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private static string DoAddSub(Match m)
        {
            decimal n1 = decimal.Parse(m.Groups[1].Value), n2 = decimal.Parse(m.Groups[3].Value);
            string V = "";
            switch (m.Groups[2].Value.ToUpper())
            {
                case "+":
                    V = (n1 + n2).ToString();
                    break;
                case "-":
                    V = (n1 - n2).ToString();
                    break;
                default:
                    break;
            }
            return V;
        }

        /// <summary>
        /// exp|log|log10|abs|sqr|sqrt|sin|cos|tan|asin|acos|atan
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private static string DoFunc1(Match m)
        {
            decimal n1 = decimal.Parse(m.Groups[2].Value);
            string V = "";
            switch (m.Groups[1].Value.ToUpper())
            {
                case "EXP":
                    V = Math.Exp((double)n1).ToString();
                    break;
                case "LOG":
                    V = Math.Log((double)n1).ToString();
                    break;
                case "LOG10":
                    V = Math.Log10((double)n1).ToString();
                    break;
                case "ABS":
                    V = Math.Abs((double)n1).ToString();
                    break;
                case "SQRT":
                case "SQR":
                    V = Math.Sqrt((double)n1).ToString();
                    break;
                case "SIN":
                    V = Math.Sign((double)n1).ToString();
                    break;
                case "COS":
                    V = Math.Cos((double)n1).ToString();
                    break;
                case "TAN":
                    V = Math.Tan((double)n1).ToString();
                    break;
                case "ASIN":
                    V = Math.Asin((double)n1).ToString();
                    break;
                case "ACOS":
                    V = Math.Acos((double)n1).ToString();
                    break;
                case "ATAN":
                    V = Math.Atan((double)n1).ToString();
                    break;
                default:
                    break;
            }
            return V;
        }

        /// <summary>
        /// ATAN2
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private static string DoFunc2(Match m)
        {
            decimal n1 = decimal.Parse(m.Groups[2].Value), n2 = decimal.Parse(m.Groups[3].Value);
            string V = "";
            switch (m.Groups[1].Value.ToUpper())
            {
                case "ATAN2":
                    V = Math.Atan2((double)n1, (double)n2).ToString();
                    break;
                default:
                    break;
            }
            return V;
        }

        /// <summary>
        /// MAX.MIN
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        private static string DoFunc3(Match ma)
        {
            String V = "";
            ArrayList args = new ArrayList();
            int i = 2;
            while (!string.IsNullOrEmpty(ma.Groups[i].Value))
            {
                args.Add(decimal.Parse(ma.Groups[i].Value.Replace(',', ' ')));
                i += 1;
            }

            switch (ma.Groups[1].Value.ToUpper())
            {
                case "MIN":
                    args.Sort();
                    V = args[0].ToString();
                    break;
                case "MAX":
                    args.Sort();
                    V = args[args.Count - 1].ToString();
                    break;
                default:
                    break;
            }

            return V;
        }
    }
}
