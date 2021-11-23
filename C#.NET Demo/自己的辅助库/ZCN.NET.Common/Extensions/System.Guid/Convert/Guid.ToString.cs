using System;

using ZCN.NET.Common.Enums;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region Format 

        /// <summary>
        ///  自定义扩展方法：将GUID值转换为指定格式的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="format">Guid格式枚举</param>
        /// <returns></returns>
        public static string ToString2(this Guid? @this, GuidFormat format)
        {
            if (!@this.HasValue)
            {
                @this = Guid.Empty;
            }

            Guid.TryParseExact(Guid.Empty.ToString(), format.ToString(), out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result.ToString();
        }

        /// <summary>
        ///  自定义扩展方法：将GUID值转换为指定格式的Guid值
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="format">Guid格式枚举</param>
        /// <returns></returns>
        public static Guid Format(this Guid? @this, GuidFormat format)
        {
            if (!@this.HasValue)
            {
                @this = Guid.Empty;
            }

            Guid.TryParseExact(Guid.Empty.ToString(), format.ToString(), out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        #endregion

        #region ToString32

        /// <summary>
        ///   自定义扩展方法：将GUID值转换为32位小写字符串。
        ///   如果Guid为null，则返回32位全是0的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ToString32(this Guid? @this)
        {
            if (!@this.HasValue)
                return Guid.Empty.ToString().Replace("-", "");

            return @this.ToString().Replace("-", "");
        }

        /// <summary>
        ///   自定义扩展方法：将GUID值转换为32位小写字符串。
        ///   如果Guid为null，则返回32位全是0的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ToString32Lower(this Guid? @this)
        {
            if (!@this.HasValue)
            {
                return Guid.Empty.ToString().Replace("-", "").ToLower();
            }

            return @this.ToString().Replace("-", "").ToLower();
        }

        /// <summary>
        ///   自定义扩展方法：将GUID值转换为32位大写字符串。
        ///   如果Guid为null，则返回32位全是0的字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ToString32Upper(this Guid? @this)
        {
            if (!@this.HasValue)
            {
                return Guid.Empty.ToString().Replace("-", "").ToUpper();
            }

            return @this.ToString().Replace("-", "").ToUpper();
        }

        #endregion

        #region ToString36

        /// <summary>
        ///   自定义扩展方法：将GUID值转换为36位小写字符串(带有分割线)。
        ///   如果Guid为null，则返回36位全是0的字符串(带有分割线)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ToString36(this Guid? @this)
        {
            if (!@this.HasValue)
            {
                return Guid.Empty.ToString();
            }

            if (@this.ToString().Length == 36)
            {
                return @this.ToString();
            }
            if (@this.ToString().Length == 32)
            {
                return @this.ToString().Insert(8, "-").Insert(13, "-").Insert(18, "-").Insert(23, "-");
            }

            return Guid.Empty.ToString();
        }

        /// <summary>
        ///   自定义扩展方法：将GUID值转换为36位小写字符串(带有分割线)。
        ///   如果Guid为null，则返回36位全是0的字符串(带有分割线)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ToString36Lower(this Guid? @this)
        {
            if (!@this.HasValue)
            {
                return Guid.Empty.ToString().ToLower();
            }

            if (@this.ToString().Length == 36)
            {
                return @this.ToString();
            }
            if (@this.ToString().Length == 32)
            {
                return @this.ToString().Insert(8, "-").Insert(13, "-").Insert(18, "-").Insert(23, "-").ToLower();
            }

            return Guid.Empty.ToString().ToLower();
        }

        /// <summary>
        ///   自定义扩展方法：将GUID值转换为36位大写字符串(带有分割线)。
        ///   如果Guid为null，则返回36位全是0的字符串(带有分割线)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ToString36Upper(this Guid? @this)
        {
            if (!@this.HasValue)
            {
                return Guid.Empty.ToString().ToUpper();
            }

            if (@this.ToString().Length == 36)
            {
                return @this.ToString();
            }
            if (@this.ToString().Length == 32)
            {
                return @this.ToString().Insert(8, "-").Insert(13, "-").Insert(18, "-").Insert(23, "-").ToUpper();
            }

            return Guid.Empty.ToString().ToUpper();
        }

        #endregion

        #region convert guid to uniquecode(formatting to upper)

        /// <summary>
        /// 自定义扩展方法：将Guid类型的值转换为唯一码
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string ToUniqueCode(this Guid @this)
        {
            long i = 1;
            byte[] bytes = @this.ToByteArray();
            foreach (byte b in bytes)
            {
                i *= ((int)b + 1);
            }
            string code = string.Format("{0:x}", i - DateTime.Now.Ticks);
            return code;
        }

        #endregion
    }
}