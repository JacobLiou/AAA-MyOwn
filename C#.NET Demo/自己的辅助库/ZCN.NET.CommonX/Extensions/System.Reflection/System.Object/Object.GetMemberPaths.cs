using System;
using System.Collections.Generic;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：根据成员对象的全名称获取所有的成员信息
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="path">成员对象的全名称，例如 命名空间.类名.属性 等</param>
        /// <returns></returns>
        public static MemberInfo[] GetMemberPaths<T>(this T @this, string path)
        {
            Type lastType = @this.GetType();
            string[] paths = path.Split('.');

            var memberPaths = new List<MemberInfo>();

            foreach(string item in paths)
            {
                PropertyInfo propertyInfo = lastType.GetProperty(item);
                FieldInfo fieldInfo = lastType.GetField(item);

                if(propertyInfo != null)
                {
                    memberPaths.Add(propertyInfo);
                    lastType = propertyInfo.PropertyType;
                }
                if(fieldInfo != null)
                {
                    memberPaths.Add(fieldInfo);
                    lastType = fieldInfo.FieldType;
                }
            }

            return memberPaths.ToArray();
        }
    }
}