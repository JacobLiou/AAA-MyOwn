using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������һ���ļ������ļ������ݶ���һ���ַ�����Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static byte[] ReadAllBytes(this FileInfo @this)
        {
            return File.ReadAllBytes(@this.FullName);
        }
    }
}