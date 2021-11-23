using System.IO;

#if NETFRAMEWORK
using System.Security.AccessControl;
#endif

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� path ��ָ����������Ŀ¼����Ŀ¼������Ŀ¼��Ϣ����
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <returns></returns>
        public static DirectoryInfo CreateDirectory(this FileInfo @this)
        {
            return Directory.CreateDirectory(@this.Directory.FullName);
        }

#if NETFRAMEWORK

        /// <summary>
        ///  �Զ�����չ����������ָ��·���е�����Ŀ¼����Ӧ��ָ���� Windows ��ȫ��
        /// </summary>
        /// <param name="this">��չ�����ļ���Ϣ����</param>
        /// <param name="directorySecurity">ҪӦ���ڴ�Ŀ¼�ķ��ʿ���</param>
        /// <returns></returns>
        public static DirectoryInfo CreateDirectory(this FileInfo @this,DirectorySecurity directorySecurity)
        {
            return Directory.CreateDirectory(@this.Directory.FullName,directorySecurity);
        }

#endif
    }
}