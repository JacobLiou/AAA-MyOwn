using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ʱ����ʶ����ʱ��ת��Ϊ��һʱ���е�ʱ��
        /// </summary>
        /// <param name="dateTimeOffset">��չ����Ҫת�������ں�ʱ��</param>
        /// <param name="destinationTimeZoneId">Ŀ��ʱ���ı�ʶ��</param>
        /// <returns>Ŀ��ʱ�������ں�ʱ��</returns>
        public static DateTimeOffset ConvertTimeBySystemTimeZoneId(this DateTimeOffset dateTimeOffset,
            String destinationTimeZoneId)
        {
            return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId);
        }
    }
}