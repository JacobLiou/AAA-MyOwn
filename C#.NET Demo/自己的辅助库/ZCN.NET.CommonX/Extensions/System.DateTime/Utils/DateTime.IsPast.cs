using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ��������ʱ���Ƿ��ǹ�ȥ(С��DateTime.Now)
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns></returns>
        public static bool IsPast(this DateTime @this)
        {
            return @this < DateTime.Now;
        }
    }
}