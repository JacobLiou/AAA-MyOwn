using System;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ڵ�ǰ�����Խ�����ʱ����и�ʽ��(f���������ں�ʱ��,�����ںͶ�ʱ��)���á�
        /// ���磺���ļ��������� DateTime.Now ת��Ϊ 2016��3��20�� 12:20
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToLongDateShortTimeString(this DateTime @this)
        {
            return @this.ToString("f", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(f���������ں�ʱ��,�����ںͶ�ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToLongDateShortTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("f", new CultureInfo(culture));
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(f���������ں�ʱ��,�����ںͶ�ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToLongDateShortTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("f", culture);
        }
    }
}