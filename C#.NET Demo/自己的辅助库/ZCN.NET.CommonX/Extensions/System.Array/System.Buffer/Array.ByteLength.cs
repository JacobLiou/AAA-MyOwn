using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ����������ָ�������е��ֽ���
        /// </summary>
        /// <param name="array">һ������</param>
        /// <returns></returns>
        public static int ByteLength(this Array array)
        {
            return Buffer.ByteLength(array);
        }
    }
}