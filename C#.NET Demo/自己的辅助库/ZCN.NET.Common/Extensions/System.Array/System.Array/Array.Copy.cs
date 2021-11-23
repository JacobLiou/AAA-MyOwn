using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������ӵ�һ��Ԫ�ؿ�ʼ���� System.Array �����е�һϵ��Ԫ�أ�
        /// ������ճ������һ System.Array �����У��ӵ�һ��Ԫ�ؿ�ʼ��
        /// </summary>
        /// <param name="sourceArray">Դ����</param>
        /// <param name="destinationArray">Ŀ������</param>
        /// <param name="length">��ʾҪ���Ƶ�Ԫ����Ŀ(ָ��Ϊ32 λ����)</param>
        public static void Copy(this Array sourceArray,Array destinationArray,Int32 length)
        {
            Array.Copy(sourceArray,destinationArray,length);
        }

        /// <summary>
        /// �Զ�����չ�������ӵ�һ��Ԫ�ؿ�ʼ���� System.Array �����е�һϵ��Ԫ�أ�
        /// ������ճ������һ System.Array �����У��ӵ�һ��Ԫ�ؿ�ʼ��
        /// </summary>
        /// <param name="sourceArray">Դ����</param>
        /// <param name="sourceIndex">��ʾԴ�����и��ƿ�ʼ��������(ָ��Ϊ32 λ����)</param>
        /// <param name="destinationArray">Ŀ������</param>
        /// <param name="destinationIndex">��ʾĿ�������д洢��ʼ��������(ָ��Ϊ32 λ����)</param>
        /// <param name="length">����ʾҪ���Ƶ�Ԫ����Ŀ(ָ��Ϊ32 λ����)</param>
        public static void Copy(this Array sourceArray,
            int sourceIndex,
            Array destinationArray,
            int destinationIndex,
            int length)
        {
            Array.Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length);
        }

        /// <summary>
        /// �Զ�����չ�������ӵ�һ��Ԫ�ؿ�ʼ���� System.Array �����е�һϵ��Ԫ�أ�
        /// ������ճ������һ System.Array �����У��ӵ�һ��Ԫ�ؿ�ʼ��
        /// </summary>
        /// <param name="sourceArray">Դ����</param>
        /// <param name="destinationArray">Ŀ������</param>
        /// <param name="length">��ʾҪ���Ƶ�Ԫ����Ŀ(ָ��Ϊ64 λ����)</param>
        public static void Copy(this Array sourceArray,Array destinationArray,Int64 length)
        {
            Array.Copy(sourceArray,destinationArray,length);
        }


        /// <summary>
        /// �Զ�����չ�������ӵ�һ��Ԫ�ؿ�ʼ���� System.Array �����е�һϵ��Ԫ�أ�
        /// ������ճ������һ System.Array �����У��ӵ�һ��Ԫ�ؿ�ʼ��
        /// </summary>
        /// <param name="sourceArray">Դ����</param>
        /// <param name="sourceIndex">��ʾԴ�����и��ƿ�ʼ��������(ָ��Ϊ64 λ����)</param>
        /// <param name="destinationArray">Ŀ������</param>
        /// <param name="destinationIndex">��ʾĿ�������д洢��ʼ��������(ָ��Ϊ64 λ����)</param>
        /// <param name="length">����ʾҪ���Ƶ�Ԫ����Ŀ(ָ��Ϊ64 λ����)</param>
        public static void Copy(this Array sourceArray,
            Int64 sourceIndex,
            Array destinationArray,
            Int64 destinationIndex,
            Int64 length)
        {
            Array.Copy(sourceArray,sourceIndex,destinationArray,destinationIndex,length);
        }
    }
}