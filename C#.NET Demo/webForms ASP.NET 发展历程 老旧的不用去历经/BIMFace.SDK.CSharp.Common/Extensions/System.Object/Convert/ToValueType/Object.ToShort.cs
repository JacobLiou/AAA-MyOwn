using System;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToShort

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 short 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short ToShort(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt16(@this);
            }
           catch(System.Exception)
            {
                return default(short);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short ToShort(this object @this,short defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short ToShort(this object @this,Func<short> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToToToShortNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 short 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short? ToShortNullable(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt16(@this);
            }
           catch(System.Exception)
            {
                return default(short);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short? ToShortNullable(this object @this,short defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位有符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位有符号整数</returns>
        public static short? ToShortNullable(this object @this,Func<short> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToUShort

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回 short 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort ToUShort(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt16(@this);
            }
           catch(System.Exception)
            {
                return default(ushort);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort ToUShort(this object @this,ushort defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort ToUShort(this object @this,Func<ushort> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return 0;
            }

            try
            {
                return Convert.ToUInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToUShortNullable
        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 short 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort? ToUShortNullable(this object @this)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt16(@this);
            }
           catch(System.Exception)
            {
                return default(ushort);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回0。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort? ToUShortNullable(this object @this,ushort defaultValue)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValue;
            }
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为16位无符号整数。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>一个等于 value 的 16位无符号整数</returns>
        public static ushort? ToUShortNullable(this object @this,Func<ushort> defaultValueFactory)
        {
            if(@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToUInt16(@this);
            }
           catch(System.Exception)
            {
                return defaultValueFactory();
            }
        }
        #endregion
    }
}