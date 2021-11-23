using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法： 搜索具有指定名称的公共属性或字段。
        ///  返回具有指定名称的公共属性或字段；如果找不到则返回 null
        /// </summary>
        /// <typeparam name="T">泛型类型参数</typeparam>
        /// <param name="this">扩展对象</param>
        /// <param name="name">要获取的公共属性或字段的名称</param>
        /// <returns></returns>
        public static MemberInfo GetPropertyOrField<T>(this T @this,string name)
        {
            PropertyInfo property = @this.GetProperty(name);
            if(property != null)
            {
                return property;
            }

            FieldInfo field = @this.GetField(name);
            if(field != null)
            {
                return field;
            }

            return null;
        }
    }
}