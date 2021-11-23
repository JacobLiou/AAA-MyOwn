using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ڴ���д����������鲢����
        /// </summary>
        /// <param name="this">��չ����������</param>
        /// <returns></returns>
        public static byte[] ToByteArray(this Stream @this)
        {
            using(var ms = new MemoryStream())
            {
                @this.CopyTo(ms);

                return ms.ToArray();
            }
        }
    }
}