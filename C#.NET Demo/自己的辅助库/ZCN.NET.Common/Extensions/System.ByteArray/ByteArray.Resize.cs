using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������������Ĵ�С����Ϊָ�����´�С
        /// </summary>
        /// <param name="this">��չ����Ҫ������С��һά���飬��������㿪ʼ�����Ϊ null ���½�����ָ����С������</param>
        /// <param name="newSize">������Ĵ�С</param>
        /// <returns></returns>
        public static byte[] Resize(this byte[] @this, int newSize)
        {
            Array.Resize(ref @this, newSize);
            return @this;
        }
    }
}