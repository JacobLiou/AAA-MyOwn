using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ָ��·���е��ļ����Ŀ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this, Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName)
                            .Select(x => new FileInfo(x))
                            .Where(predicate)
                            .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƵĿ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this,
            String searchPattern,
            Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName, searchPattern)
                            .Select(x => new FileInfo(x))
                            .Where(predicate)
                            .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly
        /// </param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this,
            String searchPattern,
            SearchOption searchOption,
            Func<FileInfo, bool> predicate)
        {
            return Directory.EnumerateFiles(@this.FullName, searchPattern, searchOption)
                            .Select(x => new FileInfo(x))
                            .Where(predicate)
                            .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƵĿ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this,
            String[] searchPatterns,
            Func<FileInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x))
                                 .Distinct()
                                 .Where(predicate)
                                 .ToArray();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly
        /// </param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static FileInfo[] GetFilesWhere(this DirectoryInfo @this,
            String[] searchPatterns,
            SearchOption searchOption,
            Func<FileInfo, bool> predicate)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption))
                                 .Distinct()
                                 .Where(predicate)
                                 .ToArray();
        }
    }
}