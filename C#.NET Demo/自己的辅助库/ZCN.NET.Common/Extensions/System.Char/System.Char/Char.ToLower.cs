using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ���������ض���ʽ������Ϣ��ָ�� Unicode �ַ���ֵת��Ϊ����Сд��Ч��
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <param name="culture">�ṩ�������ض��Ĵ�Сд����Ķ��󣬻� null</param>
        /// <returns></returns>
        public static char ToLower(this char c,CultureInfo culture)
        {
            return char.ToLower(c,culture);
        }

        /// <summary>
        /// �Զ�����չ�������� Unicode �ַ���ֵת��Ϊ����Сд��Ч��
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static char ToLower(this char c)
        {
            return char.ToLower(c);
        }

        /// <summary>
        /// �Զ�����չ������ʹ�ù̶������ԵĴ�Сд���򣬽� Unicode �ַ���ֵת��Ϊ��Сд��Ч��
        /// </summary>
        /// <param name="c">��չ����</param>
        /// <returns></returns>
        public static char ToLowerInvariant(this char c)
        {
            return char.ToLowerInvariant(c);
        }
    }
}