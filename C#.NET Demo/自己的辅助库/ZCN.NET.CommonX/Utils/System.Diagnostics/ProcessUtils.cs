using System;
using System.Diagnostics;
using System.IO;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///   系统进程操作工具类
    /// </summary>
    public class ProcessUtils
    {
        /// <summary>
        ///   检测指定的程序是否已经正在运行
        /// </summary>
        /// <param name="appName">应用程序名称(提示：传递的参数是软件发布后，用户使用软件时双击的 exe 文件名称)</param>
        /// <returns></returns>
        public static bool CheckAppIsRunning(string appName)
        {
            Process[] app = Process.GetProcessesByName(appName);
            return app.Length > 1;
        }

        /// <summary>
        ///  以管理员身份运行指定路径的应用程序
        /// </summary>
        /// <param name="fileName">应用程序名称，包含全路径</param>
        public static void RunAsAdministrator(string fileName)
        {
            //创建启动对象
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = fileName,
                Verb = "runas"
            };

            //设置启动动作,确保以管理员身份运行
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        ///  打开指定的目录(仅限本地操作系统)
        /// </summary>
        /// <param name="path">目录</param>
        /// <returns></returns>
        public static void OpenDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new Exception("指定的路径或目录不存在。");
            }
            else
            {
                Process.Start("Explorer.exe", path);
            }
        }
    }
}