using System;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ڵ�ǰ�����Խ�����ʱ����и�ʽ��(t����ʱ��)���á�
        /// ���磺���ļ��������� DateTime.Now ת��Ϊ 12:20
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns>�ַ�����ʽ��ʱ��</returns>
        public static string ToShortTimeString(this DateTime @this)
        {
            return @this.ToString("t", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(t����ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ��ʱ��</returns>
        public static string ToShortTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("t", new CultureInfo(culture));
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(t����ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ��ʱ��</returns>
        public static string ToShortTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("t", culture);
        }
    }
}