using System.Linq;
using System.Reflection;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取类的构造函数的声明信息。包含可见性(public、protected、internal、private、
        ///  protected internal)，名称，参数信息
        ///  (例如：public Product(string name,decimal price))
        /// </summary>
        /// <param name="this">扩展对象。构造函数信息对象</param>
        /// <returns></returns>
        public static string GetDeclaraction(this ConstructorInfo @this)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
            var sb = new StringBuilder();

            // 可见性
            if (@this.IsPublic)
            {
                sb.Append("public ");
            }
            else if (@this.IsFamily)
            {
                sb.Append("protected ");
            }
            else if (@this.IsAssembly)
            {
                sb.Append("internal ");
            }
            else if (@this.IsPrivate)
            {
                sb.Append("private ");
            }
            else
            {
                sb.Append("protected internal ");
            }

            // 名称
            sb.Append(@this.ReflectedType.IsGenericType
                      ? @this.ReflectedType.Name.Substring(0, @this.ReflectedType.Name.IndexOf('`'))
                      : @this.ReflectedType.Name);

            // 参数
            ParameterInfo[] parameters = @this.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ", parameters.Select(x => x.GetDeclaraction())));
            sb.Append(")");

            return sb.ToString();
        }
    }
}