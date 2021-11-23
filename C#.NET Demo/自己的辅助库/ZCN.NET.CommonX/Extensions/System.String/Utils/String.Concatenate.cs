using System;
using System.Collections.Generic;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������е�����Ԫ�ش�����һ���ַ��������ش�������ַ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>�ַ���</returns>
        public static string Concatenate(this IEnumerable<string> @this)
        {
            return string.Concat(@this);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ָ������������е�����Ԫ�ز����ش�������ַ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="separator">Ҫ�����ָ������ַ���</param>
        /// <returns>�ַ���</returns>
        public static string Concatenate(this IEnumerable<string> @this,string separator)
        {
            StringBuilder sb = new StringBuilder();

            foreach(var s in @this)
            {
                sb.Append(s + separator);
            }

            string temp = sb.ToString();
            temp = temp.Remove(temp.LastIndexOf(separator, StringComparison.Ordinal));//�Ƴ����һ���ָ���

            return temp;
        }

        /// <summary>
        ///  �Զ�����չ�������������е�����Ԫ��ѭ������ί�к�����ִ�У��������ķ��ؽ��������һ���ַ���������</summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="source">��չ����</param>
        /// <param name="func">ί�к���</param>
        /// <returns>�ַ���</returns>
        public static string Concatenate<T>(this IEnumerable<T> source, Func<T, string> func)
        {
            var sb = new StringBuilder();
            foreach(var item in source)
            {
                sb.Append(func(item));
            }

            return sb.ToString();
        }

        /// <summary>
        ///  �Զ�����չ�������������е�����Ԫ��ѭ�����벢ִ��ί�к�������ָ���ָ����������ķ��ؽ��������һ���ַ���������</summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="source">��չ����</param>
        /// <param name="func">ί�к���</param>
        /// <param name="separator">Ҫ�����ָ������ַ���</param>
        /// <returns>�ַ���</returns>
        public static string Concatenate<T>(this IEnumerable<T> source,Func<T,string> func,string separator)
        {
            var sb = new StringBuilder();
            foreach(var item in source)
            {
                sb.Append(func(item) + separator);
            }

            string temp = sb.ToString();
            temp = temp.Remove(temp.LastIndexOf(separator,StringComparison.Ordinal));//�Ƴ����һ���ָ���

            return temp;
        }
    }
}