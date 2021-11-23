using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ж��ַ������Ƿ񲻰���ָ�����ַ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="value">�ַ���</param>
        /// <returns>����������true����������false</returns>
        public static bool NotContains(this string @this, string value)
        {
            return @this.Contains(value) == false;
        }

        /// <summary>
        ///  �Զ�����չ�������ж��ַ������Ƿ������ָ�����ַ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="value">�ַ���</param>
        /// <param name="comparisonType">ָ�����������ö��ֵ֮һ</param>
        /// <returns>����������true����������false</returns>
        public static bool NotContains(this string @this, string value, StringComparison comparisonType)
        {
            return @this.IndexOf(value, comparisonType) == -1;
        }
    }
}