using System;
using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：获取有关成员的声明信息
        /// </summary>
        /// <param name="this">扩展对象。成员信息对象</param>
        /// <returns></returns>
        public static string GetDeclaraction(this MemberInfo @this)
        {
            switch(@this.MemberType)
            {
                case MemberTypes.Field:
                    return ((FieldInfo)@this).GetDeclaraction();
                case MemberTypes.Property:
                    return ((PropertyInfo)@this).GetDeclaraction();
                case MemberTypes.Constructor:
                    return ((ConstructorInfo)@this).GetDeclaraction();
                case MemberTypes.Method:
                    return ((MethodInfo)@this).GetDeclaraction();
                case MemberTypes.TypeInfo:
                    return ((Type)@this).GetDeclaraction();
                case MemberTypes.NestedType:
                    return ((Type)@this).GetDeclaraction();
                case MemberTypes.Event:
                    return ((EventInfo)@this).GetDeclaraction();
                default:
                    return null;
            }
        }
    }
}