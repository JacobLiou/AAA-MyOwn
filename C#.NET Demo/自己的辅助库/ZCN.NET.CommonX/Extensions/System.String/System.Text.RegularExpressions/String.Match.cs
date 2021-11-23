using System.Text.RegularExpressions;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ��ָ���������ַ���������ָ����������ʽ�ĵ�һ��ƥ����
        /// </summary>
        /// <param name="input">Ҫ����ƥ������ַ���</param>
        /// <param name="pattern">Ҫƥ���������ʽģʽ</param>
        /// <returns>һ�����󣬰����й�ƥ�������Ϣ</returns>
        public static Match Match(this string input, string pattern)
        {
            return Regex.Match(input, pattern);
        }

        /// <summary>
        ///  �Զ�����չ������ ��ָ���������ַ���������ָ����������ʽ�ĵ�һ��ƥ����
        /// </summary>
        /// <param name="input">Ҫ����ƥ������ַ���</param>
        /// <param name="pattern">Ҫƥ���������ʽģʽ</param>
        /// <param name="options">ö��ֵ��һ����λ��ϣ���Щö��ֵ�ṩƥ��ѡ��</param>
        /// <returns>һ�����󣬰����й�ƥ�������Ϣ</returns>
        public static Match Match(this string input, string pattern, RegexOptions options)
        {
            return Regex.Match(input, pattern, options);
        }
    }
}