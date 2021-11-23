using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ�� Unicode �ַ����ൽ��ĳ�� System.Globalization.UnicodeCategory ֵ��ʶ������
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static UnicodeCategory GetUnicodeCategory(this char c)
        {
            return char.GetUnicodeCategory(c);
        }
    }
}