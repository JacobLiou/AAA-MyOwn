using System;
using System.IO;
using System.Reflection;
using System.Text;

using ZCN.NET.Common.Extensions;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///   文件操作辅助工具类
    /// </summary>
    public static class FileUtils
    {
        /// <summary>
        ///   从嵌入资源中读取文件内容。如果文件不存在则返回 null
        /// </summary>
        /// <param name="fileFullName">嵌入资源文件名，包括项目的命名空间.</param>
        /// <returns>资源中的文件内容.</returns>
        public static string ReadFileFromEmbedded(string fileFullName)
        {
            string result = null;

            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(fileFullName);
            if (stream != null)
            {
                using (TextReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }

        /// <summary>
        ///  读取文件的全部内容，并返回字符串
        /// </summary>
        /// <param name="filePath">文件名称，包含全路径</param>
        /// <returns>文件的内容，字符串形式</returns>
        public static string ReadFileContent(string filePath)
        {
            if (filePath.IsNullOrWhiteSpace())
            {
                return string.Empty;
            }

            // 读取选中文件内容的所有行
            string[] codes = File.ReadAllLines(filePath);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < codes.Length; i++)
            {
                sb.AppendLine(codes[i]);
            }

            return sb.ToString();
        }

        /// <summary>
        ///  判断文件是否被打开或被其他程序使用中。
        ///  true 表示文件被打开或被其他程序使用中，false 没有没有。 
        /// </summary>
        /// <param name="filePath">带检测的文件名称，包含绝对路径</param>
        /// <param name="msg">检测的结果信息</param>
        /// <returns></returns>
        public static bool CheckFileIsOpenOrInUse(string filePath, out string msg)
        {
            msg = String.Empty;
            if (!File.Exists(filePath))
            {
                msg = "文件不存在。";
                return false;
            }

            bool isOpenOrInUse = true;

            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
              
                isOpenOrInUse = false;
                msg = "文件状态正常，未被打开且未被其他程序使用。";
            }
            catch
            {
            }
            finally
            {
                fs?.Close();
                msg = "文件被打开或被其他程序使用中。";
            }

            return isOpenOrInUse;
        }

    }
}