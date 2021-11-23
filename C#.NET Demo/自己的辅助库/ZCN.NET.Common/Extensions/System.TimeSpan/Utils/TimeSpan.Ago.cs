using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ �ӵ�ǰ����ʱ���ȥָ����TimeSpan
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static DateTime Ago(this TimeSpan @this)
        {
            return DateTime.Now.Subtract(@this);
        }
    }
}