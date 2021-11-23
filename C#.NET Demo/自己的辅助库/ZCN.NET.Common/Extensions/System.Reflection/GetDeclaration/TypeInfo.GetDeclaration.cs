using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取类或者接口的声明信息。包含可见性(public、protected、internal、private、
        ///  protected internal)，修饰符(abstract),类型(class、interface)，名称
        ///  (例如：public abstract class Product 等类似的声明)
        /// </summary>
        /// <param name="this">扩展对象。类或者接口信息对象</param>
        /// <returns></returns>
        public static string GetDeclaraction(this Type @this)
        {
            // Example: [Visibility] [Modifier] [Type] [Name] [<GenericArguments>] [:] [Inherited Class] [Inherited Interface]
            var sb = new StringBuilder();

            // Variable
            //bool hasInheritedClass = false;

            // 可见性
            sb.Append(@this.IsPublic ? "public " : "internal ");

            // 修饰符
            if(!@this.IsInterface && @this.IsAbstract)
            {
                sb.Append(@this.IsSealed ? "static " : "abstract ");
            }

            // 类型
            sb.Append(@this.IsInterface ? "interface " : "class ");

            // 名称
            sb.Append(@this.IsGenericType ? @this.Name.Substring(0,@this.Name.IndexOf('`')) : @this.Name);

            List<string> constraintType = new List<string>();

            // 泛型参数
            if(@this.IsGenericType)
            {
                Type[] arguments = @this.GetGenericArguments();
                sb.Append("<");
                sb.Append(string.Join(", ",
                    arguments.Select(x =>
                    {
                        GenericParameterAttributes sConstraints = x.GenericParameterAttributes;

                        if(GenericParameterAttributes.None != (sConstraints & GenericParameterAttributes.Contravariant))
                        {
                            sb.Append("in ");
                        }
                        if(GenericParameterAttributes.None != (sConstraints & GenericParameterAttributes.Covariant))
                        {
                            sb.Append("out ");
                        }

                        List<string> parameterConstraint = new List<string>();

                        if(GenericParameterAttributes.None !=
                           (sConstraints & GenericParameterAttributes.ReferenceTypeConstraint))
                        {
                            parameterConstraint.Add("class");
                        }


                        if(GenericParameterAttributes.None !=
                           (sConstraints & GenericParameterAttributes.DefaultConstructorConstraint))
                        {
                            parameterConstraint.Add("new()");
                        }


                        if(parameterConstraint.Count > 0)
                        {
                            constraintType.Add(x.Name + " : " + string.Join(", ",parameterConstraint));
                        }

                        return x.GetShortDeclaraction();
                    })));
                sb.Append(">");

                foreach(var argument in arguments)
                {
                    GenericParameterAttributes sConstraints = argument.GenericParameterAttributes &
                                                              GenericParameterAttributes.SpecialConstraintMask;
                }
            }

            List<string> constaints = new List<string>();

            // Inherited Class
            if(@this.BaseType != null && @this.BaseType != typeof(object))
            {
                constaints.Add(@this.BaseType.GetShortDeclaraction());
            }

            // Inherited Interface
            Type[] interfaces = @this.GetInterfaces();
            if(interfaces.Length > 0)
            {
                constaints.AddRange(interfaces.Select(x => x.Name));
            }

            if(constaints.Count > 0)
            {
                sb.Append(" : ");
                sb.Append(string.Join(", ",constaints));
            }

            if(constraintType.Count > 0)
            {
                sb.Append(" where ");
                sb.Append(string.Join(", ",constraintType));
            }

            return sb.ToString();
        }
    }
}