using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region Equal

        /// <summary>
        /// 自定义扩展方法：判断扩展对象与目标对象是否不相等
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="objTarget">目标对象</param>
        /// <returns></returns>
        public static Boolean NotEquals(this object @this,object objTarget)
        {
            return object.Equals(@this,objTarget) == false;
        }

        #endregion

        #region ReferenceEquals

        /// <summary>
        /// 自定义扩展方法：判断扩展对象实例与目标对象实例是否相同
        /// </summary>
        /// <param name="this"></param>
        /// <param name="objTarget">目标对象</param>
        /// <returns></returns>
        public static bool ReferenceEquals(this object @this,object objTarget)
        {
            return object.ReferenceEquals(@this,objTarget);
        }

        #endregion
    }
}