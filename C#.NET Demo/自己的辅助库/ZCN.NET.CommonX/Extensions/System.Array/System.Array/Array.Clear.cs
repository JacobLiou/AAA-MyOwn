using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ �������е�һϵ��Ԫ������Ϊ�㡢false �� null������ȡ����Ԫ������
        /// </summary>
        /// <param name="array">��Ҫ�����һά����</param>
        /// <param name="index">Ҫ�����һϵ��Ԫ�ص���ʼ����</param>
        /// <param name="length">Ҫ�����Ԫ����</param>
        public static void Clear(this Array array, int index, int length)
        {
            Array.Clear(array, index, length);
        }

        /// <summary>
        /// �Զ�����չ������ �������е�����Ԫ������Ϊ�㡢false �� null������ȡ����Ԫ������
        /// </summary>
        /// <param name="this">��Ҫ�����һά����</param>
        public static void ClearAll(this Array @this)
        {
            Array.Clear(@this,0,@this.Length);
        }
    }
}