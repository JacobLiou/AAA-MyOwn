using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ�������������ڵĵ�һ��ĵ�һ�̣�ʱ������Ϊ��00:00:00:000��
        /// </summary>
        /// <param name="dt">��չ��������ʱ��</param>
        /// <param name="startDayOfWeek">һ�ܿ�ʼ�ĵ�һ��</param>
        /// <returns></returns>
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startDayOfWeek = DayOfWeek.Sunday)
        {
            var start = new DateTime(dt.Year, dt.Month, dt.Day);

            if(start.DayOfWeek != startDayOfWeek)
            {
                int d = startDayOfWeek - start.DayOfWeek;
                if(startDayOfWeek <= start.DayOfWeek)
                {
                    return start.AddDays(d);
                }
                return start.AddDays(-7 + d);
            }

            return start;
        }
    }
}