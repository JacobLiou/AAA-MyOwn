using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�����������ĵ�ǰλ�õ�ĩβ��ȡ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using(var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        ///  �Զ�����չ������������ָ����λ�õ�ĩβ��ȡ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="position">ָ����λ��</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this, long position)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                stream.Position = position;

                using(var reader = new StreamReader(stream, Encoding.Default))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�����뷽ʽ�����ĵ�ǰλ�õ�ĩβ��ȡ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="encoding">Ӧ�õ��ļ����ݵı���</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this, Encoding encoding)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using(var reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        ///  �Զ�����չ��������ָ�����뷽ʽ������ָ����λ�õ�ĩβ��ȡ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="encoding">Ӧ�õ��ļ����ݵı���</param>
        /// <param name="position">ָ����λ��</param>
        /// <returns></returns>
        public static string ReadToEnd(this FileInfo @this, Encoding encoding, long position)
        {
            using(FileStream stream = File.Open(@this.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                stream.Position = position;

                using(var reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}