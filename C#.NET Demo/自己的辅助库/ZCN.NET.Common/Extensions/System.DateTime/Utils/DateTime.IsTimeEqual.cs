using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�2��ʱ���Ƿ����
        /// </summary>
        /// <param name="time">��չ��������ʱ��</param>
        /// <param name="timeToCompare">Ŀ������ʱ��</param>
        /// <returns></returns>
        public static bool IsTimeEqual(this DateTime time, DateTime timeToCompare)
        {
            return (time.TimeOfDay == timeToCompare.TimeOfDay);
        }
    }
}