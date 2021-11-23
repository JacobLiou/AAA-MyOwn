using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�һ�������Ƿ���һ���µ����һ��
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns></returns>
        public static bool IsLastDayOfMonth(this DateTime @this)
        {
            int lastDayOfMonth = DaysCountOfMonth(@this);
            return lastDayOfMonth == @this.Day;
        }

        /// <summary>
        /// �Զ�����չ����������ÿ���µ�����
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static int DaysCountOfMonth(this DateTime instance)
        {
            if(IsLeapYear(instance) && instance.Month == 2)
                return 29;

            if(instance.Month == 2)
                return 28;

            if(instance.Month == 1 ||
                instance.Month == 3 ||
                instance.Month == 5 ||
                instance.Month == 7 ||
                instance.Month == 8 ||
                instance.Month == 10 ||
                instance.Month == 12)
                return 31;

            return 30;
        }
    }
}