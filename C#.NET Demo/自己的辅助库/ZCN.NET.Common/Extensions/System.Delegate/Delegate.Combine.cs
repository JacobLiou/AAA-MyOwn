using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将两个委托的调用列表连接在一起。
        ///  返回一个新委托，它的调用列表将 a 和 b 的调用列表按该顺序连接在一起。
        ///  如果 b 为 null，则返回 a，
        ///  如果 a 为 null，则返回 b，
        ///  如果 a 和 b 均为空引用，则返回空引用
        /// </summary>
        /// <param name="a">扩展对象。最先出现其调用列表的委托</param>
        /// <param name="b">最后出现其调用列表的委托</param>
        /// <returns></returns>
        public static Delegate Combine(this Delegate a,Delegate b)
        {
            return Delegate.Combine(a,b);
        }
    }
}