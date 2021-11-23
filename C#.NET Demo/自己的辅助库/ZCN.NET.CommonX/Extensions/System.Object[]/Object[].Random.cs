using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取指定数组中随机的一个值。如果数组为 null 或者 长度为0，则返回 null
        /// </summary>
        /// <param name="args">要确定其类型的对象数组</param>
        public static object Random(this object[] args)
        {
            if (args == null || args.Length == 0)
                return null;

            return args[new Random().Next(args.Length)];
        }

        /// <summary>
        ///  自定义扩展方法：获取指定数组中随机的一个值。如果数组为 null 或者 长度为0，则返回 null
        /// </summary>
        /// <param name="args">要确定其类型的对象数组</param>
        /// <param name="random">随机对象</param>
        public static object Random(this object[] args, Random random)
        {
            if (args == null || args.Length == 0)
                return null;

            return args[random.Next(args.Length)];
        }
    }
}