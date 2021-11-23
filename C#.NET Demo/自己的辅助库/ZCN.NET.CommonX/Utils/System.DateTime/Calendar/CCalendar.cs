using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ZCN.NET.CommonX.Extensions
{
    /// <summary>
    ///	 ������ʾ����ʱ�䡢ũ������Ф��������
    /// </summary>
    public class CCalendar
    {
        /// <summary>
        /// �Զ����CCalendarDate.XML���޶����ƣ������ռ��޸ģ�����Ҳ�����޸ģ�
        /// �Ҽ��鿴CCalendarData.xml�ļ������Կ��Կ������������ռ䡣
        /// ��������ΪǶ�����Դ
        /// </summary>
        const string CCalendarDateFile = "ZCN.NET.CommonX.Utils.System.DateTime.Calendar.CCalendarData.xml";

        /// <summary>
        /// �ṹ�����ڶ���
        /// </summary>
        struct StructDate
        {
            public int Year;
            public int Month;
            public int Day;
            public bool IsLeap;			//�Ƿ�����
            public int YearCyl;			//���֧
            public int MonthCyl;		//�¸�֧
            public int DayCyl;			//�ո�֧
        }

        /// <summary>
        /// �ṹ�����������ڶ���
        /// </summary>
        public struct StructDateFullInfo
        {
            /// <summary>
            /// ������
            /// </summary>
            public int Year;

            /// <summary>
            /// ������
            /// </summary>
            public int Month;

            /// <summary>
            /// ������
            /// </summary>
            public int Day;

            /// <summary>
            /// �Ƿ�����
            /// </summary>
            public bool IsLeap;			//�Ƿ�����

            /// <summary>
            /// ũ����
            /// </summary>
            public int CYear;			//ũ����

            /// <summary>
            /// ũ��������
            /// </summary>
            public string ScYear;		//ũ��������

            /// <summary>
            /// ��֧
            /// </summary>
            public string CYearCyl;		//��֧��

            /// <summary>
            /// ũ����
            /// </summary>
            public int CMonth;			//ũ����

            /// <summary>
            /// ũ��������
            /// </summary>
            public string ScMonth;		//ũ��������

            /// <summary>
            /// ��֧��
            /// </summary>
            public string CMonthCyl;	//��֧��

            /// <summary>
            /// ũ����
            /// </summary>
            public int CDay;			//ũ����

            /// <summary>
            /// ũ��������
            /// </summary>
            public string ScDay;		//ũ��������

            /// <summary>
            /// ��֧��
            /// </summary>
            public string CDayCyl;		//��֧��

            /// <summary>
            /// ����
            /// </summary>
            public string Solarterm;	//����

            /// <summary>
            /// ���ڼ�
            /// </summary>
            public string DayInWeek;	//���ڼ�

            /// <summary>
            /// ����
            /// </summary>
            public string Feast;		//����

            /// <summary>
            /// ϵͳ�ʺ���
            /// </summary>
            public string Info;			//ϵͳ�ʺ���

            /// <summary>
            /// ����ͼƬ
            /// </summary>
            public string Image;	    //����ͼƬ

            /// <summary>
            /// ������������Ϣ
            /// </summary>
            public string FullInfo;		//������������Ϣ

            /// <summary>
            /// ���ر���ʺ�����
            /// </summary>
            public bool SayHello;		//���ر���ʺ�����
        }

        #region ũ���������

        //ũ���·���Ϣ
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
        //�����·�
        readonly int[] _solarMonth = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        readonly string[] _cMonthName = new string[] { "", "����", "����", "����", "����", "����", "����", "����", "����", "����", "ʮ��", "ʮһ��", "ʮ����" };

        //���
        readonly string[] _gan = new string[] { "��", "��", "��", "��", "��", "��", "��", "��", "��", "��" };
        //��֧
        readonly string[] _zhi = new string[] { "��", "��", "��", "î", "��", "��", "��", "δ", "��", "��", "��", "��" };
        //��Ф
        readonly string[] _animals = new string[] { "��", "ţ", "��", "��", "��", "��", "��", "��", "��", "��", "��", "��" };
        //����
        readonly string[] _solarTerm = new string[] {"С��","��","����","��ˮ","����","����","����","����","����","С��"
										  ,"â��","����","С��","����","����","����","��¶","���","��¶","˪��"
										  ,"����","Сѩ","��ѩ","����"};
        //������Ӧ��ֵ��
        readonly int[] _solarTermInfo = new int[] {0,21208,42467,63836,85337,107014,128867,150921,173149,195551,218072
										,240693,263343,285989,308563,331033,353350,375494,397447,419210,440795
										,462224,483532,504758};
        //ũ������
        readonly string[] _nStr1 = new string[] { "��", "һ", "��", "��", "��", "��", "��", "��", "��", "��", "ʮ" };
        readonly string[] _nStr2 = new string[] { "��", "ʮ", "إ", "ئ", "��" };
        //�����·�����
        string[] _monthName = new string[] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

        #endregion

        /// <summary>
        /// Ĭ�Ϲ��캯��
        /// </summary>
        public CCalendar() { }

        //����ũ�� y ���������
        private int GetLYearDays(int y)
        {
            int sum = 348;

            for (int i = 0x8000; i > 0x8; i >>= 1)
            {
                sum += ((lunarInfo[y - 1900] & i) > 0) ? 1 : 0;
            }

            return sum + GetLeapDays(y);
        }

        //����ũ�� y �� m �µ������� 
        private int GetLMonthDays(int y, int m)
        {
            return (((lunarInfo[y - 1900] & (0x10000 >> m)) > 0) ? 30 : 29);
        }

        //����ũ�� y �����ĸ��� 1-12 , û�򴫻� 0
        private int GetLeapMonth(int y)
        {
            return (lunarInfo[y - 1900] & 0xf);
        }

        //����ũ�� y �����µ�����
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

        //�õ�ũ������
        private StructDate GetLunar(DateTime date)
        {
            StructDate sd;
            int i = 0;
            int leap = 0, temp = 0;
            DateTime baseDate = new DateTime(1900, 1, 31);	//��׼ʱ��
            int offset = (date - baseDate).Days;			//���׼ʱ���������

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

            //���ĸ���
            leap = GetLeapMonth(i);
            sd.IsLeap = false;
            for (i = 1; i < 13 && offset > 0; i++)
            {
                //���� 
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
                //������� 
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

        //���ع��� y �� m �µ����� 
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

        //���� offset ������ɵ�֧, 0=���� 
        private string Cyclical(int num)
        {
            return (_gan[num % 10] + _zhi[num % 12]);
        }

        //ĳ��ĵ�n������Ϊ����(��0,��С������)
        //	n:�����±�
        private int GetSolarTermDay(int y, int n)
        {
            double minutes = 0;
            //1900��1��6�գ�С��
            DateTime baseDate = new DateTime(1900, 1, 6, 2, 5, 0);
            minutes = 525948.766245 * (y - 1900) + _solarTermInfo[n - 1];

            DateTime veryDate = baseDate.AddMinutes(minutes);

            return veryDate.Day;
        }

        //ũ������ 
        private string GetCDay(int d)
        {
            string s = "";

            switch (d)
            {
                case 10:
                    s = "��ʮ";
                    break;
                case 20:
                    s = "��ʮ";
                    break;
                case 30:
                    s = "��ʮ";
                    break;
                default:
                    s = _nStr2[(int)System.Math.Floor((double)d / 10)];
                    s += _nStr1[d % 10];
                    break;
            }
            return (s);
        }

        /// <summary>
        /// ��ȡ������Ϣ
        /// </summary>
        /// <param name="dt">���������ӡ�Ĭ��Ϊ DateTime.Now</param>
        /// <returns>������Ϣ</returns>
        public StructDateFullInfo GetDateInfo(DateTime dt)
        {            
            string calendarXmlData = ReadFileFromEmbedded(CCalendarDateFile);

            StructDateFullInfo dayInfo;
            StructDate day = GetLunar(dt);

            dayInfo.IsLeap = day.IsLeap;

            dayInfo.Year = dt.Year;
            dayInfo.CYear = day.Year;
            dayInfo.ScYear = _animals[(day.Year - 4) % 12];
            dayInfo.CYearCyl = Cyclical(day.YearCyl);//��֧��

            dayInfo.Month = dt.Month;
            dayInfo.CMonth = day.Month;
            dayInfo.ScMonth = _cMonthName[day.Month];
            dayInfo.CMonthCyl = Cyclical(day.MonthCyl);//��֧��

            dayInfo.Day = dt.Day;
            dayInfo.CDay = day.Day;
            dayInfo.ScDay = GetCDay(day.Day);//����
            dayInfo.CDayCyl = Cyclical(day.DayCyl);//��֧��

            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Monday:
                    dayInfo.DayInWeek = "����һ";
                    break;
                case DayOfWeek.Tuesday:
                    dayInfo.DayInWeek = "���ڶ�";
                    break;
                case DayOfWeek.Wednesday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Thursday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Friday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Saturday:
                    dayInfo.DayInWeek = "������";
                    break;
                default:
                    dayInfo.DayInWeek = "���ڣ�";
                    break;
            }

            //����
            //ÿ��������������
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

            //���ռ��ʺ���
            dayInfo.Info = "";
            dayInfo.Feast = "";
            dayInfo.Image = "";
            dayInfo.SayHello = false;
            XmlDocument feastdoc = new XmlDocument();
            feastdoc.LoadXml(calendarXmlData);

            //����
            XmlNodeList nodeList = feastdoc.SelectNodes("descendant::AD/feast[@day='" + dt.ToString("MMdd") + "']");
            foreach (XmlNode root in nodeList)
            {
                dayInfo.Feast += root.Attributes["name"].InnerText + " ";
                if (root.Attributes["sayhello"].InnerText == "yes")
                {//��Ҫ��ʾ�����ʺ���
                    dayInfo.Info = root["hello"].InnerText;
                    //�����Ƿ���Ҫ��������
                    if (root["startyear"] != null)
                    {
                        int startyear = Convert.ToInt32(root["startyear"].InnerText);
                        dayInfo.Info = dayInfo.Info.Replace("_YEARS_", (dt.Year - startyear).ToString());
                    }
                    dayInfo.Image = root["img"].InnerText;
                    dayInfo.SayHello = true;
                }
            }

            //ũ��
            string smmdd = "";
            smmdd = (dayInfo.CMonth.ToString().Length == 2) ? dayInfo.CMonth.ToString() : ("0" + dayInfo.CMonth.ToString());
            smmdd += (dayInfo.CDay.ToString().Length == 2) ? dayInfo.CDay.ToString() : ("0" + dayInfo.CDay.ToString());
            XmlNode feast = feastdoc.SelectSingleNode("descendant::LUNAR/feast[@day='" + smmdd + "']");
            if (feast != null)
            {
                dayInfo.Feast += feast.Attributes["name"].InnerText;

                if (feast.Attributes["sayhello"].InnerText == "yes")
                {//��Ҫ��ʾ�����ʺ���
                    dayInfo.Info += feast["hello"].InnerText;
                    dayInfo.Image = feast["img"].InnerText;
                    dayInfo.SayHello = true;
                }
            }
            //��ͨ���ӻ�û�������
            if (dayInfo.Info == "")
            {
                feast = feastdoc.SelectSingleNode("descendant::NORMAL/day[@time1<'" + dt.ToString("HHmm") + "']");
                if (feast != null)
                {
                    dayInfo.Info = feast["hello"].InnerText;
                    dayInfo.Image = feast["img"].InnerText;
                }
            }

            dayInfo.FullInfo = dayInfo.Year + "��" + dayInfo.Month + "��" + dayInfo.Day + "��";
            dayInfo.FullInfo += " " + dayInfo.DayInWeek;
            dayInfo.FullInfo += " ũ��" + dayInfo.CYearCyl + "[" + dayInfo.ScYear + "]��";
            if (dayInfo.IsLeap)
            {
                dayInfo.FullInfo += " ��";
            }
            dayInfo.FullInfo += " " + dayInfo.ScMonth + dayInfo.ScDay;
            if (dayInfo.Solarterm != "")
            {
                dayInfo.FullInfo += "  " + dayInfo.Solarterm;
            }

            return dayInfo;
        }

        /// <summary>
        /// �õ�����������Ϣ���������գ�
        /// </summary>
        /// <param name="d">����������</param>
        /// <returns>������Ϣ</returns>
        public StructDateFullInfo GetDateTidyInfo(DateTime d)
        {
            StructDateFullInfo dayInfo;
            StructDate day = GetLunar(d);

            dayInfo.IsLeap = day.IsLeap;

            dayInfo.Year = d.Year;
            dayInfo.CYear = day.Year;
            dayInfo.ScYear = _animals[(day.Year - 4) % 12];
            dayInfo.CYearCyl = Cyclical(day.YearCyl);//��֧��

            dayInfo.Month = d.Month;
            dayInfo.CMonth = day.Month;
            dayInfo.ScMonth = _cMonthName[day.Month];
            dayInfo.CMonthCyl = Cyclical(day.MonthCyl);//��֧��

            dayInfo.Day = d.Day;
            dayInfo.CDay = day.Day;
            dayInfo.ScDay = GetCDay(day.Day);//����
            dayInfo.CDayCyl = Cyclical(day.DayCyl);//��֧��

            switch (d.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Monday:
                    dayInfo.DayInWeek = "����һ";
                    break;
                case DayOfWeek.Tuesday:
                    dayInfo.DayInWeek = "���ڶ�";
                    break;
                case DayOfWeek.Wednesday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Thursday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Friday:
                    dayInfo.DayInWeek = "������";
                    break;
                case DayOfWeek.Saturday:
                    dayInfo.DayInWeek = "������";
                    break;
                default:
                    dayInfo.DayInWeek = "���ڣ�";
                    break;
            }

            dayInfo.Info = "";
            dayInfo.Feast = "";
            dayInfo.Image = "";
            dayInfo.SayHello = false;

            //����
            //ÿ��������������
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

            dayInfo.FullInfo = dayInfo.Year + "��" + dayInfo.Month + "��" + dayInfo.Day + "��";
            dayInfo.FullInfo += " " + dayInfo.DayInWeek;
            dayInfo.FullInfo += " ũ��" + dayInfo.CYearCyl + "��" + dayInfo.ScYear + "����";
            if (dayInfo.IsLeap)
            {
                dayInfo.FullInfo += "��";
            }
            dayInfo.FullInfo += " " + dayInfo.ScMonth + dayInfo.ScDay;
            if (dayInfo.Solarterm != "")
            {
                dayInfo.FullInfo += " " + dayInfo.Solarterm;
            }

            return dayInfo;
        }

        /// <summary>
        /// ��Ƕ����Դ�ж�ȡ�ļ�����(e.g: xml).
        /// </summary>
        /// <param name="fileWholeName">Ƕ����Դ�ļ�����������Ŀ�������ռ��Լ��ļ��Ĵ洢·��</param>
        /// <returns>��Դ�е��ļ�����.</returns>
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
