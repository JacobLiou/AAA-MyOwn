using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������� 16 λ�з��������ľ���ֵ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>����ֵ</returns>
        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }
    }
}