using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region LessThan
        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否小于目标值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="targetValue">目标比较值</param>
        /// <returns></returns>
        public static bool LessThan(this Int16 @this,Int16 targetValue) 
        {
            return @this.CompareTo(targetValue) < 0;
        }

        /// <summary>
        /// 自定义扩展方法：判断扩展对象的值是否小于等于目标值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="targetValue">目标比较值</param>
        /// <returns></returns>
        public static bool LessThanEqual(this Int16 @this,Int16 targetValue)
        {
            return @this.CompareTo(targetValue) <= 0;
        }
        #endregion
    }
}