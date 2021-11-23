using System;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取有关成员的签名信息
        /// </summary>
        /// <param name="this">扩展对象。成员信息对象</param>
        /// <returns></returns>
        public static string GetSignature(this MemberInfo @this)
        {
            switch(@this.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo) @this).GetSignature();
                case MemberTypes.Property:
                    return ((PropertyInfo) @this).GetSignature();
                case MemberTypes.Constructor:
                    return ((ConstructorInfo) @this).GetSignature();
                case MemberTypes.Method:
                    return ((MethodInfo) @this).GetSignature();
                case MemberTypes.TypeInfo:
                    return ((Type) @this).GetSignature();
                case MemberTypes.NestedType:
                    return ((Type) @this).GetSignature();
                case MemberTypes.Event:
                    return ((EventInfo) @this).GetSignature();
                default:
                    return null;
            }
        }
    }
}