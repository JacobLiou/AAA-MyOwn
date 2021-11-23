using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ָ��·���е��ļ����Ŀ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this)
        {
            return Directory.EnumerateFiles(@this.FullName).Select(x => new FileInfo(x));
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·���е��ļ����Ŀ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,String searchPattern)
        {
            return Directory.EnumerateFiles(@this.FullName,searchPattern).Select(x => new FileInfo(x));
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPattern">Ҫ�� path �е�Ŀ¼����ƥ��������ַ���</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,
            String searchPattern,
            SearchOption searchOption)
        {
            return Directory.EnumerateFiles(@this.FullName,searchPattern,searchOption).Select(x => new FileInfo(x));
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·���е��ļ����Ŀ�ö�ټ���
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct();
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��·����������ģʽƥ����ļ����ƵĿ�ö�ټ��ϣ�������������Ŀ¼
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///  Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly</param>
        /// <returns></returns>
        public static IEnumerable<FileInfo> EnumerateFiles(this DirectoryInfo @this,
            String[] searchPatterns,
            SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x,searchOption)).Distinct();
        }
    }
}