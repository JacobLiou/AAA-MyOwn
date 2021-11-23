using System;
using System.Collections.Generic;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ�����ں�ʱ���Ƿ���ָ������ʱ���ڼ�
        /// </summary>
        /// <param name="time">��չ��������ʱ��</param>
        /// <param name="daylightTimes">��ʱ���ڼ�</param>
        /// <returns></returns>
        public static bool IsDaylightSavingTime(this DateTime time, DaylightTime daylightTimes)
        {
            List<int> lstInt = new List<int>();
            List<string> lstStr = new List<string>();

            return TimeZone.IsDaylightSavingTime(time, daylightTimes);
        }
    }
}