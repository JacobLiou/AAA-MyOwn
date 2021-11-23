using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������Э������ʱ (UTC) ת��Ϊָ��ʱ���е�ʱ��
        /// </summary>
        /// <param name="dateTime">��չ��������ʱ��</param>
        /// <param name="destinationTimeZone"></param>
        /// <returns></returns>
        public static DateTime ConvertTimeFromUtc(this DateTime dateTime, TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, destinationTimeZone);
        }
    }
}