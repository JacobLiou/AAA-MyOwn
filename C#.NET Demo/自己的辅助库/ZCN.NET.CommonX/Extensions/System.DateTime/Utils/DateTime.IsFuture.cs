using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ��������ʱ���Ƿ���δ��(����DateTime.Now)
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns></returns>
        public static bool IsFuture(this DateTime @this)
        {
            return @this > DateTime.Now;
        }
    }
}