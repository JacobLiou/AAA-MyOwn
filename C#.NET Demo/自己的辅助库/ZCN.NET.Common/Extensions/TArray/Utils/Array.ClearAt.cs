using System;

namespace ZCN.NET.Common.Extensions
{
    /// <summary>
    /// �Զ�����չ��
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ����������ʼָ��������Ԫ������Ϊ�㡢false �� null������ȡ����Ԫ������
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ���󡣴��㿪ʼ��һά����</param>
        /// <param name="index">Ҫ�����һϵ��Ԫ�ص���ʼ����</param>
        /// <param name="length">Ҫ�����Ԫ����</param>
        public static void ClearAt<T>(this T[] @this,int index,int length)
        {
            Array.Clear(@this,index,length);
        }
    }
}