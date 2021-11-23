using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  将指定 64 位有符号整数（它包含 OLE 自动化货币值）转换为等效的 <see cref="T:System.Decimal" /> 值
        /// </summary>
        /// <param name="cy"></param>
        /// <returns></returns>
        public static decimal FromOACurrency(this Int64 cy)
        {
            return Decimal.FromOACurrency(cy);
        }
    }
}