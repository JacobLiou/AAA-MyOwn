using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ָ��С������������
        /// </summary>
        /// <param name="d">��չ����</param>
        /// <returns>��������(������С��λ��ʣ�����)</returns>
        public static decimal Truncate(this decimal d)
        {
            return Math.Truncate(d);
        }
    }
}