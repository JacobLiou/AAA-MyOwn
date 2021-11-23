using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ�����������������һ��Ԫ��
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="values">������������</param>
        /// <returns></returns>
        public static T NextOne<T>(this Random @this, params T[] values)
        {
            return values[@this.Next(values.Length)];
        }
    }
}