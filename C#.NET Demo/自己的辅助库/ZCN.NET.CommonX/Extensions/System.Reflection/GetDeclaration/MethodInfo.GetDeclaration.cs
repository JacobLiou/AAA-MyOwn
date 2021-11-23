using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取方法的声明信息。包含可见性(public、protected、internal、private、
        ///  protected internal)，修饰符(abstract、override、virtual、static),类型，名称，参数
        ///  (例如：public static int GetPrice(int id))
        /// </summary>
        /// <param name="this">扩展对象。方法信息对象</param>
        /// <returns></returns>
        public static string GetDeclaraction(this MethodInfo @this)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments] ([Parameters])
            var sb = new StringBuilder();

            // 可见性
            if(@this.IsPublic)
            {
                sb.Append("public ");
            }
            else if(@this.IsFamily)
            {
                sb.Append("protected ");
            }
            else if(@this.IsAssembly)
            {
                sb.Append("internal ");
            }
            else if(@this.IsPrivate)
            {
                sb.Append("private ");
            }
            else
            {
                sb.Append("protected internal ");
            }

            // 修饰符
            if(@this.IsAbstract)
            {
                sb.Append("abstract ");
            }
            else if(@this.GetBaseDefinition().DeclaringType != @this.DeclaringType)
            {
                sb.Append("override ");
            }
            else if(@this.IsVirtual)
            {
                sb.Append("virtual ");
            }
            else if(@this.IsStatic)
            {
                sb.Append("static ");
            }

            // 类型
            sb.Append(@this.ReturnType.GetShortDeclaraction());
            sb.Append(" ");

            // 名称
            sb.Append(@this.Name);

            if(@this.IsGenericMethod)
            {
                sb.Append("<");

                Type[] arguments = @this.GetGenericArguments();

                sb.Append(string.Join(", ",arguments.Select(x => x.GetShortDeclaraction())));

                sb.Append(">");
            }

            // 参数
            ParameterInfo[] parameters = @this.GetParameters();
            sb.Append("(");
            sb.Append(string.Join(", ",parameters.Select(x => x.GetDeclaraction())));
            sb.Append(")");

            return sb.ToString();
        }
    }
}