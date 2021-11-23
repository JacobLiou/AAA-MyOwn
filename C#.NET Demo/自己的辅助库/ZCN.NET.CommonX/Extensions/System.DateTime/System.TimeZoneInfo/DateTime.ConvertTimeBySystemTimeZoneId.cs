using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ʱ����ʶ����ʱ��ת��Ϊ��һʱ���е�ʱ��
        /// </summary>
        /// <param name="dateTime">��չ��������ʱ��</param>
        /// <param name="destinationTimeZoneId">Ŀ��ʱ���ı�ʶ��</param>
        /// <returns></returns>
        public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime, String destinationTimeZoneId)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, destinationTimeZoneId);
        }

        /// <summary>
        /// �Զ�����չ����������ʱ����ʶ����ʱ���һ��ʱ��ת������һ��ʱ��
        /// </summary>
        /// <param name="dateTime">��չ��������ʱ��</param>
        /// <param name="sourceTimeZoneId">Դʱ���ı�ʶ��</param>
        /// <param name="destinationTimeZoneId">Ŀ��ʱ���ı�ʶ��</param>
        /// <returns></returns>
        public static DateTime ConvertTimeBySystemTimeZoneId(this DateTime dateTime,
            String sourceTimeZoneId,
            String destinationTimeZoneId)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, sourceTimeZoneId, destinationTimeZoneId);
        }
    }
}