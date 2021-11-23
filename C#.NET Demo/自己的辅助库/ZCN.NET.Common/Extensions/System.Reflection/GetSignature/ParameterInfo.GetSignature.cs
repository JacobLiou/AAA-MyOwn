using System;
using System.Reflection;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取参数的签名信息。返回参数的名字
        /// </summary>
        /// <param name="this">扩展对象。参数信息对象</param>
        /// <returns></returns>
        public static string GetSignature(this ParameterInfo @this)
        {
            var sb = new StringBuilder();

            @this.GetSignature(sb);
            return sb.ToString();
        }

        internal static void GetSignature(this ParameterInfo @this, StringBuilder sb)
        {
            // retval attribute

            string typeName;
            Type elementType = @this.ParameterType.GetElementType();

            if(elementType != null)
            {
                typeName = @this.ParameterType.Name.Replace(elementType.Name, elementType.GetShortSignature());
            }
            else
            {
                typeName = @this.ParameterType.GetShortSignature();
            }

            if(@this.IsOut)
            {
                if(typeName.Contains("&"))
                {
                    typeName = typeName.Replace("&", "");
                    sb.Append("out ");
                }
            }
            else if(@this.ParameterType.IsByRef)
            {
                typeName = typeName.Replace("&", "");
                sb.Append("ref ");
            }
            sb.Append(typeName);
        }
    }
}