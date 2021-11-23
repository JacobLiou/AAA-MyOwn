using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定 Windows 文件时间转换为等效的本地时间
        /// </summary>
        /// <param name="fileTime">扩展对象。以计时周期表示的 Windows 文件时间</param>
        /// <returns></returns>
        public static DateTime FromFileTime(this Int64 fileTime)
        {
            return DateTime.FromFileTime(fileTime);
        }
    }
}