using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������һ��ֵ����ֵ��ʾ 16 λ�з��������ķ���
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>һ��ָʾ value �ķ��ŵ����֣����±���ʾ������ֵ����-1value С���㡣0value �����㡣1value ������</returns>
        public static Int32 Sign(this Int16 value)
        {
            return Math.Sign(value);
        }
    }
}