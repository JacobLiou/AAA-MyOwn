using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ�������� 10 Ϊ�׵Ķ���
        /// </summary>
        /// <param name="d">��չ����Ҫ���������������</param>
        /// <returns></returns>
        public static double Log10(this double d)
        {
            return Math.Log10(d);
        }
    }
}