using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ش��ڻ����ָ����ʮ����������С����ֵ
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>���ڻ����ָ����ʮ����������С����ֵ</returns>
        public static decimal Ceiling(this decimal value)
        {
            return Math.Ceiling(value);
        }
    }
}