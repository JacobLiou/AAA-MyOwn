using System;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///   控制台程序的工具类
    /// </summary>
    public class ConsoleUtils
    {
        #region 彩色控制台输出

        /// <summary>
        ///     写入一行错误信息【红色字体，黑色背景】
        /// </summary>
        /// <param name="text">文本内容</param>
        public static void WriteError(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ResetColor();
        }

        /// <summary>
        ///     写入一行错误信息【红色字体，黑色背景】，并换行
        /// </summary>
        /// <param name="text">文本</param>
        public static void WriteLineError(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        ///     写入一行警告信息【黄色字体，黑色背景】
        /// </summary>
        /// <param name="text">文本内容</param>
        /// 时间：2016/9/2 17:30
        /// 备注：
        public static void WriteWarn(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(text);
            Console.ResetColor();
        }

        /// <summary>
        ///     写入一行警告信息【黄色字体，黑色背景】，并换行
        /// </summary>
        /// <param name="text">文本内容</param>
        public static void WriteLineWarn(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        ///     写入一行信息【绿色字体，黑色背景】
        /// </summary>
        /// <param name="text">文本内容</param>
        public static void WriteInfo(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ResetColor();
        }

        /// <summary>
        ///     写入一行信息【绿色字体，黑色背景】，并换行
        /// </summary>
        /// <param name="text">文本内容</param>
        public static void WriteLineInfo(string text)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        /// <summary>
        ///     写入一行【自定义字体颜色(默认白色)，黑色背景】
        /// </summary>
        /// <param name="text">文本内容</param>
        /// <param name="color">文本颜色。默认白色</param>
        /// <param name="backgroundColor">控制台北京颜色，默认黑色</param>
        public static void Write(string text, ConsoleColor color = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        /// <summary>
        ///     写入一行【自定义字体颜色(默认白色)，黑色背景】，并换行
        /// </summary>
        /// <param name="text">文本内容</param>
        /// <param name="color">文本颜色。默认白色</param>
        /// <param name="backgroundColor">控制台北京颜色，默认黑色</param>
        public static void WriteLine(string text, ConsoleColor color = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.Black)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        #endregion
    }
}