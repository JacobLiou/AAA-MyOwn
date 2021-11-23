using System.IO;
using System.IO.Compression;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ָ�� zip �浵�е������ļ�����ѹ���ļ�ϵͳ��һĿ¼��
        /// </summary>
        /// <param name="this">��չ���󣬰���Ҫ��ѹ���浵��·��</param>
        /// <param name="destinationDirectoryName">���ý�ѹ���ļ���Ŀ¼��·����ָ��Ϊ���·�������·���� 
        ///  ���·��������Ϊ����ڵ�ǰ����Ŀ¼
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,string destinationDirectoryName)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectoryName);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� zip �浵�е������ļ�����ѹ���ļ�ϵͳ��һĿ¼��
        /// </summary>
        /// <param name="this">��չ���󣬰�����Ҫ��ѹ���浵��·��</param>
        /// <param name="destinationDirectoryName">���ý�ѹ���ļ���Ŀ¼��·����ָ��Ϊ���·�������·���� 
        ///  ���·��������Ϊ����ڵ�ǰ����Ŀ¼
        /// </param>
        /// <param name="entryNameEncoding">�ڹ鵵�ж�ȡ��д����Ŀ����ʱʹ�õı��롣 
        ///  ������Ҫ��Ծ��в�֧����Ŀ���Ƶ� UTF-8 ����� zip �鵵���ߺͿ�Ļ������Խ��б���ʱ��Ϊ�˲���ָ��ֵ
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,
            string destinationDirectoryName,
            Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectoryName,entryNameEncoding);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� zip �浵�е������ļ�����ѹ���ļ�ϵͳ��һĿ¼��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ���󣬰�����Ҫ��ѹ���浵��·��</param>
        /// <param name="destinationDirectory">Ŀ¼��Ϣ���󣬰��������ý�ѹ���ļ���Ŀ¼��·����ָ��Ϊ���·�������·���� 
        ///  ���·��������Ϊ����ڵ�ǰ����Ŀ¼
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,DirectoryInfo destinationDirectory)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectory.FullName);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�� zip �浵�е������ļ�����ѹ���ļ�ϵͳ��һĿ¼��
        /// </summary>
        /// <param name="this">��չ���󣬰�����Ҫ��ѹ���浵��·��</param>
        /// <param name="destinationDirectory">Ŀ¼��Ϣ���󣬷��ý�ѹ���ļ���Ŀ¼��·����ָ��Ϊ���·�������·���� 
        ///  ���·��������Ϊ����ڵ�ǰ����Ŀ¼
        /// </param>
        /// <param name="entryNameEncoding">�ڹ鵵�ж�ȡ��д����Ŀ����ʱʹ�õı��롣 
        ///  ������Ҫ��Ծ��в�֧����Ŀ���Ƶ� UTF-8 ����� zip �鵵���ߺͿ�Ļ������Խ��б���ʱ��Ϊ�˲���ָ��ֵ
        /// </param>
        public static void ExtractZipFileToDirectory(this FileInfo @this,
            DirectoryInfo destinationDirectory,
            Encoding entryNameEncoding)
        {
            ZipFile.ExtractToDirectory(@this.FullName,destinationDirectory.FullName,entryNameEncoding);
        }
    }
}
