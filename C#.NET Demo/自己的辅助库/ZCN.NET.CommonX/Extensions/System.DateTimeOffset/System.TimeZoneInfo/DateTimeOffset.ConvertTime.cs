using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ʱ��ת��Ϊ�ض�ʱ����ʱ��
        /// </summary>
        /// <param name="dateTimeOffset">��չ����Ҫת�������ں�ʱ��</param>
        /// <param name="destinationTimeZone">Ҫ�� dateTime ת������ʱ��</param>
        /// <returns>Ŀ��ʱ�������ں�ʱ��</returns>
        public static DateTimeOffset ConvertTime(this DateTimeOffset dateTimeOffset, TimeZoneInfo destinationTimeZone)
        {
            return TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone);
        }
    }
}