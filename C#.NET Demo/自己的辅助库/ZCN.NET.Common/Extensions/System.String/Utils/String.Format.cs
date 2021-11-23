namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// 自定义扩展方法：将指定字符串中的一个或多个格式项替换为指定对象的字符串表示形式
        /// </summary>
        /// <param name="this">复合格式字符串</param>
        /// <param name="arg0">要设置格式的对象</param>
        /// <returns>@this 的副本，其中的任何格式项均替换为 arg0 的字符串表示形式</returns>
        public static string Format(this string @this, object arg0)
        {
            return string.Format(@this, arg0);
        }

        /// <summary>
        /// 自定义扩展方法： 将指定字符串中的格式项替换为两个指定对象的字符串表示形式
        /// </summary>
        /// <param name="this">复合格式字符串</param>
        /// <param name="arg0">要设置格式的第一个对象</param>
        /// <param name="arg1">要设置格式的第二个对象</param>
        /// <returns>@this 的副本，其中的格式项替换为 arg0 和 arg1 的字符串表示形式</returns>
        public static string Format(this string @this, object arg0, object arg1)
        {
            return string.Format(@this, arg0, arg1);
        }

        /// <summary>
        /// 自定义扩展方法： 将指定字符串中的格式项替换为三个指定对象的字符串表示形式
        /// </summary>
        /// <param name="this">复合格式字符串</param>
        /// <param name="arg0">要设置格式的第一个对象</param>
        /// <param name="arg1">要设置格式的第二个对象</param>
        /// <param name="arg2">要设置格式的第三个对象</param>
        /// <returns>@this 的副本，其中的格式项已替换为 arg0、arg1 和 arg2 的字符串表示形式</returns>
        public static string Format(this string @this, object arg0, object arg1, object arg2)
        {
            return string.Format(@this, arg0, arg1, arg2);
        }

        /// <summary>
        ///  自定义扩展方法： 将指定字符串中的格式项替换为指定数组中相应对象的字符串表示形式
        /// </summary>
        /// <param name="this">复合格式字符串</param>
        /// <param name="args">一个对象数组，其中包含零个或多个要设置格式的对象</param>
        /// <returns>@this 的副本，其中的格式项已替换为 args 中相应对象的字符串表示形式</returns>
        public static string Format(this string @this, object[] args)
        {
            return string.Format(@this, args);
        }
    }
}