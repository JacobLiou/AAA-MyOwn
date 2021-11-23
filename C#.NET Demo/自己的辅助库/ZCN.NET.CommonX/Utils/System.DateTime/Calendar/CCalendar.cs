using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ZCN.NET.CommonX.Extensions
{
    /// <summary>
    ///	 常用显示日期时间、农历、生肖的日历类
    /// </summary>
    public class CCalendar
    {
        /// <summary>
        /// 自定义的CCalendarDate.XML的限定名称，命名空间修改，必须也跟着修改，
        /// 右键查看CCalendarData.xml文件的属性可以看到它的命名空间。
        /// 必须设置为嵌入的资源
        /// </summary>
        const string CCalendarDateFile = "ZCN.NET.CommonX.Utils.System.DateTime.Calendar.CCalendarData.xml";

        /// <summary>
        /// 结构。日期对象
        /// </summary>
        struct StructDate
        {
            public int Year;
            public int Month;
            public int Day;
            public bool IsLeap;			//是否闰月
            public int YearCyl;			//年干支
            public int MonthCyl;		//月干支
            public int DayCyl;			//日干支
        }

        /// <summary>
        /// 结构。完整的日期对象
        /// </summary>
        public struct StructDateFullInfo
        {
            /// <summary>
            /// 公历年
            /// </summary>
            public int Year;

            /// <summary>
            /// 公历月
            /// </summary>
            public int Month;

            /// <summary>
            /// 公历日
            /// </summary>
            public int Day;

            /// <summary>
            /// 是否闰月
            /// </summary>
            public bool IsLeap;			//是否闰月

            /// <summary>
            /// 农历年
            /// </summary>
            public int CYear;			//农历年

            /// <summary>
            /// 农历年名称
            /// </summary>
            public string ScYear;		//农历年名称

            /// <summary>
            /// 干支
            /// </summary>
            public string CYearCyl;		//干支年

            /// <summary>
            /// 农历月
            /// </summary>
            public int CMonth;			//农历月

            /// <summary>
            /// 农历月名称
            /// </summary>
            public string ScMonth;		//农历月名称

            /// <summary>
            /// 干支月
            /// </summary>
            public string CMonthCyl;	//干支月

            /// <summary>
            /// 农历日
            /// </summary>
            public int CDay;			//农历日

            /// <summary>
            /// 农历日名称
            /// </summary>
            public string ScDay;		//农历日名称

            /// <summary>
            /// 干支日
            /// </summary>
            public string CDayCyl;		//干支日

            /// <summary>
            /// 节气
            /// </summary>
            public string Solarterm;	//节气

            /// <summary>
            /// 星期几
            /// </summary>
            public string DayInWeek;	//星期几

            /// <summary>
            /// 节日
            /// </summary>
            public string Feast;		//节日

            /// <summary>
            /// 系统问候语
            /// </summary>
            public string Info;			//系统问候语

            /// <summary>
            /// 主题图片
            /// </summary>
            public string Image;	    //主题图片

            /// <summary>
            /// 完整的日期信息
            /// </summary>
            public string FullInfo;		//完整的日期信息

            /// <summary>
            /// 有特别的问候语吗
            /// </summary>
            public bool SayHello;		//有特别的问候语吗？
        }

        #region 农历相关数据

        //农历月份信息
        int[] lunarInfo = new int[]{0x04bd8,0x04ae0,0x0a570,0x054d5,0x0d260,0x0d950,0x16554,0x056a0,0x09ad0,0x055d2, 
									0x04ae0,0x0a5b6,0x0a4d0,0x0d250,0x1d255,0x0b540,0x0d6a0,0x0ada2,0x095b0,0x14977, 
									0x04970,0x0a4b0,0x0b4b5,0x06a50,0x06d40,0x1ab54,0x02b60,0x09570,0x052f2,0x04970, 
									0x06566,0x0d4a0,0x0ea50,0x06e95,0x05ad0,0x02b60,0x186e3,0x092e0,0x1c8d7,0x0c950, 
									0x0d4a0,0x1d8a6,0x0b550,0x056a0,0x1a5b4,0x025d0,0x092d0,0x0d2b2,0x0a950,0x0b557, 
									0x06ca0,0x0b550,0x15355,0x04da0,0x0a5d0,0x14573,0x052d0,0x0a9a8,0x0e950,0x06aa0, 
									0x0aea6,0x0ab50,0x04b60,0x0aae4,0x0a570,0x05260,0x0f263,0x0d950,0x05b57,0x056a0, 
									0x096d0,0x04dd5,0x04ad0,0x0a4d0,0x0d4d4,0x0d250,0x0d558,0x0b540,0x0b5a0,0x195a6, 
									0x095b0,0x049b0,0x0a974,0x0a4b0,0x0b27a,0x06a50,0x06d40,0x0af46,0x0ab60,0x09570, 
									0x04af5,0x04970,0x064b0,0x074a3,0x0ea50,0x06b58,0x055c0,0x0ab60,0x096d5,0x092e0, 
									0x0c960,0x0d954,0x0d4a0,0x0da50,0x07552,0x056a0,0x0abb7,0x025d0,0x092d0,0x0cab5, 
									0x0a950,0x0b4a0,0x0baa4,0x0ad50,0x055d9,0x04ba0,0x0a5b0,0x15176,0x052b0,0x0a930, 
									0x07954,0x06aa0,0x0ad50,0x05b52,0x04b60,0x0a6e6,0x0a4e0,0x0d260,0x0ea65,0x0d530, 
									0x05aa0,0x076a3,0x096d0,0x04bd7,0x04ad0,0x0a4d0,0x1d0b6,0x0d250,0x0d520,0x0dd45, 
									0x0b5a0,0x056d0,0x055b2,0x049b0,0x0a577,0x0a4b0,0x0aa50,0x1b255,0x06d20,0x0ada0};
        //公历月份
        readonly int[] _solarMonth = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        readonly string[] _cMonthName = new string[] { "", "正月", "二月", "三月", "四月", "五月", "六月", "七月", "八月", "九月", "十月", "十一月", "十二月" };

        //天干
        readonly string[] _gan = new string[] { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };
        //地支
        readonly string[] _zhi = new string[] { "子", "丑", "寅", "卯", "辰", "巳", "午", "未", "申", "酉", "戌", "亥" };
        //生肖
        readonly string[] _animals = new string[] { "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊", "猴", "鸡", "狗", "猪" };
        //节气
        readonly string[] _solarTerm = new string[] {"小寒","大寒","立春","雨水","惊蛰","春分","清明","谷雨","立夏","小满"
										  ,"芒种","夏至","小暑","大暑","立秋","处暑","白露","秋分","寒露","霜降"
										  ,"立冬","小雪","大雪","冬至"};
        //节气对应数值？
        readonly int[] _solarTermInfo = new int[] {0,21208,42467,63836,85337,107014,128867,150921,173149,195551,218072
										,240693,263343,285989,308563,331033,353350,375494,397447,419210,440795
										,462224,483532,504758};
        //农历日子
        readonly string[] _nStr1 = new string[] { "日", "一", "二", "三", "四", "五", "六", "七", "八", "九", "十" };
        readonly string[] _nStr2 = new string[] { "初", "十", "廿", "卅", "　" };
        //公历月份名称
        string[] _monthName = new string[] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

        #endregion

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public CCalendar() { }

        //传回农历 y 年的总天数
        private int GetLYearDays(int y)
        {
            int sum = 348;

            for (int i = 0x8000; i > 0x8; i >>= 1)
            {
                sum += ((lunarInfo[y - 1900] & i) > 0) ? 1 : 0;
            }

            return sum + GetLeapDays(y);
        }

        //传回农历 y 年 m 月的总天数 
        private int GetLMonthDays(int y, int m)
        {
            return (((lunarInfo[y - 1900] & (0x10000 >> m)) > 0) ? 30 : 29);
        }

        //传回农历 y 年闰哪个月 1-12 , 没闰传回 0
        private int GetLeapMonth(int y)
        {
            return (lunarInfo[y - 1900] & 0xf);
        }

        //传回农历 y 年闰月的天数
        private int GetLeapDays(int y)
        {
            if (GetLeapMonth(y) > 0)
            {
                return (((lunarInfo[y - 1900] & 0x10000) > 0) ? 30 : 29);
            }
            else
            {
                return 0;
            }
        }

        //得到农历日期
        private StructDate GetLunar(DateTime date)
        {
            StructDate sd;
            int i = 0;
            int leap = 0, temp = 0;
            DateTime baseDate = new DateTime(1900, 1, 31);	//基准时间
            int offset = (date - baseDate).Days;			//与基准时间相隔天数

            sd.DayCyl = offset + 40;
            sd.MonthCyl = 14;

            for (i = 1900; i < 2050 && offset > 0; i++)
            {
                temp = GetLYearDays(i);
                offset -= temp;
                sd.MonthCyl += 12;
            }
            if (offset < 0)
            {
                offset += temp;
                i--;
                sd.MonthCyl -= 12;
            }

            sd.Year = i;
            sd.YearCyl = i - 1864;

            //闰哪个月
            leap = GetLeapMonth(i);
            sd.IsLeap = false;
            for (i = 1; i < 13 && offset > 0; i++)
            {
                //闰月 
                if (leap > 0 && i == (leap + 1) && sd.IsLeap == false)
                {
                    --i;
                    sd.IsLeap = true;
                    temp = GetLeapDays(sd.Year);
                }
                else
                {
                    temp = GetLMonthDays(sd.Year, i);
                }
                //解除闰月 
                if (sd.IsLeap == true && i == (leap + 1))
                {
                    sd.IsLeap = false;
                }
                offset -= temp;
                if (sd.IsLeap == false)
                {
                    sd.MonthCyl++;
                }
            }
            if (offset == 0 && leap > 0 && i == leap + 1)
            {
                if (sd.IsLeap)
                {
                    sd.IsLeap = false;
                }
                else
                {
                    sd.IsLeap = true;
                    --i;
                    --sd.MonthCyl;
                }
            }
            if (offset < 0)
            {
                offset += temp;
                --i;
                --sd.MonthCyl;
            }

            sd.Month = i;
            sd.Day = offset + 1;

            return sd;
        }

        //传回公历 y 年 m 月的天数 
        private int SolarDays(int y, int m)
        {
            if (m == 2)
            {
                return (((y % 4 == 0) && (y % 100 != 0) || (y % 400 == 0)) ? 29 : 28);
            }
            else
            {
                return (_solarMonth[m]);
            }
        }

        //传入 offset 传回天干地支, 0=甲子 
        private string Cyclical(int num)
        {
            return (_gan[num % 10] + _zhi[num % 12]);
        }

        //某年的第n个节气为几日(从0,即小寒起算)
        //	n:节气下标
        private int GetSolarTermDay(int y, int n)
        {
            double minutes = 0;
            //1900年1月6日：小寒
            DateTime baseDate = new DateTime(1900, 1, 6, 2, 5, 0);
            minutes = 525948.766245 * (y - 1900) + _solarTermInfo[n - 1];

            DateTime veryDate = baseDate.AddMinutes(minutes);

            return veryDate.Day;
        }

        //农历日子 
        private string GetCDay(int d)
        {
            string s = "";

            switch (d)
            {
                case 10:
                    s = "初十";
                    break;
                case 20:
                    s = "二十";
                    break;
                case 30:
                    s = "三十";
                    break;
                default:
                    s = _nStr2[(int)System.Math.Floor((double)d / 10)];
                    s += _nStr1[d % 10];
                    break;
            }
            return (s);
        }

        /// <summary>
        /// 获取日期信息
        /// </summary>
        /// <param name="dt">待检查的日子。默认为 DateTime.Now</param>
        /// <returns>日期信息</returns>
        public StructDateFullInfo GetDateInfo(DateTime dt)
        {            
            string calendarXmlData = ReadFileFromEmbedded(CCalendarDateFile);

            StructDateFullInfo dayInfo;
            StructDate day = GetLunar(dt);

            dayInfo.IsLeap = day.IsLeap;

            dayInfo.Year = dt.Year;
            dayInfo.CYear = day.Year;
            dayInfo.ScYear = _animals[(day.Year - 4) % 12];
            dayInfo.CYearCyl = Cyclical(day.YearCyl);//干支年

            dayInfo.Month = dt.Month;
            dayInfo.CMonth = day.Month;
            dayInfo.ScMonth = _cMonthName[day.Month];
            dayInfo.CMonthCyl = Cyclical(day.MonthCyl);//干支月

            dayInfo.Day = dt.Day;
            dayInfo.CDay = day.Day;
            dayInfo.ScDay = GetCDay(day.Day);//日子
            dayInfo.CDayCyl = Cyclical(day.DayCyl);//干支日

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayInfo.DayInWeek = "星期日";
                    break;
                case DayOfWeek.Monday:
                    dayInfo.DayInWeek = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    dayInfo.DayInWeek = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    dayInfo.DayInWeek = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    dayInfo.DayInWeek = "星期四";
                    break;
                case DayOfWeek.Friday:
                    dayInfo.DayInWeek = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    dayInfo.DayInWeek = "星期六";
                    break;
                default:
                    dayInfo.DayInWeek = "星期？";
                    break;
            }

            //节气
            //每个月有两个节气
            int d1 = GetSolarTermDay(dt.Year, dt.Month * 2 - 1);
            int d2 = GetSolarTermDay(dt.Year, dt.Month * 2);
            if (dayInfo.Day == d1)
            {
                dayInfo.Solarterm = _solarTerm[dt.Month * 2 - 2];
            }
            else if (dayInfo.Day == d2)
            {
                dayInfo.Solarterm = _solarTerm[dt.Month * 2 - 1];
            }
            else
            {
                dayInfo.Solarterm = "";
            }

            //节日及问候语
            dayInfo.Info = "";
            dayInfo.Feast = "";
            dayInfo.Image = "";
            dayInfo.SayHello = false;
            XmlDocument feastdoc = new XmlDocument();
            feastdoc.LoadXml(calendarXmlData);

            //公历
            XmlNodeList nodeList = feastdoc.SelectNodes("descendant::AD/feast[@day='" + dt.ToString("MMdd") + "']");
            foreach (XmlNode root in nodeList)
            {
                dayInfo.Feast += root.Attributes["name"].InnerText + " ";
                if (root.Attributes["sayhello"].InnerText == "yes")
                {//需要显示节日问候语
                    dayInfo.Info = root["hello"].InnerText;
                    //看看是否需要计算周年
                    if (root["startyear"] != null)
                    {
                        int startyear = Convert.ToInt32(root["startyear"].InnerText);
                        dayInfo.Info = dayInfo.Info.Replace("_YEARS_", (dt.Year - startyear).ToString());
                    }
                    dayInfo.Image = root["img"].InnerText;
                    dayInfo.SayHello = true;
                }
            }

            //农历
            string smmdd = "";
            smmdd = (dayInfo.CMonth.ToString().Length == 2) ? dayInfo.CMonth.ToString() : ("0" + dayInfo.CMonth.ToString());
            smmdd += (dayInfo.CDay.ToString().Length == 2) ? dayInfo.CDay.ToString() : ("0" + dayInfo.CDay.ToString());
            XmlNode feast = feastdoc.SelectSingleNode("descendant::LUNAR/feast[@day='" + smmdd + "']");
            if (feast != null)
            {
                dayInfo.Feast += feast.Attributes["name"].InnerText;

                if (feast.Attributes["sayhello"].InnerText == "yes")
                {//需要显示节日问候语
                    dayInfo.Info += feast["hello"].InnerText;
                    dayInfo.Image = feast["img"].InnerText;
                    dayInfo.SayHello = true;
                }
            }
            //普通日子或没有庆贺语
            if (dayInfo.Info == "")
            {
                feast = feastdoc.SelectSingleNode("descendant::NORMAL/day[@time1<'" + dt.ToString("HHmm") + "']");
                if (feast != null)
                {
                    dayInfo.Info = feast["hello"].InnerText;
                    dayInfo.Image = feast["img"].InnerText;
                }
            }

            dayInfo.FullInfo = dayInfo.Year + "年" + dayInfo.Month + "月" + dayInfo.Day + "日";
            dayInfo.FullInfo += " " + dayInfo.DayInWeek;
            dayInfo.FullInfo += " 农历" + dayInfo.CYearCyl + "[" + dayInfo.ScYear + "]年";
            if (dayInfo.IsLeap)
            {
                dayInfo.FullInfo += " 闰";
            }
            dayInfo.FullInfo += " " + dayInfo.ScMonth + dayInfo.ScDay;
            if (dayInfo.Solarterm != "")
            {
                dayInfo.FullInfo += "  " + dayInfo.Solarterm;
            }

            return dayInfo;
        }

        /// <summary>
        /// 得到精简日期信息（不含节日）
        /// </summary>
        /// <param name="d">待检查的日子</param>
        /// <returns>日期信息</returns>
        public StructDateFullInfo GetDateTidyInfo(DateTime d)
        {
            StructDateFullInfo dayInfo;
            StructDate day = GetLunar(d);

            dayInfo.IsLeap = day.IsLeap;

            dayInfo.Year = d.Year;
            dayInfo.CYear = day.Year;
            dayInfo.ScYear = _animals[(day.Year - 4) % 12];
            dayInfo.CYearCyl = Cyclical(day.YearCyl);//干支年

            dayInfo.Month = d.Month;
            dayInfo.CMonth = day.Month;
            dayInfo.ScMonth = _cMonthName[day.Month];
            dayInfo.CMonthCyl = Cyclical(day.MonthCyl);//干支月

            dayInfo.Day = d.Day;
            dayInfo.CDay = day.Day;
            dayInfo.ScDay = GetCDay(day.Day);//日子
            dayInfo.CDayCyl = Cyclical(day.DayCyl);//干支日

            switch (d.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayInfo.DayInWeek = "星期日";
                    break;
                case DayOfWeek.Monday:
                    dayInfo.DayInWeek = "星期一";
                    break;
                case DayOfWeek.Tuesday:
                    dayInfo.DayInWeek = "星期二";
                    break;
                case DayOfWeek.Wednesday:
                    dayInfo.DayInWeek = "星期三";
                    break;
                case DayOfWeek.Thursday:
                    dayInfo.DayInWeek = "星期四";
                    break;
                case DayOfWeek.Friday:
                    dayInfo.DayInWeek = "星期五";
                    break;
                case DayOfWeek.Saturday:
                    dayInfo.DayInWeek = "星期六";
                    break;
                default:
                    dayInfo.DayInWeek = "星期？";
                    break;
            }

            dayInfo.Info = "";
            dayInfo.Feast = "";
            dayInfo.Image = "";
            dayInfo.SayHello = false;

            //节气
            //每个月有两个节气
            int d1 = GetSolarTermDay(d.Year, d.Month * 2 - 1);
            int d2 = GetSolarTermDay(d.Year, d.Month * 2);
            if (dayInfo.Day == d1)
            {
                dayInfo.Solarterm = _solarTerm[d.Month * 2 - 2];
            }
            else if (dayInfo.Day == d2)
            {
                dayInfo.Solarterm = _solarTerm[d.Month * 2 - 1];
            }
            else
            {
                dayInfo.Solarterm = "";
            }

            dayInfo.FullInfo = dayInfo.Year + "年" + dayInfo.Month + "月" + dayInfo.Day + "日";
            dayInfo.FullInfo += " " + dayInfo.DayInWeek;
            dayInfo.FullInfo += " 农历" + dayInfo.CYearCyl + "（" + dayInfo.ScYear + "）年";
            if (dayInfo.IsLeap)
            {
                dayInfo.FullInfo += "闰";
            }
            dayInfo.FullInfo += " " + dayInfo.ScMonth + dayInfo.ScDay;
            if (dayInfo.Solarterm != "")
            {
                dayInfo.FullInfo += " " + dayInfo.Solarterm;
            }

            return dayInfo;
        }

        /// <summary>
        /// 从嵌入资源中读取文件内容(e.g: xml).
        /// </summary>
        /// <param name="fileWholeName">嵌入资源文件名，包括项目的命名空间以及文件的存储路径</param>
        /// <returns>资源中的文件内容.</returns>
        private string ReadFileFromEmbedded(string fileWholeName)
        {
            string result;

            using(TextReader reader = new StreamReader(
                Assembly.GetExecutingAssembly().GetManifestResourceStream(fileWholeName)))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
    }
}
