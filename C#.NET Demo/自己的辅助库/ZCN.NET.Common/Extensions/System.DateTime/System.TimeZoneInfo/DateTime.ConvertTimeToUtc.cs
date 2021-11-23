using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ����ǰ���ں�ʱ��ת��ΪЭ������ʱ (UTC)
        /// </summary>
        /// <param name="dateTime">��չ��������ʱ��</param>
        /// <returns></returns>
        public static DateTime ConvertTimeToUtc(this DateTime dateTime)
        {
            return TimeZoneInfo.ConvertTimeToUtc(dateTime);
        }

        /// <summary>
        /// �Զ�����չ��������ָ��ʱ���е�ʱ��ת��ΪЭ������ʱ (UTC)
        /// </summary>
        /// <param name="dateTime">��չ��������ʱ��</param>
        /// <param name="sourceTimeZone">Ŀ��ʱ��</param>
        /// <returns></returns>
        public static DateTime ConvertTimeToUtc(this DateTime dateTime,TimeZoneInfo sourceTimeZone)
        {
            return TimeZoneInfo.ConvertTimeToUtc(dateTime,sourceTimeZone);
        }
    }
}