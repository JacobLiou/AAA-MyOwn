using System.Linq;
using System.Reflection;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取属性 Property 的签名信息。返回属性名称(例如：[Name | Indexer[Type]])
        /// </summary>
        /// <param name="this">扩展对象。属性 Property 信息对象</param>
        /// <returns></returns>
        public static string GetSignature(this PropertyInfo @this)
        {
            // Example: [Name | Indexer[Type]]

            var indexerParameter = @this.GetIndexParameters();
            if(indexerParameter.Length == 0)
            {
                // 名称
                return @this.Name;
            }
            var sb = new StringBuilder();

            // 索引器
            sb.Append(@this.Name);
            sb.Append("[");
            sb.Append(string.Join(", ", indexerParameter.Select(x => x.ParameterType.GetShortSignature())));
            sb.Append("]");

            return sb.ToString();
        }
    }
}