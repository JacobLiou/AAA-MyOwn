using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToSingle

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的单精度浮点数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 float 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>与 value 等效的单精度浮点数，如果 value 为 null，则为 0（零）</returns>
        public static float ToSingle(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToSingle(@this);
            }
           catch(System.Exception)
            {
                return default(float);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的单精度浮点数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的单精度浮点数，如果 value 为 null，则为 0（零）</returns>
        public static float ToSingle(this object @this,float defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToSingle(@this);
            }
           catch(System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的单精度浮点数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的单精度浮点数，如果 value 为 null，则为 0（零）</returns>
        public static float ToSingle(this object @this,Func<float> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToSingle(@this);
            }
           catch(System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToSingleNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的单精度浮点数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 float 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>与 value 等效的单精度浮点数 或 null</returns>
        public static float? ToSingleNullable(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToSingle(@this);
            }
           catch(System.Exception)
            {
                return default(float);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的单精度浮点数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的单精度浮点数 或 null</returns>
        public static float? ToSingleNullable(this object @this,float? defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToSingle(@this);
            }
           catch(System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的单精度浮点数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的单精度浮点数 或 null</returns>
        public static float? ToSingleNullable(this object @this,Func<float?> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToSingle(@this);
            }
           catch(System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}