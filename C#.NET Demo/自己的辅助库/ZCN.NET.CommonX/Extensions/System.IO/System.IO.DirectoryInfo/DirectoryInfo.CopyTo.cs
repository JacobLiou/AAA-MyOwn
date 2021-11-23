using System.IO;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将一个目录下的所有文件复制到目标目录下
        /// </summary>
        /// <param name="obj">扩展对象。目录信息</param>
        /// <param name="destDirName">目标目录的名称</param>
        /// <param name="overwrite">如果目标目录下存在相同的文件，是否覆盖。若为 true，则允许覆盖现有文件；否则为 false</param>
        public static void CopyTo(this DirectoryInfo obj,string destDirName,bool overwrite = false)
        {
            obj.CopyTo(destDirName,"*.*",SearchOption.TopDirectoryOnly,overwrite);
        }

        /// <summary>
        ///  自定义扩展方法：将指定搜索模式搜索一个目录下的文件并复制到目标目录下
        /// </summary>
        /// <param name="obj">扩展对象。目录信息</param>
        /// <param name="destDirName">目标目录的名称</param>
        /// <param name="searchPattern">搜索模式字符串。例如，“System*”可用于搜索所有以单词“System”开头的目录</param>
        /// <param name="overwrite">如果目标目录下存在相同的文件，是否覆盖。若为 true，则允许覆盖现有文件；否则为 false</param>
        public static void CopyTo(this DirectoryInfo obj,string destDirName,string searchPattern,bool overwrite = false)
        {
            obj.CopyTo(destDirName,searchPattern,SearchOption.TopDirectoryOnly,overwrite);
        }

        /// <summary>
        ///  自定义扩展方法：将一个目录下的所有文件复制到目标目录下
        /// </summary>
        /// <param name="obj">扩展对象。目录信息</param>
        /// <param name="destDirName">目标目录的名称</param>
        /// <param name="searchOption">指定是搜索当前目录，还是搜索当前目录及其所有子目录</param>
        /// <param name="overwrite">如果目标目录下存在相同的文件，是否覆盖</param>
        public static void CopyTo(this DirectoryInfo obj,string destDirName,SearchOption searchOption,
            bool overwrite = false)
        {
            obj.CopyTo(destDirName,"*.*",searchOption);
        }

        /// <summary>
        ///  自定义扩展方法：将指定搜索模式搜索一个目录下的文件并复制到目标目录下
        /// </summary>
        /// <param name="obj">扩展对象。目录信息</param>
        /// <param name="destDirName">目标目录的名称</param>
        /// <param name="searchPattern">搜索模式字符串。例如，“System*”可用于搜索所有以单词“System”开头的目录</param>
        /// <param name="searchOption">指定是搜索当前目录，还是搜索当前目录及其所有子目录</param>
        /// <param name="overwrite">如果目标目录下存在相同的文件，是否覆盖。若为 true，则允许覆盖现有文件；否则为 false</param>
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
                    throw new System.Exception("目录不能为空！");
                }

                if(!directory.Exists)
                {
                    directory.Create();
                }

                file.CopyTo(outputFile,overwrite);//现有文件复制到新文件
            }

            // 确保空目录也被复制
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