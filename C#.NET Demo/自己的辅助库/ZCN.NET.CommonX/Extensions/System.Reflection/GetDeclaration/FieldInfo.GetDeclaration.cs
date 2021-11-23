using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取字段的声明信息。包含可见性(public、protected、internal、private、
        ///  protected internal)，修饰符(const、static、readonly、volatile),类型，名称，赋值符号，结束符
        ///  (例如：private static int name = "张三";)
        /// </summary>
        /// <param name="this">扩展对象。字段信息对象</param>
        /// <returns></returns>
        public static string GetDeclaraction(this FieldInfo @this)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [PostModifier];
            var sb = new StringBuilder();

            // 是否是常量
            bool isConstant = false;
            Type[] requiredTypes = @this.GetRequiredCustomModifiers();

            // 可见性
            if(@this.IsPublic)
            {
                sb.Append("public ");
            }
            else if(@this.IsPrivate)
            {
                sb.Append("private ");
            }
            else if(@this.IsFamily)
            {
                sb.Append("protected ");
            }
            else if(@this.IsAssembly)
            {
                sb.Append("internal ");
            }
            else
            {
                sb.Append("protected internal ");
            }

            // 修饰符
            if(@this.IsStatic)
            {
                if(@this.IsLiteral)
                {
                    isConstant = true;
                    sb.Append("const ");
                }
                else
                {
                    sb.Append("static ");
                }
            }
            else if(@this.IsInitOnly)
            {
                sb.Append("readonly ");
            }
            if(requiredTypes.Any(x => x == typeof(IsVolatile)))
            {
                sb.Append("volatile ");
            }

            // 类型
            sb.Append(@this.FieldType.GetShortDeclaraction());
            sb.Append(" ");

            // 名称
            sb.Append(@this.Name);

            // 赋值符号，等号
            if(isConstant)
            {
                sb.Append(" = " + @this.GetRawConstantValue());
            }

            // 结尾
            sb.Append(";");

            return sb.ToString();
        }
    }
}