using System;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ڵ�ǰ�����Խ�����ʱ����и�ʽ��(u��ͨ��ʱ��ĸ�ʽ)���á�
        /// ���磺���ļ��������� DateTime.Now ת��Ϊ 2016-12-20 09:20:30Z
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToUniversalSortableDateTimeString(this DateTime @this)
        {
            return @this.ToString("u", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(u��ͨ��ʱ��ĸ�ʽ)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ��ʱ��</returns>
        public static string ToUniversalSortableDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("u", new CultureInfo(culture));
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(u��ͨ��ʱ��ĸ�ʽ)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ��ʱ��</returns>
        public static string ToUniversalSortableDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("u", culture);
        }
    }
}