using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取参数的声明信息
        /// </summary>
        /// <param name="this">扩展对象。参数信息对象</param>
        /// <returns></returns>
        public static string GetDeclaraction(this ParameterInfo @this)
        {
            var sb = new StringBuilder();
            @this.GetDeclaraction(sb);
            return sb.ToString();
        }

        internal static void GetDeclaraction(this ParameterInfo @this,StringBuilder sb)
        {
            // retval attribute
            var attributes = new List<string>();

            string typeName;
            Type elementType = @this.ParameterType.GetElementType();

            if(elementType != null)
            {
                typeName = @this.ParameterType.Name.Replace(elementType.Name,elementType.GetShortDeclaraction());
            }
            else
            {
                typeName = @this.ParameterType.GetShortDeclaraction();
            }


            if(Attribute.IsDefined(@this,typeof(ParamArrayAttribute)))
            {
                sb.Append("params ");
            }
            else if(@this.Position == 0 && @this.Member.IsDefined(typeof(ExtensionAttribute)))
            {
                sb.Append("this ");
            }

            if(@this.IsIn)
            {
                attributes.Add("In");
            }
            if(@this.IsOut)
            {
                if(typeName.Contains("&"))
                {
                    typeName = typeName.Replace("&","");
                    sb.Append("out ");
                }
                else
                {
                    attributes.Add("Out");
                }
            }
            else if(@this.ParameterType.IsByRef)
            {
                typeName = typeName.Replace("&","");
                sb.Append("ref ");
            }
            sb.Append(typeName);

            sb.Append(" ");
            sb.Append(@this.Name);

            if(@this.IsOptional)
            {
                if(@this.DefaultValue != Missing.Value)
                {
                    sb.Append(" = " + @this.DefaultValue);
                }
                else
                {
                    attributes.Add("Optional");
                }
            }


            string attribute = attributes.Count > 0 ? "[" + string.Join(", ",attributes) + "] " : "";
            sb.Insert(0,attribute);
        }
    }
}