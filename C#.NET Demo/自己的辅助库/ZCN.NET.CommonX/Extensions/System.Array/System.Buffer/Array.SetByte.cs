using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ��ֵ�����ָ���������ض�λ�ô����ֽ�
        /// </summary>
        /// <param name="array">һ������</param>
        /// <param name="index">�����е�λ��</param>
        /// <param name="value">Ҫ�����ֵ</param>
        public static void SetByte(this Array array,int index,byte value)
        {
            Buffer.SetByte(array,index,value);
        }
    }
}