using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ָ���Ĺ�����������ָ��·���е�Ŀ¼���ƵĿ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this, Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName)
                            .Select(x => new DirectoryInfo(x))
                            .Where(predicate)
                            .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ���Ĺ�����������ָ��·����������ģʽƥ���Ŀ¼���ƵĿ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this,
            String searchPattern,
            Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern)
                            .Select(x => new DirectoryInfo(x))
                            .Where(predicate)
                            .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ���Ŀ¼���ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this,
            String searchPattern,
            SearchOption searchOption,
            Func<DirectoryInfo, bool> predicate)
        {
            return Directory.EnumerateDirectories(@this.FullName, searchPattern, searchOption)
                            .Select(x => new DirectoryInfo(x))
                            .Where(predicate)
                            .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ���Ŀ¼���ƵĿ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this,
            String[] searchPatterns,
            Func<DirectoryInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x))
                                 .Distinct()
                                 .Where(predicate)
                                 .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ���Ŀ¼���ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static DirectoryInfo[] GetDirectoriesWhere(this DirectoryInfo @this,
            String[] searchPatterns,
            SearchOption searchOption,
            Func<DirectoryInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetDirectories(x, searchOption))
                                 .Distinct()
                                 .Where(predicate)
                                 .ToArray();
        }
    }
}