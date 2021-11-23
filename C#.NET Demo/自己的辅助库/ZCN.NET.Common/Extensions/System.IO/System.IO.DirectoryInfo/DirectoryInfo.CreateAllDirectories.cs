using System.IO;

#if NETFRAMEWORK
using System.Security.AccessControl;
#endif

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� path ��ָ����������Ŀ¼����Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <returns></returns>
        public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this)
        {
            return Directory.CreateDirectory(@this.FullName);
        }

#if NETFRAMEWORK

        /// <summary>
        ///  �Զ�����չ����������ָ��·���е�����Ŀ¼����Ӧ��ָ���� Windows ��ȫ��
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="directorySecurity">ҪӦ���ڴ�Ŀ¼�ķ��ʿ���</param>
        /// <returns></returns>
        public static DirectoryInfo CreateAllDirectories(this DirectoryInfo @this,DirectorySecurity directorySecurity)
        {
            return Directory.CreateDirectory(@this.FullName,directorySecurity);
        }

#endif

    }
}