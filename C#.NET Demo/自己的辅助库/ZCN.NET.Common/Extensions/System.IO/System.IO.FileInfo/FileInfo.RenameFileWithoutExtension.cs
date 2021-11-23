using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������ļ�������ԭ������չ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="newName">�µ�����(�����ļ���չ��)</param>
        /// <returns></returns>
        public static void RenameFileWithoutExtension(this FileInfo @this, string newName)
        {
            string fileName = string.Concat(newName, @this.Extension);
            string filePath = Path.Combine(@this.Directory.FullName, fileName);
            @this.MoveTo(filePath);
        }
    }
}