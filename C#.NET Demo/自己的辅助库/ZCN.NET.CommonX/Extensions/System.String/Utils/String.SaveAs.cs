using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ����������չ�����ֵ����Ϊһ���ļ�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="fileName">�ļ�����(����ȫ·��)</param>
        /// <param name="append">����ѡ������ı����ڣ���Ӧ���丽�ӵ��ļ�</param>
        public static void SaveAs(this string @this, string fileName, bool append = false)
        {
            using(TextWriter tw = new StreamWriter(fileName, append))
            {
                tw.Write(@this);
            }
        }

        /// <summary>
        ///   �Զ�����չ����������չ�����ֵ����Ϊһ���ļ�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="file">�ļ���������</param>
        /// <param name="append">����ѡ������ı����ڣ���Ӧ���丽�ӵ��ļ�</param>
        public static void SaveAs(this string @this, FileInfo file, bool append = false)
        {
            using(TextWriter tw = new StreamWriter(file.FullName, append))
            {
                tw.Write(@this);
            }
        }
    }
}