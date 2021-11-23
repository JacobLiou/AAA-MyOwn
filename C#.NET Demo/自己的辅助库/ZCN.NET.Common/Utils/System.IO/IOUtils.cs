using System.IO;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///  文件输入输入工具类
    /// </summary>
    public class IOUtils
    {
        /// <summary>
        ///  删除指定目录及其子目录以及所有文件
        /// </summary>
        /// <param name="targetDir">目标目录</param>
        public static void DeleteDirectory(string targetDir)
        {
            if (Directory.Exists(targetDir))
            {
                string[] files = Directory.GetFiles(targetDir);
                string[] dirs = Directory.GetDirectories(targetDir);

                foreach (string file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }

                foreach (string dir in dirs)
                {
                    DeleteDirectory(dir);
                }

                Directory.Delete(targetDir, false);
            }
        }

        /// <summary>
        ///  删除指定目录下的子目录以及所有文件
        /// </summary>
        /// <param name="targetDir">目标目录</param>
        public static void DeleteDirectoryChild(string targetDir)
        {
            if (Directory.Exists(targetDir))
            {
                string[] files = Directory.GetFiles(targetDir);
                string[] dirs = Directory.GetDirectories(targetDir);

                foreach (string file in files)
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }

                foreach (string dir in dirs)
                {
                    DeleteDirectory(dir);
                }
            }
        }
    }
}