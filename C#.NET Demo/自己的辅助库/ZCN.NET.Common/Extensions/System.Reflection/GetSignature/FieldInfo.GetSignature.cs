using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取字段的签名信息。字段的名称
        /// </summary>
        /// <param name="this">扩展对象。字段信息对象</param>
        /// <returns></returns>
        public static string GetSignature(this FieldInfo @this)
        {
            return @this.Name;
        }
    }
}