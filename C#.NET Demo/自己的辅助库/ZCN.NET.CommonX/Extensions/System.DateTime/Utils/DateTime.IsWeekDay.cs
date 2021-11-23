using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���������Ƿ��ǹ�����(��һ������)
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns></returns>
        public static bool IsWeekDay(this DateTime @this)
        {
            return !(@this.DayOfWeek == DayOfWeek.Saturday || @this.DayOfWeek == DayOfWeek.Sunday);
        }
    }
}