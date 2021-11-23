using System;
using System.IO;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {

        /// <summary>
        ///  自定义扩展方法：从目录中删除早于指定时间间隔的目录与文件
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="timeSpan">指定的时间间隔</param>
        public static void DeleteOlderThan(this DirectoryInfo obj,TimeSpan timeSpan)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories().Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
        }

        /// <summary>
        ///  自定义扩展方法：从目录中删除早于指定时间间隔的目录与文件
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="timeSpan">指定的时间间隔</param>
        /// <param name="searchOption">搜索文件的方式</param>
        public static void DeleteOlderThan(this DirectoryInfo obj,TimeSpan timeSpan,SearchOption searchOption)
        {
            DateTime minDate = DateTime.Now.Subtract(timeSpan);
            obj.GetFiles("*.*",searchOption).Where(x => x.LastWriteTime < minDate).ToList().ForEach(x => x.Delete());
            obj.GetDirectories("*.*",searchOption)
               .Where(x => x.LastWriteTime < minDate)
               .ToList()
               .ForEach(x => x.Delete());
        }
    }
}