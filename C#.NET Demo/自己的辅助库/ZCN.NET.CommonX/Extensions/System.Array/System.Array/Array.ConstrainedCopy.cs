using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ ��ָ����Դ������ʼ������ System.Array �����е�һϵ��Ԫ�أ�
        ///  ������ճ������һ System.Array �����У���ָ����Ŀ��������ʼ����
        ///  ��֤�ڸ���δ�ɹ���ɵ�����³������и���
        /// </summary>
        /// <param name="sourceArray">Դ����</param>
        /// <param name="sourceIndex">��ʾԴ�����и��ƿ�ʼ��������</param>
        /// <param name="destinationArray">Ŀ������</param>
        /// <param name="destinationIndex">��ʾĿ�������д洢��ʼ��������</param>
        /// <param name="length">����ʾҪ���Ƶ�Ԫ����Ŀ</param>
        public static void ConstrainedCopy(this Array sourceArray,
            int sourceIndex,
            Array destinationArray,
            int destinationIndex,
            int length)
        {
            Array.ConstrainedCopy(sourceArray,sourceIndex,destinationArray,destinationIndex,length);
        }
    }
}