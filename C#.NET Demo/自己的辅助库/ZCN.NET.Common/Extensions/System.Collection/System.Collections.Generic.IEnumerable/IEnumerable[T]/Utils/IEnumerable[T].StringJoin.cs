using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ���ָ����Ž������е�Ԫ�ش�����һ���ַ���
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ�����</param>
        /// <returns></returns>
        internal static string JoinWith<T>(this IEnumerable<T> @this, string separator)
        {
            if (@this == null || @this.Any() == false)
                return String.Empty;

            return string.Join(separator, @this);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ָ����Ž������е�Ԫ�ش�����һ���ַ���
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ�����</param>
        /// <returns></returns>
        internal static string JoinWith<T>(this IEnumerable<T> @this, char separator)
        {
            if (@this == null || @this.Any() == false)
                return String.Empty;

            return string.Join(separator.ToString(), @this);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ָ����Ž������е�Ԫ�ش�����һ���ַ���
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ�����</param>
        /// <returns></returns>
        public static string ToStringWith<T>(this IEnumerable<T> @this, string separator)
        {
            if (@this == null || @this.Any() == false)
                return String.Empty;

            return string.Join(separator, @this);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ָ����Ž������е�Ԫ�ش�����һ���ַ�����ÿ��Ԫ�ض���ָ���������Ű�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ�����</param>
        /// <param name="leftWrapSymbol">���������ϡ�������˫���ţ������ǵ����š�С���š������š������š��Ⱥš����ߵȵ�</param>
        /// <param name="rightWrapSymbol">�Ҳ�������ϡ�������˫���ţ������ǵ����š�С���š������š������š��Ⱥš����ߵȵ�</param>
        /// <returns></returns>
        public static string ToStringWith<T>(this IEnumerable<T> @this, string separator, string leftWrapSymbol, string rightWrapSymbol)
        {
            if (@this == null || @this.Any() == false)
                return String.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (var item in @this)
            {
                sb.Append(leftWrapSymbol + item + rightWrapSymbol + separator);
            }

            return sb.ToString().RemoveLast(separator);
        }


        /// <summary>
        ///  �Զ�����չ��������ָ���ָ����Ž������е�Ԫ�ش�����һ���ַ�����ÿ��������ʾΪ������һ�С�
        ///  �÷���һ�����ڽ��Զ�����Ķ��󼯺�ƴ�ӳɶ�����ʾ���ַ�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="ignoreNullObj">�Ƿ���Լ�����Ϊ NULL �Ķ���</param>
        /// <returns></returns>
        public static string ToStringLine<T>(this IEnumerable<T> @this, bool ignoreNullObj = true)
        {
            if (@this == null || @this.Any() == false)
                return String.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (var obj in @this)
            {
                if (obj != null)
                {
                    sb.AppendLine(obj.ToString());
                }
                else
                {
                    if (ignoreNullObj == false)
                    {
                        sb.AppendLine("NULL");
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ָ����Ž������е�Ԫ�ش�����һ���ַ�����ÿ��������ʾΪ������һ�С�
        ///  �÷���һ�����ڽ��Զ�����Ķ��󼯺�ƴ�ӳɶ�����ʾ���ַ�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ����š�</param>
        /// <param name="ignoreNullObj">�Ƿ���Լ�����Ϊ NULL �Ķ���</param>
        /// <returns></returns>
        public static string ToStringLineWith<T>(this IEnumerable<T> @this, string separator, bool ignoreNullObj = true)
        {
            if (@this == null || @this.Any() == false)
                return String.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (var obj in @this)
            {
                if (obj != null)
                {
                    sb.AppendLine(obj.ToString() + separator);
                }
                else
                {
                    if (ignoreNullObj == false)
                    {
                        sb.AppendLine("NULL");
                    }
                }
            }

            return sb.ToString();
        }

        /// <summary>
        ///  �Զ�����չ��������ָ���ָ����Ž������е�Ԫ�ش�����һ���ַ���
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ�����</param>
        /// <returns></returns>
        public static string ToStringWith<T>(this IEnumerable<T> @this, char separator)
        {
            if (@this == null || @this.Any() == false)
                return String.Empty;

            return string.Join(separator.ToString(), @this);
        }
    }
}