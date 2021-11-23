using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���������Ƿ�����������
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns></returns>
        public static bool IsWeekendDay(this DateTime @this)
        {
            return (@this.DayOfWeek == DayOfWeek.Saturday||@this.DayOfWeek == DayOfWeek.Sunday);
        }
    }
}