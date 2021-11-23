using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ص�ǰĿ¼�������������ģʽƥ����ļ��б�
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <returns></returns>
        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x)).Distinct().ToArray();
        }

        /// <summary>
        ///  �Զ�����չ���������ص�ǰĿ¼�������������ģʽƥ����ļ��б�
        /// </summary>
        /// <param name="this">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="searchPatterns">Ҫ�� path �е�Ŀ¼����ƥ��������ַ�������</param>
        /// <param name="searchOption">System.IO.SearchOption ö�ٵ�һ��ֵ��ָ������������Ӧ��������ǰĿ¼����Ӧ����������Ŀ¼��
        ///   Ĭ��ֵΪ System.IO.SearchOption.TopDirectoryOnly
        /// </param>
        /// <returns></returns>
        public static FileInfo[] GetFiles(this DirectoryInfo @this, String[] searchPatterns, SearchOption searchOption)
        {
            return searchPatterns.SelectMany(x => @this.GetFiles(x, searchOption)).Distinct().ToArray();
        }
    }
}