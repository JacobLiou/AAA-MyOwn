using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ر�ʾָ���������� System.TimeSpan
        /// </summary>
        /// <param name="value">��չ���󡣺�����</param>
        /// <returns></returns>
        public static TimeSpan FromMilliseconds(this double value)
        {
            return TimeSpan.FromMilliseconds(value);
        }
    }
}