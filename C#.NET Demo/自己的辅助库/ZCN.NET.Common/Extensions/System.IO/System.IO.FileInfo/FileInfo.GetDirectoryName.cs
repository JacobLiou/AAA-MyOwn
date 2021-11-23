using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ȡ�� System.IO.DirectoryInfo ʵ��������
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static string GetDirectoryName(this FileInfo @this)
        {
            return @this.Directory.Name;
        }
    }
}