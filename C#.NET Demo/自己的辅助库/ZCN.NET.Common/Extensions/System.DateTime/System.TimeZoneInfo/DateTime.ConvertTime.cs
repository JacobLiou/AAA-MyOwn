using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ʱ��ת��Ϊ�ض�ʱ����ʱ��
        /// </summary>
        /// <param name="dateTime">��չ��������ʱ��</param>
        /// <param name="destinationTimeZone">Ŀ��ʱ��</param>
        /// <returns></returns>
        public static DateTime ConvertTime(this DateTime dateTime,TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTime,destinationTimeZone);
        }

        /// <summary>
        /// �Զ�����չ��������ʱ���һ��ʱ��ת��Ϊ��һ��ʱ��
        /// </summary>
        /// <param name="dateTime">��չ��������ʱ��</param>
        /// <param name="sourceTimeZone">Դʱ��</param>
        /// <param name="destinationTimeZone">Ŀ��ʱ��</param>
        /// <returns></returns>
        public static DateTime ConvertTime(this DateTime dateTime,
            TimeZoneInfo sourceTimeZone,
            TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTime,sourceTimeZone,destinationTimeZone);
        }
    }
}