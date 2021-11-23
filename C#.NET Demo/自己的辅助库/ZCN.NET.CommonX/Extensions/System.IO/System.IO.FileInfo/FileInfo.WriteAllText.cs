using System.IO;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������һ�����ļ���������д��ָ�����ַ�����Ȼ��ر��ļ������Ŀ���ļ��Ѵ��ڣ��򸲸Ǹ��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫд���ļ����ַ���</param>
        public static void WriteAllText(this FileInfo @this,string contents)
        {
            File.WriteAllText(@this.FullName,contents);
        }

        /// <summary>
        ///  �Զ�����չ����������һ�����ļ�����ָ�����뷽ʽ������д��ָ�����ַ�����Ȼ��ر��ļ������Ŀ���ļ��Ѵ��ڣ��򸲸Ǹ��ļ�
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="contents">Ҫд���ļ����ַ���</param>
        /// <param name="encoding">���뷽ʽ</param>
        public static void WriteAllText(this FileInfo @this,string contents,Encoding encoding)
        {
            File.WriteAllText(@this.FullName,contents,encoding);
        }
    }
}