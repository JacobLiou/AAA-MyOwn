using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������һ��Ŀ¼�µ������ļ����Ƶ�Ŀ��Ŀ¼��
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ</param>
        /// <param name="destDirName">Ŀ��Ŀ¼������</param>
        /// <param name="overwrite">���Ŀ��Ŀ¼�´�����ͬ���ļ����Ƿ񸲸ǡ���Ϊ true���������������ļ�������Ϊ false</param>
        public static void CopyTo(this DirectoryInfo obj,string destDirName,bool overwrite = false)
        {
            obj.CopyTo(destDirName,"*.*",SearchOption.TopDirectoryOnly,overwrite);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ������ģʽ����һ��Ŀ¼�µ��ļ������Ƶ�Ŀ��Ŀ¼��
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ</param>
        /// <param name="destDirName">Ŀ��Ŀ¼������</param>
        /// <param name="searchPattern">����ģʽ�ַ��������磬��System*�����������������Ե��ʡ�System����ͷ��Ŀ¼</param>
        /// <param name="overwrite">���Ŀ��Ŀ¼�´�����ͬ���ļ����Ƿ񸲸ǡ���Ϊ true���������������ļ�������Ϊ false</param>
        public static void CopyTo(this DirectoryInfo obj,string destDirName,string searchPattern,bool overwrite = false)
        {
            obj.CopyTo(destDirName,searchPattern,SearchOption.TopDirectoryOnly,overwrite);
        }

        /// <summary>
        ///  �Զ�����չ��������һ��Ŀ¼�µ������ļ����Ƶ�Ŀ��Ŀ¼��
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ</param>
        /// <param name="destDirName">Ŀ��Ŀ¼������</param>
        /// <param name="searchOption">ָ����������ǰĿ¼������������ǰĿ¼����������Ŀ¼</param>
        /// <param name="overwrite">���Ŀ��Ŀ¼�´�����ͬ���ļ����Ƿ񸲸�</param>
        public static void CopyTo(this DirectoryInfo obj,string destDirName,SearchOption searchOption,
            bool overwrite = false)
        {
            obj.CopyTo(destDirName,"*.*",searchOption);
        }

        /// <summary>
        ///  �Զ�����չ��������ָ������ģʽ����һ��Ŀ¼�µ��ļ������Ƶ�Ŀ��Ŀ¼��
        /// </summary>
        /// <param name="obj">��չ����Ŀ¼��Ϣ</param>
        /// <param name="destDirName">Ŀ��Ŀ¼������</param>
        /// <param name="searchPattern">����ģʽ�ַ��������磬��System*�����������������Ե��ʡ�System����ͷ��Ŀ¼</param>
        /// <param name="searchOption">ָ����������ǰĿ¼������������ǰĿ¼����������Ŀ¼</param>
        /// <param name="overwrite">���Ŀ��Ŀ¼�´�����ͬ���ļ����Ƿ񸲸ǡ���Ϊ true���������������ļ�������Ϊ false</param>
        public static void CopyTo(this DirectoryInfo obj,
            string destDirName,
            string searchPattern,
            SearchOption searchOption,
            bool overwrite = false)
        {
            var files = obj.GetFiles(searchPattern,searchOption);
            foreach(var file in files)
            {
                var outputFile = destDirName + file.FullName.Substring(obj.FullName.Length);
                var directory = new FileInfo(outputFile).Directory;

                if(directory == null)
                {
                    throw new System.Exception("Ŀ¼����Ϊ�գ�");
                }

                if(!directory.Exists)
                {
                    directory.Create();
                }

                file.CopyTo(outputFile,overwrite);//�����ļ����Ƶ����ļ�
            }

            // ȷ����Ŀ¼Ҳ������
            var directories = obj.GetDirectories(searchPattern,searchOption);
            foreach(var directory in directories)
            {
                var outputDirectory = destDirName + directory.FullName.Substring(obj.FullName.Length);
                var directoryInfo = new DirectoryInfo(outputDirectory);
                if(!directoryInfo.Exists)
                {
                    directoryInfo.Create();
                }
            }
        }
    }
}