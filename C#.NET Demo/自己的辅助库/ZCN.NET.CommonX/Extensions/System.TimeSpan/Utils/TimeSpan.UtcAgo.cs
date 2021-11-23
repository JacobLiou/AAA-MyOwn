using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ �ӵ�ǰ����ʱ��(UTCЭ������ʱ��)��ȥָ����TimeSpan
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static DateTime UtcAgo(this TimeSpan @this)
        {
            return DateTime.UtcNow.Subtract(@this);
        }
    }
}