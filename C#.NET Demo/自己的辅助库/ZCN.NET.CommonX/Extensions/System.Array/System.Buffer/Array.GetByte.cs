using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ�������м���ָ��λ�ô����ֽ�
        /// </summary>
        /// <param name="array">һ������</param>
        /// <param name="index">�����е�λ��</param>
        /// <returns></returns>
        public static byte GetByte(this Array array, int index)
        {
            return Buffer.GetByte(array, index);
        }
    }
}