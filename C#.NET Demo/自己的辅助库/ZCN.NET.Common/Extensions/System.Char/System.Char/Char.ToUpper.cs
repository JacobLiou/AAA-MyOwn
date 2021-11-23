using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ���������ض���ʽ������Ϣ��ָ�� Unicode �ַ���ֵת��Ϊ���Ĵ�д��Ч��
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <param name="culture">�ṩ�������ض��Ĵ�Сд����Ķ��󣬻� null</param>
        /// <returns></returns>
        public static char ToUpper(this char c,CultureInfo culture)
        {
            return char.ToUpper(c,culture);
        }

        /// <summary>
        /// �Զ�����չ�������� Unicode �ַ���ֵת��Ϊ���Ĵ�д��Ч��
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static char ToUpper(this char c)
        {
            return char.ToUpper(c);
        }

        /// <summary>
        /// �Զ�����չ������ʹ�ù̶������ԵĴ�Сд���򣬽� Unicode �ַ���ֵת��Ϊ���д��Ч��
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static char ToUpperInvariant(this char c)
        {
            return char.ToUpperInvariant(c);
        }
    }
}