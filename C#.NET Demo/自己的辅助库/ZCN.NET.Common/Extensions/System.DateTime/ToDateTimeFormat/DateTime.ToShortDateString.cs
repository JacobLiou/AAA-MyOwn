using System;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ڵ�ǰ�����Խ�����ʱ����и�ʽ��(d��������)���á�
        /// ���磺���ļ��������� DateTime.Now ת��Ϊ 2016/3/12
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns>�ַ�����ʽ������</returns>
        public static string ToShortDateString(this DateTime @this)
        {
            return @this.ToString("d", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(d��������)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������</returns>
        public static string ToShortDateString(this DateTime @this, string culture)
        {
            return @this.ToString("d", new CultureInfo(culture));
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(d��������)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������</returns>
        public static string ToShortDateString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("d", culture);
        }
    }
}