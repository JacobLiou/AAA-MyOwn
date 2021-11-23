using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ����Ŀ���ֽڴ���ʼ���ض�ƫ������Դ���鸴�Ƶ���ʼ���ض�ƫ������Ŀ������
        /// </summary>
        /// <param name="src">Դ������</param>
        /// <param name="srcOffset">Դ�������д��㿪ʼ���ֽ�ƫ����</param>
        /// <param name="dst">Ŀ�껺����</param>
        /// <param name="dstOffset">Ŀ�껺�����д��㿪ʼ���ֽ�ƫ����</param>
        /// <param name="count">Ҫ���Ƶ��ֽ���</param>
        public static void BlockCopy(this Array src, int srcOffset, Array dst, int dstOffset, int count)
        {
            Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count);
        }
    }
}