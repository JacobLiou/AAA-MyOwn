using System;
using System.Collections.ObjectModel;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ�������ֻ����װ
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="array">��չ���󡣴��㿪ʼ��һά����</param>
        /// <returns></returns>
        public static ReadOnlyCollection<T> AsReadOnly<T>(this T[] array)
        {
            return Array.AsReadOnly(array);
        }
    }
}