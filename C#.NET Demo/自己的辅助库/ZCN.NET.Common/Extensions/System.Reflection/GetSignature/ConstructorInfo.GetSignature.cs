using System.Linq;
using System.Reflection;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取类的构造函数的签名信息。包含名称，参数信息
        ///  (例如：Product(string name,decimal price))
        /// </summary>
        /// <param name="this">扩展对象。构造函数信息对象</param>
        /// <returns></returns>
        public static string GetSignature(this ConstructorInfo @this)
        {
            // Example:  [Name] [<GenericArguments] ([Parameters])
            var sb = new StringBuilder();

            // Name
            sb.Append(@this.ReflectedType.IsGenericType
                ? @this.ReflectedType.Name.Substring(0, @this.ReflectedType.Name.IndexOf('`'))
                : @this.ReflectedType.Name);

            // Parameters
            ParameterInfo[] parameters = @this.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(x => x.GetSignature())));
            sb.Append(")");

            return sb.ToString();
        }
    }
}