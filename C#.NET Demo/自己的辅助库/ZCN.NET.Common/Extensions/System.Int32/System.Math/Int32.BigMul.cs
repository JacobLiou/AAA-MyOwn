using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������� 32 λ���ֵ������˻�
        /// </summary>
        /// <param name="a">��չ���󡣵�һ������</param>
        /// <param name="b">�ڶ�������</param>
        /// <returns>����ֵ</returns>
        public static long BigMul(this Int32 a, Int32 b)
        {
            return Math.BigMul(a, b);
        }
    }
}