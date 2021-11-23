using System;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToDateTimeString
        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ�������ʱ���룬��ʽ��"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="showSecond">�Ƿ���ʾ��</param>
        public static string ToDateTimeString(this DateTime @this, bool showSecond = true)
        {
            if (showSecond)
                return @this.ToString("yyyy-MM-dd HH:mm:ss");

            return @this.ToString("yyyy-MM-dd HH:mm");
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ�������ʱ���룬��ʽ��"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="showSecond">�Ƿ���ʾ��</param>
        public static string ToDateTimeString(this DateTime? @this, bool showSecond = true)
        {
            if (@this == null)
                return string.Empty;

            return ToDateTimeString(@this.Value, showSecond);
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ���������ʱ���룬��ʽ��"yyyy-MM-dd"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToDateString(this DateTime @this)
        {
            return @this.ToString("yyyy-MM-dd");
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ���������ʱ���룬��ʽ��"yyyy-MM-dd"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToDateString(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToDateString(@this.Value);
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ��������������գ���ʽ��"HH:mm:ss"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToTimeString(this DateTime @this)
        {
            return @this.ToString("HH:mm:ss");
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ��������������գ���ʽ��"HH:mm:ss"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToTimeString(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToTimeString(@this.Value);
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ����������룬��ʽ��"yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToDateTimeStringWithMillisecond(this DateTime @this)
        {
            return @this.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ����������룬��ʽ��"yyyy-MM-dd HH:mm:ss.fff"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToDateTimeStringWithMillisecond(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToDateTimeStringWithMillisecond(@this.Value);
        }

        #endregion

        #region ToChineseDateString

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ���������ʱ���룬��ʽ��"yyyy��MM��dd��"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToChineseDateString(this DateTime @this)
        {
            return string.Format("{0}��{1}��{2}��", @this.Year, @this.Month, @this.Day);
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ���������ʱ���룬��ʽ��"yyyy��MM��dd��"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        public static string ToChineseDateString(this DateTime? @this)
        {
            if (@this == null)
                return string.Empty;

            return ToChineseDateString(@this);
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ�������ʱ���룬��ʽ��"yyyy��MM��dd�� HHʱmm��"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="showSecond">�Ƿ���ʾ��</param>
        public static string ToChineseDateTimeString(this DateTime @this, bool showSecond = true)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0}��{1}��{2}��", @this.Year, @this.Month, @this.Day);
            result.AppendFormat(" {0}ʱ{1}��", @this.Hour, @this.Minute);
            if (showSecond)
                result.AppendFormat("{0}��", @this.Second);

            return result.ToString();
        }

        /// <summary>
        /// �Զ�����չ��������ȡ��ʽ���ַ�������ʱ���룬��ʽ��"yyyy��MM��dd�� HHʱmm��"
        /// </summary>
        /// <param name="this">��չ��������ʱ��</param>
        /// <param name="showSecond">�Ƿ���ʾ����</param>
        public static string ToChineseDateTimeString(this DateTime? @this, bool showSecond = true)
        {
            if (@this == null)
                return string.Empty;

            return ToChineseDateTimeString(@this.Value, showSecond);
        }

        #endregion
    }
}