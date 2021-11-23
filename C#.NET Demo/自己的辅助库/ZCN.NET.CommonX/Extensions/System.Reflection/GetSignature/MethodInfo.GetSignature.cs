using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取方法的签名信息。包含名称，参数
        ///  (例如：GetPrice(int id))
        /// </summary>
        /// <param name="this">扩展对象。方法信息对象</param>
        /// <returns></returns>
        public static string GetSignature(this MethodInfo @this)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
            var sb = new StringBuilder();

            // 名称
            sb.Append(@this.Name);

            if(@this.IsGenericMethod)
            {
                sb.Append("<");

                Type[] arguments = @this.GetGenericArguments();

                sb.Append(string.Join(", ", arguments.Select(x => x.GetShortSignature())));

                sb.Append(">");
            }

            // 参数
            ParameterInfo[] parameters = @this.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(x => x.GetSignature())));
            sb.Append(")");

            return sb.ToString();
        }
    }
}