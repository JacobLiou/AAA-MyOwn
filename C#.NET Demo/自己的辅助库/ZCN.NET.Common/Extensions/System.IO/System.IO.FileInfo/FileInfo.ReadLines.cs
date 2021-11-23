using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������ȡ�ļ����ı���
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(this FileInfo @this)
        {
            return File.ReadLines(@this.FullName);
        }

        /// <summary>
        ///  �Զ�����չ��������ȡ����ָ��������ļ����ı���
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="encoding">Ӧ�õ��ļ����ݵı���</param>
        /// <returns></returns>
        public static IEnumerable<string> ReadLines(this FileInfo @this, Encoding encoding)
        {
            return File.ReadLines(@this.FullName, encoding);
        }
    }
}