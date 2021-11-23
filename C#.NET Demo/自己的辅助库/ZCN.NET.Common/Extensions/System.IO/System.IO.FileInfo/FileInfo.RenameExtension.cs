using System.IO;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������������ļ���չ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="extension">�µ���չ��</param>
        /// <returns></returns>
        public static void RenameExtension(this FileInfo @this, string extension)
        {
            string filePath = Path.ChangeExtension(@this.FullName, extension);
            @this.MoveTo(filePath);
        }
    }
}