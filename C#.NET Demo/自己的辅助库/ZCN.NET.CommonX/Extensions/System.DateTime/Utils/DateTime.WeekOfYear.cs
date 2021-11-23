using System;
using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ����������һ���еĵڼ���
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="cultureInfo">�����Զ������磺new CultureInfo("zh-CN")</param>
        /// <returns></returns>
        public static int WeekOfYear(this DateTime @this, CultureInfo cultureInfo)
        {
            return cultureInfo.Calendar.GetWeekOfYear(@this, cultureInfo.DateTimeFormat.CalendarWeekRule, cultureInfo.DateTimeFormat.FirstDayOfWeek);
        }
    }
}