using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������һ�����ļ���������д��ָ�����ֽ����飬Ȼ��رո��ļ������Ŀ���ļ��Ѵ��ڣ��򸲸Ǹ��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="bytes">Ҫд���ļ����ֽ�</param>
        public static void WriteAllBytes(this FileInfo @this, byte[] bytes)
        {
            File.WriteAllBytes(@this.FullName, bytes);
        }
    }
}