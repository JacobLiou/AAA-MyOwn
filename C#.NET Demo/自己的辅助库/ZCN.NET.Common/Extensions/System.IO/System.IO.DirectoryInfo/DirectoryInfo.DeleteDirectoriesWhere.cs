using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ����������ָ��������ɾ����ǰĿ¼�µ�Ŀ¼��
        ///  ����� System.IO.DirectoryInfo Ϊ�գ���ɾ����
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="predicate">��������</param>
        public static void DeleteDirectoriesWhere(this DirectoryInfo obj,Func<DirectoryInfo,bool> predicate)
        {
            obj.GetDirectories().Where(predicate).ForEach(x => x.Delete());
        }

        /// <summary>
        ///  �Զ�����չ����������ָ��������ɾ��Ŀ¼�Լ���Ŀ¼�µ�Ŀ¼��
        ///  ����� System.IO.DirectoryInfo Ϊ�գ���ɾ����
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ����</param>
        /// <param name="predicate">��������</param>
        /// <param name="searchOption">ָ����������ǰĿ¼������������ǰĿ¼����������Ŀ¼</param>
        public static void DeleteDirectoriesWhere(this DirectoryInfo obj,
            Func<DirectoryInfo,bool> predicate,SearchOption searchOption)
        {
            obj.GetDirectories("*.*",searchOption).Where(predicate).ForEach(x => x.Delete());
        }
    }
}