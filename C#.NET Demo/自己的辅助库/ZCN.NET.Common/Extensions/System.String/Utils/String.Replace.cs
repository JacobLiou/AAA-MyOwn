using System;
using System.Collections.Generic;
using System.Linq;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region Replace

        /// <summary>
        ///  自定义扩展方法：从指定的位置开始查找指定长度的内容并新的值替换掉
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="startIndex">开始位置</param>
        /// <param name="length">指定长度</param>
        /// <param name="value">替换的内容</param>
        /// <returns>替换后的字符串</returns>
        public static string Replace(this string @this, int startIndex, int length, string value)
        {
            @this = @this.Remove(startIndex, length).Insert(startIndex, value);

            return @this;
        }

        #endregion

        #region ReplaceFirst

        /// <summary>
        /// 自定义扩展方法：使用新值替换字符串中第一次出现的旧值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="oldValue">旧值</param>
        /// <param name="newValue">新值</param>
        /// <returns></returns>
        public static string ReplaceFirst(this string @this, string oldValue, string newValue)
        {
            int startIndex = @this.IndexOf(oldValue);
            if (startIndex == -1)
                return @this;

            return @this.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);
        }


        /// <summary>
        /// 自定义扩展方法：使用新值替换字符串中第一个到指定数量的旧值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="number">数量</param>
        /// <param name="oldValue">旧值</param>
        /// <param name="newValue">新值</param>
        /// <returns></returns>
        public static string ReplaceFirst(this string @this, int number, string oldValue, string newValue)
        {
            List<string> list = @this.Split(oldValue).ToList();
            int old = number + 1;
            IEnumerable<string> listStart = list.Take(old);
            IEnumerable<string> listEnd = list.Skip(old);

            return string.Join(newValue, listStart) +
                   (listEnd.Any() ? oldValue : string.Empty) +
                   string.Join(oldValue, listEnd);
        }

        #endregion

        #region ReplaceLast

        /// <summary>
        /// 自定义扩展方法：使用新值替换字符串中最后一次出现的旧值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="oldValue">旧值</param>
        /// <param name="newValue">新值</param>
        /// <returns></returns>
        public static string ReplaceLast(this string @this, string oldValue, string newValue)
        {
            int startIndex = @this.LastIndexOf(oldValue);
            if (startIndex == -1)
                return @this;

            return @this.Remove(startIndex, oldValue.Length).Insert(startIndex, newValue);
        }

        /// <summary>
        /// 自定义扩展方法：使用新值替换字符串中指定数量到最后一个的旧值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="number">数量</param>
        /// <param name="oldValue">旧值</param>
        /// <param name="newValue">新值</param>
        public static string ReplaceLast(this string @this, int number, string oldValue, string newValue)
        {
            List<string> list = @this.Split(oldValue).ToList();
            int old = Math.Max(0, list.Count - number - 1);
            IEnumerable<string> listStart = list.Take(old);
            IEnumerable<string> listEnd = list.Skip(old);

            return string.Join(oldValue, listStart) +
                   (old > 0 ? oldValue : string.Empty) +
                   string.Join(newValue, listEnd);
        }

        #endregion

        #region ReplaceWhenEquals

        /// <summary>
        ///  自定义扩展方法：当扩展对象的值与旧值相等时替换为新值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="oldValue">旧值</param>
        /// <param name="newValue">新值</param>
        /// <returns></returns>
        public static string ReplaceWhenEquals(this string @this, string oldValue, string newValue)
        {
            return @this == oldValue ? newValue : @this;
        }
        #endregion
    }
}