using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToGuid

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回全为0的标识符。
        ///  如果转换失败则返回 Guid 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>与 value 等效的全局唯一标识符</returns>
        public static Guid ToGuid(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return Guid.Empty;
            }

            try
            {
                return new Guid(@this.ToString());
            }
           catch (System.Exception)
            {
                return default(Guid);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回全为0的标识符。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的全局唯一标识符</returns>
        public static Guid ToGuid(this object @this,Guid defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return Guid.Empty;
            }

            try
            {
                return new Guid(@this.ToString());
            }
           catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回全为0的标识符。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的全局唯一标识符</returns>
        public static Guid ToGuid(this object @this,Func<Guid> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return Guid.Empty;
            }

            try
            {
                return new Guid(@this.ToString());
            }
           catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToGuidNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 Guid 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>与 value 等效的全局唯一标识符 或 null</returns>
        public static Guid? ToGuidNullable(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return new Guid(@this.ToString());
            }
           catch (System.Exception)
            {
                return default(Guid);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的全局唯一标识符 或 null</returns>
        public static Guid? ToGuidNullable(this object @this,Guid? defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return new Guid(@this.ToString());
            }
           catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的全局唯一标识符 或 null</returns>
        public static Guid? ToGuidNullable(this object @this,Func<Guid?> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return new Guid(@this.ToString());
            }
           catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}