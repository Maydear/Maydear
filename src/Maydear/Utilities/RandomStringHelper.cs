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
using System.Text;

namespace Maydear.Utilities
{
    /// <summary>
    /// 随机字符串助手类
    /// </summary>
    public static class RandomStringHelper
    {
        /// <summary>
        /// 获取随机字母字符串
        /// </summary>
        /// <param name="length">字符串长度</param>
        /// <returns>返回指定长度的字母字符串</returns>
        public static string NextLettersString(int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }

            const int asciiStart = (int)'a';
            const int asciiEnd = (int)'z';
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(Convert.ToChar(RandomHelper.Next(asciiStart, asciiEnd)));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取随机可见Ascii字符串
        /// </summary>
        /// <param name="length">待返回字符串长度</param>
        /// <returns>返回指定长度的Ascii字符串</returns>
        public static string NextAsciiString(int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }

            const int asciiStart = 33;
            const int asciiEnd = 126;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                var index = RandomHelper.Next(asciiStart, asciiEnd);
                sb.Append(Convert.ToChar(index));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取随机数字字符串
        /// </summary>
        /// <param name="length">字符串长度</param>
        /// <returns>返回指定长度的数字字符串</returns>
        public static string NextNumberString(int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(RandomHelper.Next(0, 9));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取指定来源的随机字符串
        /// </summary>
        /// <param name="length">字符串长度</param>
        /// <param name="source">来源字符数据</param>
        /// <returns>返回指定长度的字符串</returns>
        public static string NextString(int length, string source)
        {
            if (length <= 0)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(RandomHelper.Next<char>(source.ToCharArray()));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 获取随机昵称
        /// </summary>
        /// <returns>返回指定长度的字符串</returns>
        public static string NextNickname()
        {
            return NicknameList[RandomHelper.Next(0, NicknameList.Length - 1)];
        }

        #region 昵称列表
        private readonly static string[] NicknameList = { "丁仪","丁奉","丁原","丁谧",
"丁廙","于禁","士孙瑞","山涛",
"卫瓘","马磾","马良","马忠",
"马超","马谡","马腾","王允",
"王双","王平","王匡","王戎",
"王观","王甫","王连","王沈",
"王肃","王修","王浑","王路",
"王颀","王祥","王朗","王基",
"王谋","王粲","王睿","韦康",
"太史慈","毛玠","公孙度","公孙瓒",
"文钦","文聘","尹奉","邓艾",
"邓芝","邓止飏","孔伷","孔昱",
"孔融","母丘甸","母丘俭","甘宁",
"左慈","卢植","申耽","田丰","田畴","田豫","史涣","乐进",
"冯习","司马师","司马防","司马炎",
"司马昭","司马儁","司马朗","司马望",
"司马徽","司马懿","边让","吉穆",
"吉邈","毕轨","吕布","吕范",
"吕凯","吕岱","吕虔","吕据",
"吕蒙","朱隽","朱然","伍孚",
"伍琼","任峻","华陀","华歆",
"华核","伊籍","向朗","全琮",
"刘巴","刘永","刘协","刘先",
"刘邠","刘劭","刘表","刘岱",
"刘备","刘放","刘宠","刘勋",
"刘晔","刘陶","刘理","刘焉",
"刘琰","刘禅","刘虞","刘廙",
"刘璋","刘繇","刘瑢","刘馥",
"羊祜","关羽","许允","许攸",
"许劭","许靖","许褚","许慈",
"孙礼","孙匡","孙权","孙休",
"孙观","孙坚","孙和","孙河",
"孙亮","孙桓","孙峻","孙资","孙乾","孙皓","孙皎","孙翊",
"孙綝","孙策","孙登","孙瑜",
"刘静","孙韶","邯郸淳","严畯",
"社预","社袭","杜琼","杜微",
"杨仪","唐阜","杨修","杨洪",
"杨彪","杨暨","李严","李典",
"李胜","李恢","孝通","李福",
"李撰","吾粲","邴原","来敏",
"步骘","吴质","岑晊","何进",
"何宗","何晏","何曾","何颙",
"应劭","辛毗","辛敞","宋忠",
"张飞","张辽","张休","张华",
"张纮","张茂","张松","张郃",
"张承","张南","张昭","张津","张特","张悌","张既","张鲁",
"张温","张缉","张裔","张嶷",
"张邈","张翼","陆纡","陆抗",
"陆凯","陆逊","陆骏","陆康",
"陆绩","陈武","陈宫","陈泰",
"陈矫","陈琳","陈翔","陈登",
"陈骞","陈群","陈震","邵悌",
"苑康","范滂","和洽","金尚",
"金袆","金旋","周奂","周昕",
"周毖","周泰","周鲂","周瑜",
"周群","庞统","庞德","庞德公",
"郑泰","郑袤","法正","宗预",
"审配","孟达","孟光","孟宗",
"孟建","赵云","赵歧","赵昂",
"赵咨","荀攸","荀恽","荀彧",
"荀爽","荀勖","荀谌","荀顗",
"胡奋","胡质","胡济","胡烈",
"胡渊","胡邈","种会","钟毓",
"钟繇","种劭","钟拂","皇甫嵩",
"郗虑","郤正","姜叙","姜维","娄圭","祖茂","祢衡","费观",
"费祎","骆统","秦宓","秦朗",
"袁术","袁尚","袁绍","袁逢",
"袁隗","袁遗","袁熙","袁谭",
"耿纪","桓阶","桓范","桥玄",
"贾充","贾诩","贾逵","夏侯玄",
"夏侯尚","夏侯和","夏侯威","夏侯敦",
"夏侯渊","夏侯惠","夏侯琳","夏侯霸",
"顾雍","徐晃","徐盛","徐庶",
"徐璆","脂习","留赞","凌统",
"高干","高柔","郭攸之","郭奕",
"郭恩","郭淮","郭嘉","诸葛诞",
"诸葛亮","诸葛恪","诸葛珪","诸葛原",
"诸葛靓","诸葛瑾","诸葛瞻","陶谦",
"黄权","黄忠","黄盖","曹仁",
"曹丕","曹休","曹宇","曹芳",
"曹奂","曹纯","曹昂","曹洪",
"曹真","曹爽","曹植","曹嵩",
"曹髦","曹睿","曹彰","曹操","眭固","崔琰","淳于琼","彭羕",
"董允","董卓","董和","董昭",
"董袭","董厥","蒋干","蒋钦",
"蒋济","蒋琬","韩当","韩珩",
"韩浩","韩遂","韩嵩","韩暨",
"韩馥","程秉","程昱","程普",
"程畿","傅干","傅巽","傅嘏",
"鲁肃","蒯良","蒯越","楼玄",
"虞翻","路粹","简雍","满宠",
"蔡邕","蔡琰","臧霸","裴秀",
"管宁","管恪","廖化","廖立",
"谯周","樊建","滕胤","圆泽",
"潘璋","潘浚","薛悌","薛综","霍峻","檀敷","魏延","糜芳",
"糜竺","濮阳兴",
"丁夫人","丁立","丁封","丁咸","丁斐","于吉",
"于诠","于糜士孙瑞","万彧","卫仲道","卫演",
"马元义","马玉","马休","马延","马宇","马良",
"马玩","马忠","马岱","马钧","马铁","马遵",
"马邈","王子服","王夫人","王方","王允","王业",
"正立","王必","王则","王伉","王买","王邑",
"王含","王建","王经","王经母","王威","王美人",
"王颀","王累","王敦","王琰","王楷","王瓘",
"韦晃","区星","车胄","牛金","牛辅","毛后",
"公孙修","公孙恭","公孙晃","公孙康","公孙渊","公孙越",
"卞后","文丑","文虎","文鸯","尹大目","尹礼",
"尹赏","尹楷","尹默","邓义","邓龙","邓良邓贤","邓忠","邓铜","邓敦","孔宙","甘夫人",
"左丰","左灵","石广元","石苞","申仪","田氏",
"田章","田续","田楷","丘建","白寿","句安",
"乐","綝","乐就","冯礼","冯紞","司马攸","司马伷",
"司马孚","司马钧","司马儁","司蕃","边洪","邢贞",
"成何","成宜","成济","成倅","成廉","师纂",
"吕公","吕旷","吕伯奢","吕建","吕威璜","吕据",
"吕常","吕翔","吕霸","朱光","朱异",
"朱灵","朱治","朱桓","朱恩","朱褒","朱赞",
"伍习","伍延","伏后","伏完","伏德","任夔",
"华雄","向宠","向举","全公主","全后","全纪",
"全尚","全尚妻","全怿","全样","全端","刘元起",
"刘氏","刘艾","刘宁","刘邠","刘延","刘丞刘范","刘贤","刘郃","刘封","刘度","刘恂",
"刘豹","刘敏","刘谌","刘清","刘淙","刘琬",
"刘循","刘","寔","刘瑁","刘璝","刘瑶","刘熙",
"刘磐","刘辩","刘璩","刘瓒","关平","关兴",
"关彝","州泰","许仪","许芝","许汜","许贡",
"许贡家客许昌","许晏","许韶","阳群","阴夔",
"纪灵","孙干","孙夫人","孙异","孙秀","孙闿",
"孙恭","孙恩","孙高","孙朗","孙据","孙谦",
"孙楷","孙歆","孙雨单","严白虎","严象","严舆",
"严颜","苏飞","苏双","苏由","苏越","杜义",
"杜祺","杜路","杨氏","杨丑","杨任","杨怀",
"杨奉","杨昂","杨欣","杨秋","杨洪","杨济",
"杨祚","杨密","杨综","杨琦","杨颙","李丰",
"李乐","李伏","李异","李孚","李虎","李服",
"李肃","李封","李球","李辅","李崇","李堪",
"李催","李蒙","李歆","李暹","李儒","吾彦",
"来敏","步阐","吴子兰","吴夫人","吴匡","吴纲",
"吴班","吴硕","吴景","吴敦","吴懿","岑昏",
"何平","何仪","何苗","何曼","何植",
"谷利","邹靖","辛评","辛宪英","闵贡","沙摩柯沈莹","宋果","宋宪","宋谦","张卫","张允",
"张世平","张节","张布","张让","张达","张当",
"张任","张后","张约","张杨","张角","张纯",
"张英","张苞","张虎","张宝","张肃","张弥",
"张绍","张南","张勋","张钧","张俭","张音",
"张闿","张济","张举","张峻","张绣","张著",
"张爽","张梁","张超","张颢","张鲁母","张象",
"张温","张横","张遵","张燕","张衡","陆景",
"陈生","陈兰","陈式","陈炜","陈珪","陈耽",
"陈就","妫览","范疆","卓膺","尚广","尚弘",
"昌豨","昌霸","典韦","典满","卑衍","周旨",
"周尚","周胤","周循","庞会","庞柔","庞舒",
"庞羲","郑宝","郑度","单子春","法真","沮授",
"沮鹄","审荣","孟获","封谞","赵广","赵月",
"赵弘","赵范","赵直","赵忠","赵彦","赵统",
"赵累","赵韪","赵睿","赵融","赵衢","郝昭",
"郝萌","荀恺","荀绲","胡才","胡车儿","胡氏",
"胡冲","胡赤儿","胡轸","胡遵","柳甫","牵弘",
"轲比能","种拂","种辑","段珪","段煨","皇甫郦",
"皇甫闿","侯成","侯览","侯选","爰邵","爰青彡",
"施朔","姜冏","迷当","祖郎","费诗","袁胤",
"袁綝","耿武","桓嘉","桓彝","桥蕤","贾范",
"夏侯令女夏侯兰","夏侯咸","夏恽","徐夫人","徐氏",
"徐质","徐荣","徐勋","徐商","徐璜","殷纯",
"留平","留略","凌操","高沛","高定","高览",
"高顺","高翔","郭永","郭汜","郭汜妻",
"郭图","郭胜","唐妃","唐周","唐咨","唐彬",
"诸葛玄","诸葛均","诸葛尚","诸葛虔","诸葛绪","陶应",
"陶商","陶睿","黄氏","黄承彦","黄祖","黄崇",
"黄琬","黄皓","曹文叔","曹节","曹训","曹后",
"曹安民","曹性","曹豹","曹据","曹熊","曹德",
"曹遵","曹霖","曹羲","龚都","盛勃","睦元进",
"常雕","崔州平","崔烈","笮融","阎芝","阎宇",
"阎晏","阎圃","阎象","梁刚","梁兴","梁虔",
"梁宽","梁绪","彭伯","董太后","董寻","董祀",
"董旻","董承","董贵妃","董重","董超","董朝",
"董璜","董衡","蒋义渠","蒋延","蒋奇","蒋显",
"蒋班","蒋舒","蒋斌","韩玄","韩忠","韩莒子",
"韩胤","韩猛","韩综","韩暹","韩融","程武",
"程咨","程银","傅金","傅彤","傅婴","焦伯焦","触","焦彝","鲁芝","鲁馗","谢旌","赖恭",
"甄氏","雷铜","雷薄","虞松","鲍信","雍闿",
"蔡夫人","蔡阳","蔡林","蔡瑁","臧旻","舞阳君",
"管亥","管辂舅","曲义","樊氏","樊岐","樊能",
"樊稠","滕循","颜良","潘夫人","潘隐","薛兰",
"薛礼","薛珝","薛莹","戴员","戴陵","蹋顿",
"魏平","魏续","魏邈","糜夫人","蹇硕","爨习",
"冯方","刘辟","黄邵" };
        #endregion
    }
}
