using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
       
        #region IsEmpty

        /// <summary>
        ///  自定义扩展方法：判断数组是否为 null 或者元素数量等于0
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this Array @this)
        {
            return @this == null || @this.Length == 0;
        }

        /// <summary>
        ///  自定义扩展方法：判断数组是否不为 null 且元素数量大于0。
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool IsNotNullAndEmpty(this Array @this)
        {
            return @this != null && @this.Length > 0;
        }

        #endregion

        
    }
}