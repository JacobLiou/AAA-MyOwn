using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ �ӵ�ǰ����ʱ��(UTCЭ������ʱ��)����ָ����TimeSpan
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static DateTime UtcFromNow(this TimeSpan @this)
        {
            return DateTime.UtcNow.Add(@this);
        }
    }
}