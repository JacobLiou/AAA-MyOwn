using System;
using System.Globalization;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ڵ�ǰ�����Խ�����ʱ����и�ʽ��(g,�����ںͶ�ʱ��)���á�
        /// ���磺���ļ��������� DateTime.Now ת��Ϊ 2016/3/12 12:20
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToShortDateTimeString(this DateTime @this)
        {
            return @this.ToString("g",DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(g,�����ںͶ�ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToShortDateTimeString(this DateTime @this,string culture)
        {
            return @this.ToString("g",new CultureInfo(culture));
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(g,�����ںͶ�ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToShortDateTimeString(this DateTime @this,CultureInfo culture)
        {
            return @this.ToString("g",culture);
        }
    }
}