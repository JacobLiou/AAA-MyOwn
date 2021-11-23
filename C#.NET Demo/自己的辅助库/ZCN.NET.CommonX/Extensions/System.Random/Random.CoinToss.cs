using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：掷硬币的随机延伸法，随机返回 true 或者 false
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static bool CoinToss(this Random @this)
        {
            return @this.Next(2) == 0;
        }
    }
}