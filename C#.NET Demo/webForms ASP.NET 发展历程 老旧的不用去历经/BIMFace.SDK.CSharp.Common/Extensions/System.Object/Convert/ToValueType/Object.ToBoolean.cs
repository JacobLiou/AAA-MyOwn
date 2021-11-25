using System;
using System.Linq;

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToBoolean

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的布尔值。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回 bool 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false</returns>
        public static bool ToBoolean(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return false;
            }

            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (System.Exception)
            {
                return default(bool);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将一个值转换为bool类型。
        ///  <para>以下特殊内容(不区分大小写)均可以正常转换："是", "否", "YES", "NO", "Y", "N", "ON", "OFF", "1", "0" </para>
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool ToBooleanExtend(this object @this)
        {
            bool result = false;

            if (@this != DBNull.Value && @this != null)
            {
                bool.TryParse(@this.ToString2(), out result);

                if (result == false)
                {
                    string temp = @this.ToString().ToUpper();
                    string[] arrBool =  { "是", "否", "YES", "NO", "Y", "N", "ON", "OFF", "1", "0" };

                    if (arrBool.Contains(temp))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }


        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的布尔值。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false</returns>
        public static bool ToBoolean(this object @this, bool defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return false;
            }

            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的布尔值。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 false。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false</returns>
        public static bool ToBoolean(this object @this, Func<bool> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return false;
            }

            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion

        #region ToBooleanNullable

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的布尔值。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回 bool 类型的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns>true 或 false 或 null</returns>
        public static bool? ToBooleanNullable(this object @this)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (System.Exception)
            {
                return default(bool);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的布尔值。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValue">转换失败时返回的默认值</param>
        /// <returns>true 或 false 或 null</returns>
        public static bool? ToBooleanNullable(this object @this, bool? defaultValue)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (System.Exception)
            {
                return defaultValue;
            }
        }

        /// <summary>
        ///  自定义扩展方法：将指定对象的值转换为等效的布尔值。
        ///  如果 value 为 null 或者 DBNull，则此方法返回 null。
        ///  如果转换失败则返回指定的默认值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="defaultValueFactory">转换失败时返回的默认值(产生默认值的方法)</param>
        /// <returns>true 或 false 或 null</returns>
        public static bool? ToBooleanNullable(this object @this, Func<bool?> defaultValueFactory)
        {
            if (@this.IsDbNullOrNull())
            {
                return null;
            }

            try
            {
                return Convert.ToBoolean(@this);
            }
            catch (System.Exception)
            {
                return defaultValueFactory();
            }
        }

        #endregion
    }
}