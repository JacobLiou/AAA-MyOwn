using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�������� 8 λ�޷�������������ת��Ϊ MemoryStream �ڴ�������
        /// </summary>
        /// <param name="this">��չ����8λ�޷�������������</param>
        /// <returns></returns>
        public static MemoryStream ToMemoryStream(this byte[] @this)
        {
            return new MemoryStream(@this);
        }
    }
}