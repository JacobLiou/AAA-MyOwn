using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������������չ�����ֵ�뵱ǰʱ���ʱ����
        /// </summary>
        /// <param name="datetime">��չ��������ʱ��</param>
        /// <returns></returns>
        public static TimeSpan Elapsed(this DateTime datetime)
        {
            return DateTime.Now - datetime;
        }
    }
}