using System;
using System.Text.RegularExpressions;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �ж���ָ����������ʽ��ָ���������ַ������Ƿ��ҵ���ƥ����
        /// </summary>
        /// <param name="input">Ҫ����ƥ������ַ���</param>
        /// <param name="pattern">Ҫƥ���������ʽģʽ</param>
        /// <returns>���������ʽ�ҵ�ƥ�����Ϊ true������Ϊ false</returns>
        public static Boolean IsMatch(this string input, string pattern)
        {
            return Regex.IsMatch(input, pattern);
        }

        /// <summary>
        /// �Զ�����չ������ �ж���ָ����������ʽ��ָ���������ַ������Ƿ��ҵ���ƥ����
        /// </summary>
        /// <param name="input">Ҫ����ƥ������ַ���</param>
        /// <param name="pattern">Ҫƥ���������ʽģʽ</param>
        /// <param name="options">Ҫƥ���������ʽģʽ</param>
        /// <returns>���������ʽ�ҵ�ƥ�����Ϊ true������Ϊ false</returns>
        public static Boolean IsMatch(this string input, string pattern, RegexOptions options)
        {
            return Regex.IsMatch(input, pattern, options);
        }
    }
}