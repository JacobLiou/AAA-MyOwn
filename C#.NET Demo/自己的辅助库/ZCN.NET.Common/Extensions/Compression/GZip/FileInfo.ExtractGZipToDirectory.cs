using System.IO;
using System.IO.Compression;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /*΢��ٷ��ĵ���https://docs.microsoft.com/zh-cn/dotnet/api/system.io.compression.gzipstream?view=netcore-3.1*/

        /// <summary>
        ///  �Զ�����չ����������ָ���ļ�������Ϣ����һ��ѹ���ļ��������ļ���Ϣ�п������ݵ�һ���µ��ļ���
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����,��Ҫ�����ļ�ȫ·������</param>
        public static void ExtractGZipToDirectory(this FileInfo @this)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                string newFileName = Path.GetFileNameWithoutExtension(@this.FullName);

                using (FileStream destFileStream = File.Create(newFileName))
                {
                    using (var gZipStream = new GZipStream(destFileStream, CompressionMode.Compress))
                    {
                        originalFileStream.CopyTo(gZipStream);
                    }
                }
            }
        }

        /// <summary>
        ///  �Զ�����չ����������ָ���ļ�������Ϣ����һ��ѹ���ļ��������ļ���Ϣ�п������ݵ�һ���µ��ļ���
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����,��Ҫ�����ļ�ȫ·������</param>
        /// <param name="destination">ѹ���ļ������ƣ�����ȫ·��</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, string destination)
        {
            using (FileStream originalFileStream = @this.OpenRead())
            {
                using (FileStream destFileStream = File.Create(destination))
                {
                    //using (var gZipStream = new GZipStream(destFileStream, CompressionMode.Compress))
                    //{
                    //    originalFileStream.CopyTo(gZipStream);
                    //}

                    originalFileStream.CopyTo(destFileStream);
                }
            }
        }

        /// <summary>
        ///   �Զ�����չ����������ѹ���ļ���ָ��Ŀ¼��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="destFileInfo">ѹ���ļ���Ϣ�Ķ�����Ҫ�����ļ�ȫ·������</param>
        public static void ExtractGZipToDirectory(this FileInfo @this, FileInfo destFileInfo)
        {
            @this.ExtractGZipToDirectory(destFileInfo.FullName);
        }
    }
}