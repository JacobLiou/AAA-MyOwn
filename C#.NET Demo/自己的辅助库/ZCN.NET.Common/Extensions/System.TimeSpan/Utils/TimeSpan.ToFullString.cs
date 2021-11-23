using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 将 TimeSpan 转换为具体的时间描述。例如：2天9小时22分钟17秒56毫秒
        /// </summary>
        /// <param name="timeSpan">扩展对象</param>
        /// <returns></returns>
        public static string ToFullString(this TimeSpan timeSpan)
        {
            string result = "";
            if (timeSpan.Days > 0)
            {
                result = timeSpan.Days + "天";
            }
            if (timeSpan.Hours > 0)
            {
                result += timeSpan.Hours + "小时";
            }
            if (timeSpan.Minutes > 0)
            {
                result += timeSpan.Hours + "分钟";
            }
            if (timeSpan.Seconds > 0)
            {
                result += timeSpan.Seconds + "秒";
            }
            if (timeSpan.Milliseconds > 0)
            {
                result += timeSpan.Milliseconds + "毫秒";
            }

            return result;
        }
    }
}