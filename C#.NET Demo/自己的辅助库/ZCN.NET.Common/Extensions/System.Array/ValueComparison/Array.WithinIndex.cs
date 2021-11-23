using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ж�ָ���������Ƿ������������
        /// </summary>
        /// <param name="this">��չ����һά System.Array ����</param>
        /// <param name="index">ָ��������</param>
        /// <returns></returns>
        public static bool WithinIndex(this Array @this, int index)
        {
            return index >= 0 && index < @this.Length;
        }

        /// <summary>
        /// �Զ�����չ�������ж�ָ���������Ƿ������������
        /// </summary>
        /// <param name="this">��չ����һά System.Array ����</param>
        /// <param name="index">ָ��������</param>
        /// <param name="dimension">ά��</param>
        /// <returns></returns>
        public static bool WithinIndex(this Array @this, int index, int dimension)
        {
            return index >= @this.GetLowerBound(dimension) && index <= @this.GetUpperBound(dimension);
        }
    }
}