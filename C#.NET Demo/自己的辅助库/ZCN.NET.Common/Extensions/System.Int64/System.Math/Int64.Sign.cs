using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������һ��ֵ����ֵ��ʾ 64 λ�з��������ķ���
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>һ��ָʾ value �ķ��ŵ����֣����±���ʾ������ֵ����-1value С���㡣0value �����㡣1value ������</returns>
        public static Int64 Sign(this Int64 value)
        {
            return Math.Sign(value);
        }
    }
}