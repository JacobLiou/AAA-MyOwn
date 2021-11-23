using System;
using System.Collections.Generic;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region Replace

        /// <summary>
        ///  �Զ�����չ��������ָ����λ�ÿ�ʼ����ָ�����ȵ����ݲ��µ�ֵ�滻��
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="startIndex">��ʼλ��</param>
        /// <param name="length">ָ������</param>
        /// <param name="value">�滻������</param>
        /// <returns>�滻����ַ���</returns>
        public static string Replace(this string @this, int startIndex, int length, string value)
        {
            @this = @this.Remove(startIndex, length).Insert(startIndex, value);

            return @this;
        }

        #endregion

        #region ReplaceFirst

        /// <summary>
        /// �Զ�����չ������ʹ����ֵ�滻�ַ����е�һ�γ��ֵľ�ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="oldValue">��ֵ</param>
        /// <param name="newValue">��ֵ</param>
        /// <returns></returns>
        public static string ReplaceFirst(this string @this, string oldValue, string newValue)
        {
            int startIndex = @this.IndexOf(oldValue);
            if (startIndex == -1)
                return @this;

            return @this.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);
        }


        /// <summary>
        /// �Զ�����չ������ʹ����ֵ�滻�ַ����е�һ����ָ�������ľ�ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="number">����</param>
        /// <param name="oldValue">��ֵ</param>
        /// <param name="newValue">��ֵ</param>
        /// <returns></returns>
        public static string ReplaceFirst(this string @this, int number, string oldValue, string newValue)
        {
            List<string> list = @this.Split(oldValue).ToList();
            int old = number + 1;
            IEnumerable<string> listStart = list.Take(old);
            IEnumerable<string> listEnd = list.Skip(old);

            return string.Join(newValue, listStart) +
                   (listEnd.Any() ? oldValue : string.Empty) +
                   string.Join(oldValue, listEnd);
        }

        #endregion

        #region ReplaceLast

        /// <summary>
        /// �Զ�����չ������ʹ����ֵ�滻�ַ��������һ�γ��ֵľ�ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="oldValue">��ֵ</param>
        /// <param name="newValue">��ֵ</param>
        /// <returns></returns>
        public static string ReplaceLast(this string @this, string oldValue, string newValue)
        {
            int startIndex = @this.LastIndexOf(oldValue);
            if (startIndex == -1)
                return @this;

            return @this.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);
        }

        /// <summary>
        /// �Զ�����չ������ʹ����ֵ�滻�ַ�����ָ�����������һ���ľ�ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="number">����</param>
        /// <param name="oldValue">��ֵ</param>
        /// <param name="newValue">��ֵ</param>
        public static string ReplaceLast(this string @this, int number, string oldValue, string newValue)
        {
            List<string> list = @this.Split(oldValue).ToList();
            int old = Math.Max(0, list.Count - number - 1);
            IEnumerable<string> listStart = list.Take(old);
            IEnumerable<string> listEnd = list.Skip(old);

            return string.Join(oldValue, listStart) +
                   (old > 0 ? oldValue : string.Empty) +
                   string.Join(newValue, listEnd);
        }

        #endregion

        #region ReplaceWhenEquals

        /// <summary>
        ///  �Զ�����չ����������չ�����ֵ���ֵ���ʱ�滻Ϊ��ֵ
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="oldValue">��ֵ</param>
        /// <param name="newValue">��ֵ</param>
        /// <returns></returns>
        public static string ReplaceWhenEquals(this string @this, string oldValue, string newValue)
        {
            return @this == oldValue ? newValue : @this;
        }
        #endregion
    }
}