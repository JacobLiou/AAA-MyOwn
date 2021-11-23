using System.Text.RegularExpressions;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ���������ַ���������ָ����������ʽ������ƥ����
        /// </summary>
        /// <param name="input">Ҫ����ƥ������ַ���</param>
        /// <param name="pattern">Ҫƥ���������ʽģʽ</param>
        /// <returns>���������ҵ��� System.Text.RegularExpressions.Match ����ļ���</returns>
        public static MatchCollection Matches(this string input, string pattern)
        {
            return Regex.Matches(input, pattern);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���������ַ���������ָ����������ʽ������ƥ����
        /// </summary>
        /// <param name="input">Ҫ����ƥ������ַ���</param>
        /// <param name="pattern">Ҫƥ���������ʽģʽ</param>
        /// <param name="options">ö��ֵ��һ����λ��ϣ���Щö��ֵ�ṩƥ��ѡ��</param>
        /// <returns>���������ҵ��� System.Text.RegularExpressions.Match ����ļ���</returns>
        public static MatchCollection Matches(this string input, string pattern, RegexOptions options)
        {
            return Regex.Matches(input, pattern, options);
        }
    }
}