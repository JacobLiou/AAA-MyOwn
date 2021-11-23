using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToGuid

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回全为0的标识符。
        ///  如果转换失败则返回 Guid 类型的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>与 value 等效的全局唯一标识符</returns>
        public static Guid ToGuid(this object value)
        {
            if (value.IsDBNullOrNull())
                return Guid.Empty;

            try
            {
                Guid.TryParse(value.ToString(), out Guid result);
                return result;
            }
            catch
            {
                return default(Guid);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回全为0的标识符。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的全局唯一标识符</returns>
        public static Guid ToGuid(this object value, Guid defaultValue)
        {
            if (value.IsDBNullOrNull())
                return Guid.Empty;

            try
            {
                Guid.TryParse(value.ToString(), out Guid result);
                return result;
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回全为0的标识符。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的全局唯一标识符</returns>
        public static Guid ToGuid(this object value, Func<Guid> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return Guid.Empty;

            try
            {
                Guid.TryParse(value.ToString(), out Guid result);
                return result;

                //return new Guid(value.ToString());
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToGuidNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns>与 value 等效的全局唯一标识符 或 null</returns>
        public static Guid? ToGuidNullable(this object value)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                Guid.TryParse(value.ToString(), out Guid result);
                return result;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>与 value 等效的全局唯一标识符 或 null</returns>
        public static Guid? ToGuidNullable(this object value, Guid? defaultValue)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                Guid.TryParse(value.ToString(), out Guid result);
                return result;
            }
            catch
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象(一般是指从IDataReader、DataTable、DataRow、HashTable等集合中获取的列或者项的基础数据类型)的值转换为等效的全局唯一标识符。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>与 value 等效的全局唯一标识符 或 null</returns>
        public static Guid? ToGuidNullable(this object value, Func<Guid?> defaultValueFactory)
        {
            if (value.IsDBNullOrNull())
                return null;

            try
            {
                Guid.TryParse(value.ToString(), out Guid result);
                return result;
            }
            catch
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}