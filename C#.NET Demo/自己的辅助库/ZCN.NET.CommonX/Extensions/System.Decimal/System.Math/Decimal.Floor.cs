using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������С�ڻ����ָ��С�����������
        /// </summary>
        /// <param name="value">��չ����</param>
        /// <returns>С�ڻ����ָ��С�����������</returns>
        public static decimal Floor(this decimal value)
        {
            return Math.Floor(value);
        }
    }
}