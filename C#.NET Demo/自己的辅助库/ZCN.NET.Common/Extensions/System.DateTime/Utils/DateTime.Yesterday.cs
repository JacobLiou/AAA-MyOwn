using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���������Ƿ�������
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static DateTime Yesterday(this DateTime @this)
        {
            return @this.AddDays(-1);
        }
    }
}