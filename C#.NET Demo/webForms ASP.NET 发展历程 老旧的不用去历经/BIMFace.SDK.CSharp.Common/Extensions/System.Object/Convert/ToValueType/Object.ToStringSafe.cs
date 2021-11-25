using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToStringExtend

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为其等效的字符串表示形式。
        ///  如果 value 为 null 或者 DBNull，则此方法返回空字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>等效的字符串</returns>
        public static string ToString2(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return string.Empty;
            }

            return @this.ToString();
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为其等效的字符串表示形式
        ///  如果 value 为 null 或者 DBNull，则此方法返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">默认值</param>
        /// <returns>等效的字符串</returns>
        public static string ToString2(this object @this,string defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return defaultValue;
            }

            return @this.ToString();
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为其等效的字符串表示形式
        ///  如果 value 为 null 或者 DBNull，则此方法返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">默认值(产生默认值的方法)</param>
        /// <returns>等效的字符串</returns>
        public static string ToString2(this object @this,Func<string> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return defaultValueFactory();
            }

            return @this.ToString();
        }

        #endregion
    }
}