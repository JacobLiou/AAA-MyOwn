using System.IO;
using System.IO.Compression;

namespace ZCN.NET.CommonX.Extensionsn
{
    public static partial class CommonExtensions
    {
        /*΢��ٷ��ĵ���https://docs.microsoft.com/zh-cn/dotnet/api/system.io.compression.gzipstream?view=netcore-3.1*/

        /// <summary>
        ///  �Զ�����չ����������ѹ���ļ���
        ///  ����ļ�����Ϊ���ػ����ļ���չ��Ϊ .gz���򲻴���ѹ���ļ���
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����,��Ҫ�����ļ�ȫ·������</param>
        /// <returns></returns>
        public static void CreateGZip(this FileInfo @this)
        {
            if ((File.GetAttributes(@this.FullName) & FileAttributes.Hidden) !=
                 FileAttributes.Hidden & @this.Extension != ".gz")
            {
                using (FileStream originalStream = @this.OpenRead())
                {
                    using (FileStream destStream = File.Create(@this.FullName + ".gz"))
                    {
                        using (var gZipStream = new GZipStream(destStream, CompressionMode.Compress))
                        {
                            originalStream.CopyTo(gZipStream);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   �Զ�����չ����������ѹ���ļ�.
        ///  ����ļ�����Ϊ���ػ����ļ���չ��Ϊ .gz���򲻴���ѹ���ļ���
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="destination">ѹ���ļ������ƣ�����ȫ·��</param>
        public static void CreateGZip(this FileInfo @this, string destination)
        {
            if ((File.GetAttributes(@this.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden
             & @this.Extension != ".gz")
            {
                using (FileStream originalStream = @this.OpenRead())
                {
                    using (FileStream destStream = File.Create(destination))
                    {
                        using (var gZipStream = new GZipStream(destStream, CompressionMode.Compress))
                        {
                            originalStream.CopyTo(gZipStream);
                        }
                    }
                }
            }
        }

        /// <summary>
        ///   �Զ�����չ����������ѹ���ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="destFileInfo">ѹ���ļ���Ϣ�Ķ�����Ҫ�����ļ�ȫ·������</param>
        public static void CreateGZip(this FileInfo @this, FileInfo destFileInfo)
        {
            @this.CreateGZip(destFileInfo.FullName);
        }
    }
}