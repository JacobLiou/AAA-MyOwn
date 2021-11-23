using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������һ�����ļ���������д��ָ�����ַ������飬Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫд���ļ����ַ�������</param>
        public static void WriteAllLines(this FileInfo @this,string[] contents)
        {
            File.WriteAllLines(@this.FullName,contents);
        }

        /// <summary>
        ///  �Զ�����չ����������һ�����ļ�����ָ�������ʽ������д��ָ�����ַ������飬Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫд���ļ����ַ�������</param>
        /// <param name="encoding">�����ʽ</param>
        public static void WriteAllLines(this FileInfo @this,string[] contents,Encoding encoding)
        {
            File.WriteAllLines(@this.FullName,contents,encoding);
        }

        /// <summary>
        ///  �Զ�����չ����������һ�����ļ���������д��ָ�����ַ������飬Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫд���ļ����ַ�������</param>
        public static void WriteAllLines(this FileInfo @this,IEnumerable<string> contents)
        {
            File.WriteAllLines(@this.FullName,contents);
        }

        /// <summary>
        ///  �Զ�����չ����������һ�����ļ�����ָ�������ʽ������д��ָ�����ַ������飬Ȼ��رո��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫд���ļ����ַ�������</param>
        /// <param name="encoding">�����ʽ</param>
        public static void WriteAllLines(this FileInfo @this,IEnumerable<string> contents,Encoding encoding)
        {
            File.WriteAllLines(@this.FullName,contents,encoding);
        }
    }
}