using System;

namespace ZCN.NET.CommonX.Extensions
{
    /// <summary>
    /// �Զ�����չ��
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        ///  �Զ�����չ�������� System.Array �е�һϵ��Ԫ������Ϊ�㡢false �� null������ȡ����Ԫ������
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ���󡣴��㿪ʼ��һά����</param>
        /// <returns></returns>
        public static void ClearAll<T>(this T[] @this)
        {
            Array.Clear(@this, 0, @this.Length);
        }
    }
}