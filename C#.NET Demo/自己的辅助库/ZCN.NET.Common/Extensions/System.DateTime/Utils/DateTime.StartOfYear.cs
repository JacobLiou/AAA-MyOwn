using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ������������ĵ�һ���µĵ�һ��ĵ�һ�̣�ʱ������Ϊ��00:00:00:000��
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static DateTime StartOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1);
        }
    }
}