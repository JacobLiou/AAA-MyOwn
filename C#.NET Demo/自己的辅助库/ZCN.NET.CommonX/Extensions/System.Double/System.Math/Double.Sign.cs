using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ر�ʾ���ַ��ŵ�ֵ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>һ��ָʾ value �ķ��ŵ����֣����±���ʾ������ֵ����-1value С���㡣0value �����㡣1value ������</returns>
        public static int Sign(this double value)
        {
            return Math.Sign(value);
        }
    }
}