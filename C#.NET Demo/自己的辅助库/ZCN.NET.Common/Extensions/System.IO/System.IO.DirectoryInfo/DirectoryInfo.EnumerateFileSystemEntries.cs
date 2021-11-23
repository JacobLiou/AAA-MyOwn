using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ָ��·���е��ļ�ϵͳ��Ŀ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <returns></returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName);
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ�ϵͳ��Ŀ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <returns></returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this,String searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName,searchPattern);
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƺ�Ŀ¼���ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly
        /// </param>
        /// <returns></returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this,
            String searchPattern,
            SearchOption searchOption)
        {
            return Directory.EnumerateFileSystemEntries(@this.FullName,searchPattern,searchOption);
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ�ϵͳ��Ŀ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <returns></returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this,String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName,x)).Distinct();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƺ�Ŀ¼���ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly</param>
        /// <returns></returns>
        public static IEnumerable<string> EnumerateFileSystemEntries(this DirectoryInfo @this,
            String[] searchPatterns,
            SearchOption searchOption)
        {
            return
                searchPatterns.SelectMany(x => Directory.EnumerateFileSystemEntries(@this.FullName,x,searchOption))
                    .Distinct();
        }
    }
}