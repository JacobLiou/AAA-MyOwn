using System;
using System.Globalization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ���������ڵ�ǰ�����Խ�����ʱ����и�ʽ��(U��ͨ��ʱ����������ں�ʱ�䣬�����ںͳ�ʱ��)���á�
        /// ���磺���ļ��������� DateTime.Now ת��Ϊ 2016��12��20�� 1:20:30
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <returns>�ַ�����ʽ������ʱ��</returns>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this)
        {
            return @this.ToString("U", DateTimeFormatInfo.CurrentInfo);
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(U��ͨ��ʱ����������ں�ʱ�䣬�����ںͳ�ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ��ʱ��</returns>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this, string culture)
        {
            return @this.ToString("U", new CultureInfo(culture));
        }

        /// <summary>
        /// �Զ�����չ�����������ƶ��������Խ�����ʱ����и�ʽ��(U��ͨ��ʱ����������ں�ʱ�䣬�����ںͳ�ʱ��)����
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="culture">������</param>
        /// <returns>�ַ�����ʽ��ʱ��</returns>
        public static string ToUniversalSortableLongDateTimeString(this DateTime @this, CultureInfo culture)
        {
            return @this.ToString("U", culture);
        }
    }
}