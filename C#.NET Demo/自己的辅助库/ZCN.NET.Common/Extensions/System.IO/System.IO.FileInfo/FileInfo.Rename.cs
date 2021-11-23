using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="newName">�µ�����</param>
        /// <returns></returns>
        public static void Rename(this FileInfo @this, string newName)
        {
            string filePath = Path.Combine(@this.Directory.FullName, newName);
            @this.MoveTo(filePath);
        }
    }
}