using System;
using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ڵ�ǰ�����Խ�����ʱ����и�ʽ��(m���·�����)���á�
        /// ���磺���ļ��������� DateTime.Now ת��Ϊ 11��15��
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns>�ַ�����ʽ������</returns>
        public static string ToMonthDayString(this DateTime @this)
        {
            return @this.ToString("m", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(m���·�����)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������</returns>
        public static string ToMonthDayString(this DateTime @this, string culture)
        {
            return @this.ToString("m", new CultureInfo(culture));
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(m���·�����)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ������</returns>
        public static string ToMonthDayString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("m", culture);
        }
    }
}