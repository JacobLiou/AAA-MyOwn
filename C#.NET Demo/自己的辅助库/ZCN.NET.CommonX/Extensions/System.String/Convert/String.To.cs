using System;
using System.Globalization;

using ZCN.NET.CommonX.Enums;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToBoolean

        /// <summary>
        ///  自定义扩展方法：尝试将逻辑值的指定字符串表示形式转换为其等效的 <see cref="T:System.Boolean" /> 值。
        ///  如果字符串的值等效于 <see cref="F:System.Boolean.TrueString" />，则为 <see langword="true" />；如果字符串的值等效于 <see cref="F:System.Boolean.FalseString" />，则为 <see langword="false" />
        /// </summary>
        /// <param name="value">要转换的字符串</param>
        /// <returns></returns>
        public static bool ToBoolean(this string value)
        {
            Boolean.TryParse(value, out bool result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：尝试将逻辑值的指定字符串表示形式转换为其等效的 <see cref="T:System.Boolean" /> 值。 
        ///  如果字符串的值等效于 <see cref="F:System.Boolean.TrueString" />，则为 <see langword="true" />；如果字符串的值等效于 <see cref="F:System.Boolean.FalseString" />，则为 <see langword="false" />。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">要转换的字符串</param>
        /// <returns></returns>
        public static bool? ToBooleanNullable(this string value)
        {
            bool flag = Boolean.TryParse(value, out bool result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：尝试将逻辑值的指定范围表示形式转换为它的等效 Boolean。
        ///  此方法返回时，如果转换成功，若 true 与 value 相等，则包含 TrueString，若 false 与 value 相等，则包含 FalseString。 如果转换失败，则包含 false。 如果 value 为 null 或不等于 TrueString 或 FalseString 字段的值，则转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static bool ToBoolean(this ReadOnlySpan<char> s)
        {
            Boolean.TryParse(s, out bool result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：尝试将逻辑值的指定范围表示形式转换为它的等效 Boolean。
        ///  此方法返回时，如果转换成功，若 true 与 value 相等，则包含 TrueString，若 false 与 value 相等，则包含 FalseString。 如果转换失败，则包含 false。 如果 value 为 null 或不等于 TrueString 或 FalseString 字段的值，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static int? ToBooleanNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToChar

        /// <summary>
        ///  自定义扩展方法：将指定字符串的值转换为它的等效 Unicode 字符
        ///  如果转换成功，则包含与字符串中的唯一字符等效的 Unicode 字符；如果转换失败，则包含未定义的值。 如果字符串的值为 <see langword="null" /> 或长度不为 1，则转换失败
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <returns></returns>
        public static char ToChar(this string s)
        {
            Char.TryParse(s, out char result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：尝试将逻辑值的指定字符串表示形式转换为其等效的 <see cref="T:System.Char" /> 值。 
        ///  如果转换成功，则包含与字符串中的唯一字符等效的 Unicode 字符；如果转换失败，则包含未定义的值。 如果字符串的值为 <see langword="null" /> 或长度不为 1，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <returns></returns>
        public static char? ToCharNullable(this string s)
        {
            bool flag = Char.TryParse(s, out char result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>自定义扩展方法：将指定区域性特定格式设置信息，将指定字符串的第一个字符转换为 Unicode 字符。</summary>
        /// <param name="value">长度为 1 或 <see langword="null" /> 的字符串。</param>
        /// <param name="provider">一个对象，提供有关参数的区域性特定格式设置信息。 如果 provider 为 null，则使用当前区域性。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns>与 <paramref name="value" /> 中第一个且仅有的字符等效的 Unicode 字符。</returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// <paramref name="value" /> 为 <see langword="null" />。</exception>
        /// <exception cref="T:System.FormatException">
        /// <paramref name="value" /> 的长度不是 1。</exception>
        public static char ToChar(this string value, IFormatProvider provider)
        {
            if (value == null)
                return default(char);

            if (value.Length != 1)
                return default(char);

            return value[0];
        }

        #endregion

        #region  ToByte

        /// <summary>
        ///  自定义扩展方法：(2、8、10 或 16位进制之间的转换)将指定基数的数字的字符串表示形式转换为等效的 8 位无符号整数。
        ///  如果 <paramref name="value" /> 为 <see langword="null" />，则返回 0（零）。
        ///  如果转换失败则返回 default(byte) 值。
        ///  具体请参考微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.convert.tobyte?view=netcore-3.1
        /// </summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="digitBit">进制位枚举</param>
        /// <returns></returns>
        public static byte ToByte(this string value, DigitBit digitBit)
        {
            try
            {
                return Convert.ToByte(value, digitBit.ToInt32());
            }
            catch
            {
                return default(byte);
            }
        }

        /// <summary>
        ///  自定义扩展方法：(2、8、10 或 16位进制之间的转换)将指定基数的数字的字符串表示形式转换为等效的 8 位有符号整数。
        ///  如果 <paramref name="value" /> 为 <see langword="null" />，则返回 0（零）。
        ///  如果转换失败则返回 default(sbyte) 值。
        ///  具体请参考微软官方文档：https://docs.microsoft.com/zh-cn/dotnet/api/system.convert.tobyte?view=netcore-3.1
        /// </summary>
        /// <param name="value">包含要转换的数字的字符串。</param>
        /// <param name="digitBit">进制位枚举</param>
        /// <returns></returns>
        public static sbyte ToSByte(this string value, DigitBit digitBit)
        {
            try
            {
                return Convert.ToSByte(value, digitBit.ToInt32());
            }
            catch
            {
                return default(sbyte);
            }
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 8 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static byte ToByte(this string s)
        {
            Byte.TryParse(s, out Byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 8 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static byte ToByte(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Byte.TryParse(s, numberStyle, provider, out Byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 8 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static byte? ToByteNullable(this string s)
        {
            bool flag = Byte.TryParse(s, out Byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 8 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static byte? ToByteNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Byte.TryParse(s, numberStyle, provider, out Byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 8 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static sbyte ToSByte(this string s)
        {
            SByte.TryParse(s, out SByte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 8 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static sbyte ToSByte(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            SByte.TryParse(s, numberStyle, provider, out SByte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 8 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static sbyte? ToSByteNullable(this string s)
        {
            bool flag = SByte.TryParse(s, out SByte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 8 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 8 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static sbyte? ToSByteNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = SByte.TryParse(s, numberStyle, provider, out SByte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：尝试将数字的范围表示形式转换为它的等效 Byte。
        ///  当此方法返回时，如果转换成功，则包含与 Byte 中所包含的数字等效的 s 值；如果转换失败，则包含零。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static byte ToByte(this ReadOnlySpan<char> s)
        {
            Byte.TryParse(s, out byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为它的等效 Byte。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所含数字等效的 8 位无符号整数值；如果转换失败，则包含零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关参数的区域性特定格式设置信息。 如果 provider 为 null，则使用当前区域性。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在参数中的样式元素。 要指定的一个典型值为 Integer</param>
        /// <returns></returns>
        public static byte ToByte(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Byte.TryParse(s, numberStyle, provider, out byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：尝试将数字的范围表示形式转换为它的等效 Byte。
        ///  当此方法返回时，如果转换成功，则包含与 Byte 中所包含的数字等效的 s 值。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static byte? ToByteNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Byte.TryParse(s, out byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为它的等效 Byte。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所含数字等效的 8 位无符号整数值；如果转换失败，则包含零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关参数的区域性特定格式设置信息。 如果 provider 为 null，则使用当前区域性。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在参数中的样式元素。 要指定的一个典型值为 Integer</param>
        /// <returns></returns>
        public static byte? ToByteNullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Byte.TryParse(s, numberStyle, provider, out byte result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToInt16 / ToShort

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static short ToInt16(this string s)
        {
            Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static short ToInt16(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static short? ToInt16Nullable(this string s)
        {
            bool flag = Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static short? ToInt16Nullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ushort ToUInt16(this string s)
        {
            UInt16.TryParse(s, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static ushort ToUInt16(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            UInt16.TryParse(s, numberStyle, provider, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ushort? ToUInt16Nullable(this string s)
        {
            bool flag = UInt16.TryParse(s, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns></returns>
        public static ushort? ToUInt16Nullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = UInt16.TryParse(s, numberStyle, provider, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串数为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static short ToShort(this string s)
        {
            Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static short ToShort(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static short? ToShortNullable(this string s)
        {
            bool flag = Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static short? ToShortNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ushort ToUShort(this string s)
        {
            UInt16.TryParse(s, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static ushort ToUShort(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            UInt16.TryParse(s, numberStyle, provider, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ushort? ToUShortNullable(this string s)
        {
            bool flag = UInt16.TryParse(s, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 16 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static ushort? ToUShortNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = UInt16.TryParse(s, numberStyle, provider, out ushort result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 16位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static int ToInt16(this ReadOnlySpan<char> s)
        {
            Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 16 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int ToInt16(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 16位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static int? ToInt16Nullable(this ReadOnlySpan<char> s)
        {
            bool flag = Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 16 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int? ToInt16Nullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 16位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static int ToShort(this ReadOnlySpan<char> s)
        {
            Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 16 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int ToShort(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 16位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static int? ToShortNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Int16.TryParse(s, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 16 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 16 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int? ToShortNullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int16.TryParse(s, numberStyle, provider, out short result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToInt32

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 32 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static int ToInt32(this string s)
        {
            Int32.TryParse(s, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 32 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int ToInt32(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int32.TryParse(s, numberStyle, provider, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 32 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>将指定区域性特定格式和样式的
        public static int? ToInt32Nullable(this string s)
        {
            bool flag = Int32.TryParse(s, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 32 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int? ToInt32Nullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int32.TryParse(s, numberStyle, provider, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 32 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static uint ToUInt32(this string s)
        {
            UInt32.TryParse(s, out uint result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 32 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static uint ToUInt32(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            UInt32.TryParse(s, numberStyle, provider, out uint result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 32 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含与字符串中所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static uint? ToUInt32Nullable(this string s)
        {
            bool flag = UInt32.TryParse(s, out uint result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 32 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static uint? ToUInt32Nullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = UInt32.TryParse(s, numberStyle, provider, out uint result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 32 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static int ToInt32(this ReadOnlySpan<char> s)
        {
            Int32.TryParse(s, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 32 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int ToInt32(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int32.TryParse(s, numberStyle, provider, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 32 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回 null。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static int? ToInt32Nullable(this ReadOnlySpan<char> s)
        {
            bool flag = Int32.TryParse(s, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 32 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 32 位无符号整数值；如果转换失败，则返回 null。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static int? ToInt32Nullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int32.TryParse(s, numberStyle, provider, out int result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToInt64 / ToLong

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static long ToInt64(this string s)
        {
            Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static long ToInt64(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static long? ToInt64Nullable(this string s)
        {
            bool flag = Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static long? ToInt64Nullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ulong ToUInt64(this string s)
        {
            UInt64.TryParse(s, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static ulong ToUInt64(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            UInt64.TryParse(s, numberStyle, provider, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ulong? ToUInt64Nullable(this string s)
        {
            bool flag = UInt64.TryParse(s, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static ulong? ToUInt64Nullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = UInt64.TryParse(s, numberStyle, provider, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static long ToLong(this string s)
        {
            Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static long ToLong(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static long? ToLongNullable(this string s)
        {
            bool flag = Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位有符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static long? ToLongNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ulong ToULong(this string s)
        {
            UInt64.TryParse(s, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static ulong ToULong(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            UInt64.TryParse(s, numberStyle, provider, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static ulong? ToULongNullable(this string s)
        {
            bool flag = UInt64.TryParse(s, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 64 位无符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        ///  如果转换失败则返回 null
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static ulong? ToULongNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = UInt64.TryParse(s, numberStyle, provider, out ulong result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static long ToInt64(this ReadOnlySpan<char> s)
        {
            Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static long ToInt64(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static long? ToInt64Nullable(this ReadOnlySpan<char> s)
        {
            bool flag = Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns></returns>
        public static long? ToInt64Nullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static long ToLong(this ReadOnlySpan<char> s)
        {
            Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static long ToLong(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不正确，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static long? ToLongNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Int64.TryParse(s, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的 64 位带符号整数。
        ///  当此方法返回时，如果转换成功，则包含字符串所包含的数字等效的 64 位无符号整数值；如果转换失败，则返回零。 如果字符串为 null 或 Empty、格式不符合 numberStyle，或者表示的数字小于 MinValue 或大于 MaxValue，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static long? ToLongNullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Int64.TryParse(s, numberStyle, provider, out long result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToSingle / ToFloat
        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static float ToSingle(this string s)
        {
            Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float ToSingle(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static float? ToSingleNullable(this string s)
        {
            bool flag = Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Single.MinValue" /> 或大于 <see cref="F:System.Single.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float? ToSingleNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Float.MinValue" /> 或大于 <see cref="F:System.Float.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static float ToFloat(this string s)
        {
            Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Float.MinValue" /> 或大于 <see cref="F:System.Float.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float ToFloat(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Float.MinValue" /> 或大于 <see cref="F:System.Float.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static float? ToFloatNullable(this string s)
        {
            bool flag = Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的单精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Float.MinValue" /> 或大于 <see cref="F:System.Float.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float? ToFloatNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static float ToSingle(this ReadOnlySpan<char> s)
        {
            Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float ToSingle(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static float? ToSingleNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float? ToSingleNullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static float ToFloat(this ReadOnlySpan<char> s)
        {
            Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float ToFloat(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static float? ToFloatNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Single.TryParse(s, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的单精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围参数等效的单精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或为空，或不为有效格式的数字，则转换失败。 如果 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static float? ToFloatNullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Single.TryParse(s, numberStyle, provider, out float result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToDouble

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的双精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static double ToDouble(this string s)
        {
            Double.TryParse(s, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的双精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static double ToDouble(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Double.TryParse(s, numberStyle, provider, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的双精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static double? ToDoubleNullable(this string s)
        {
            bool flag = Double.TryParse(s, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与字符串等效的双精度浮点数；如果转换失败，则包含零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Double.MinValue" /> 或大于 <see cref="F:System.Double.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static double? ToDoubleNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Double.TryParse(s, numberStyle, provider, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围中所包含的数值或符号等效的双精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或空，或其格式不符合 numberStyle，则转换失败。 如果 numberStyle 不是 NumberStyles 枚举常量的有效组合，则转换也会失败。 如果 s 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 s 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static double ToDouble(this ReadOnlySpan<char> s)
        {
            Double.TryParse(s, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围中所包含的数值或符号等效的双精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或空，或其格式不符合 numberStyle，则转换失败。 如果 numberStyle 不是 NumberStyles 枚举常量的有效组合，则转换也会失败。 如果 s 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 s 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static double ToDouble(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Double.TryParse(s, numberStyle, provider, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围中所包含的数值或符号等效的双精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或空，或其格式不符合 numberStyle，则转换失败。 如果 numberStyle 不是 NumberStyles 枚举常量的有效组合，则转换也会失败。 如果 s 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 s 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static double? ToDoubleNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Double.TryParse(s, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的双精度浮点数。
        ///  当此方法返回时，如果转换成功，则包含与数字的范围中所包含的数值或符号等效的双精度浮点数；如果转换失败，则包含零。 如果数字的范围为 null 或空，或其格式不符合 numberStyle，则转换失败。 如果 numberStyle 不是 NumberStyles 枚举常量的有效组合，则转换也会失败。 如果 s 是小于 MinValue 的有效数字，则 result 为 NegativeInfinity。 如果 s 是大于 MaxValue 的有效数字，则 result 为 PositiveInfinity。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static double? ToDoubleNullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Double.TryParse(s, numberStyle, provider, out double result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToDecimal

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 System.Decimal 形式。
        ///  如果转换成功，此方法返回与字符串中所含数值相当的 <see cref="T:System.Decimal" /> 数；如果转换失败，此方法返回零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static decimal ToDecimal(this string s)
        {
            Decimal.TryParse(s, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 System.Decimal 形式。
        ///  如果转换成功，此方法返回与字符串中所含数值相当的 <see cref="T:System.Decimal" /> 数；如果转换失败，此方法返回零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" />，则转换失败。
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static decimal ToDecimal(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Decimal.TryParse(s, numberStyle, provider, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的字符串表示形式转换为它的等效 System.Decimal 形式。
        ///  如果转换成功，此方法返回与字符串中所含数值相当的 <see cref="T:System.Decimal" /> 数；如果转换失败，此方法返回零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <returns></returns>
        public static decimal? ToDecimalNullable(this string s)
        {
            bool flag = Decimal.TryParse(s, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的字符串表示形式转换为它的等效 System.Decimal 形式。
        ///  如果转换成功，此方法返回与字符串中所含数值相当的 <see cref="T:System.Decimal" /> 数；如果转换失败，此方法返回零。 如果字符串为 <see langword="null" /> 或 <see cref="F:System.String.Empty" />、不是有效格式的数字，或者表示的数字小于 <see cref="F:System.Decimal.MinValue" /> 或大于 <see cref="F:System.Decimal.MaxValue" />，则转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">要转换的数字的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static decimal? ToDecimalNullable(this string s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Decimal.TryParse(s, numberStyle, provider, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的Decimal 等效项。
        ///  如果转换成功，此方法返回与数字的范围中所含数值相当的 Decimal 数；如果转换失败，此方法返回零。 如果数字的范围为 null 或 Empty、不是格式符合 numberStyle 的数字、表示小于 MinValue 或大于 MaxValue 的数字，表明转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static decimal ToDecimal(this ReadOnlySpan<char> s)
        {
            Decimal.TryParse(s, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的Decimal 等效项。
        ///  如果转换成功，此方法返回与数字的范围中所含数值相当的 Decimal 数；如果转换失败，此方法返回零。 如果数字的范围为 null 或 Empty、不是格式符合 numberStyle 的数字、表示小于 MinValue 或大于 MaxValue 的数字，表明转换失败。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static decimal ToDecimal(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            Decimal.TryParse(s, numberStyle, provider, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将数字的范围表示形式转换为其等效的Decimal 等效项。
        ///  如果转换成功，此方法返回与数字的范围中所含数值相当的 Decimal 数；如果转换失败，此方法返回零。 如果数字的范围为 null 或 Empty、不是格式符合 numberStyle 的数字、表示小于 MinValue 或大于 MaxValue 的数字，表明转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <returns></returns>
        public static decimal? ToDecimalNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Decimal.TryParse(s, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式和样式的数字的范围表示形式转换为其等效的Decimal 等效项。
        ///  如果转换成功，此方法返回与数字的范围中所含数值相当的 Decimal 数；如果转换失败，此方法返回零。 如果数字的范围为 null 或 Empty、不是格式符合 numberStyle 的数字、表示小于 MinValue 或大于 MaxValue 的数字，表明转换失败。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的值的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="numberStyle">枚举值的按位组合，用于指示可出现在字符串中的样式元素。 要指定的一个典型值为 <see cref="F:System.Globalization.NumberStyles.Integer" /></param>
        /// <returns></returns>
        public static decimal? ToDecimalNullable(this ReadOnlySpan<char> s, IFormatProvider provider, NumberStyles numberStyle = NumberStyles.Integer)
        {
            bool flag = Decimal.TryParse(s, numberStyle, provider, out decimal result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToEnum

        /// <summary>
        ///  自定义扩展方法：将一个或多个枚举常数的名称或数字值的字符串表示转换成等效的枚举对象。 一个参数指定该操作是否区分大小写。
        ///  当此方法返回时，如果分析操作成功，result 将包含值由 value 表示的 TEnum 类型的对象。 如果分析操作失败，result 将包含 TEnum 的基础类型的默认值。 请注意，此值无需为 TEnum 枚举的成员
        /// </summary>
        /// <param name="value">要转换的枚举名称或基础值的字符串表示形式</param>
        /// <param name="ignoreCase">若要不区分大小写，则为 <see langword="true" />；若要区分大小写，则为 <see langword="false" /></param>
        /// <returns></returns>
        public static TEnum ToEnum<TEnum>(this string value, bool ignoreCase) where TEnum : struct
        {
            Enum.TryParse<TEnum>(value, ignoreCase, out TEnum result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将一个或多个枚举常数的名称或数字值的字符串表示转换成等效的枚举对象。 一个参数指定该操作是否区分大小写。
        ///  当此方法返回时，如果分析操作成功，result 将包含值由 value 表示的 TEnum 类型的对象。 如果分析操作失败，result 将包含 TEnum 的基础类型的默认值。 请注意，此值无需为 TEnum 枚举的成员。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="value">要转换的枚举名称或基础值的字符串表示形式</param>
        /// <param name="ignoreCase">若要不区分大小写，则为 <see langword="true" />；若要区分大小写，则为 <see langword="false" /></param>
        /// <returns></returns>
        public static TEnum? ToEnumNullable<TEnum>(this string value, bool ignoreCase) where TEnum : struct
        {
            bool flag = Enum.TryParse<TEnum>(value, ignoreCase, out TEnum result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将一个或多个枚举常数的名称或数字值的字符串表示转换成等效的枚举对象。 一个参数指定该操作是否区分大小写。
        ///  如果此方法返回 true，则为包含表示已分析值的枚举常量的对象
        /// </summary>
        /// <param name="value">一个或多个枚举常量的名称或数值的字符串表示形式</param>
        /// <param name="enumType">用于分析的枚举类型</param>
        /// <param name="ignoreCase">若要不区分大小写，则为 <see langword="true" />；若要区分大小写，则为 <see langword="false" /></param>
        /// <returns></returns>
        public static object ToEnum(this string value, Type enumType, bool ignoreCase)
        {
            Enum.TryParse(enumType, value, ignoreCase, out object result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        #endregion

        #region ToGuid

        /// <summary>
        ///  自定义扩展方法：将 GUID 的字符串表示形式转换为等效的 <see cref="T:System.Guid" /> 结构。
        ///  如果此方法返回 <see langword="true" />，结果将包含有效的 <see cref="T:System.Guid" />。 如果字符串等于 <see cref="F:System.Guid.Empty" />，则此方法将返回 <see langword="false" />
        /// </summary>
        /// <param name="input">要转换的 GUID</param>
        /// <returns></returns>
        public static Guid ToGuid(this string input)
        {
            Guid.TryParse(input, out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：尝试将逻辑值的指定字符串表示形式转换为其等效的 <see cref="T:System.Guid" /> 值。 
        ///  如果此方法返回 <see langword="true" />，结果将包含有效的 <see cref="T:System.Guid" />。 如果字符串等于 <see cref="F:System.Guid.Empty" />，则此方法将返回 <see langword="false" />。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="input">要转换的 GUID</param>
        /// <returns></returns>
        public static Guid? ToGuidNullable(this string input)
        {
            bool flag = Guid.TryParse(input, out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将 GUID 的字符串表示形式转换为等效的 <see cref="T:System.Guid" /> 结构，前提是该字符串采用的是指定格式。
        ///  如果此方法返回 <see langword="true" />，结果将包含有效的 <see cref="T:System.Guid" />。 如果字符串等于 <see cref="F:System.Guid.Empty" />，则此方法将返回 <see langword="false" />。
        /// </summary>
        /// <param name="input">要转换的 GUID</param>
        /// <param name="format">下列说明符之一，指示解释 <paramref name="input" /> 时要使用的确切格式：“N”、“D”、“B”、“P”或“X”</param>
        /// <returns></returns>
        public static Guid ToGuidExact(this string input, string format)
        {
            Guid.TryParseExact(input, format, out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将 GUID 的字符串表示形式转换为等效的 <see cref="T:System.Guid" /> 结构，前提是该字符串采用的是指定格式。
        ///  如果此方法返回 <see langword="true" />，结果将包含有效的 <see cref="T:System.Guid" />。 如果字符串等于 <see cref="F:System.Guid.Empty" />，则此方法将返回 <see langword="false" />。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="input">要转换的 GUID</param>
        /// <param name="format">下列说明符之一，指示解释 <paramref name="input" /> 时要使用的确切格式：“N”、“D”、“B”、“P”或“X”</param>
        /// <returns></returns>
        public static Guid? ToGuidExactNullable(this string input, string format)
        {
            bool flag = Guid.TryParseExact(input, format, out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将 GUID 的字符串表示形式转换为等效的 <see cref="T:System.Guid" /> 结构，前提是该字符串采用的是指定格式。
        ///  如果此方法返回 <see langword="true" />，结果将包含有效的 <see cref="T:System.Guid" />。 如果字符串等于 <see cref="F:System.Guid.Empty" />，则此方法将返回 <see langword="false" />
        /// </summary>
        /// <param name="input">要转换的 GUID</param>
        /// <param name="format">下列说明符之一，指示解释 <paramref name="input" /> 时要使用的确切格式：“N”、“D”、“B”、“P”或“X”</param>
        /// <returns></returns>
        public static Guid ToGuidExact(this string input, GuidFormat format)
        {
            Guid.TryParseExact(input, format.ToString(), out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将 GUID 的字符串表示形式转换为等效的 <see cref="T:System.Guid" /> 结构，前提是该字符串采用的是指定格式。
        ///  如果此方法返回 <see langword="true" />，结果将包含有效的 <see cref="T:System.Guid" />。 如果字符串等于 <see cref="F:System.Guid.Empty" />，则此方法将返回 <see langword="false" />。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="input">要转换的 GUID</param>
        /// <param name="format">下列说明符之一，指示解释 <paramref name="input" /> 时要使用的确切格式：“N”、“D”、“B”、“P”或“X”</param>
        /// <returns></returns>
        public static Guid? ToGuidExactNullable(this string input, GuidFormat format)
        {
            bool flag = Guid.TryParseExact(input, format.ToString(), out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将包含 GUID 表示形式的指定只读字符范围转换为等效的 Guid 结构。
        ///  如果分析操作成功，则为 true；否则为 false
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的 GUID 的字符</param>
        /// <returns></returns>
        public static Guid ToGuid(this ReadOnlySpan<char> s)
        {
            Guid.TryParse(s, out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将包含 GUID 表示形式的指定只读字符范围转换为等效的 Guid 结构。
        ///  如果转换失败则返回 null
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的 GUID 的字符</param>
        /// <returns></returns>
        public static Guid? ToGuidNullable(this ReadOnlySpan<char> s)
        {
            bool flag = Guid.TryParse(s, out Guid result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToDateTime

        /// <summary>
        ///  自定义扩展方法：将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  如果转换成功，则包含与 <see cref="T:System.DateTime" /> 中包含的日期和时间等效的字符串值；如果转换失败，则为 <see cref="F:System.DateTime.MinValue" />。 如果字符串为 <see langword="null" />，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string s)
        {
            DateTime.TryParse(s, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式信息和格式设置样式，将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  如果转换成功，则包含与 <see cref="T:System.DateTime" /> 中包含的日期和时间等效的字符串值；如果转换失败，则为 <see cref="F:System.DateTime.MinValue" />。 如果字符串为 <see langword="null" />，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string s, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            DateTime.TryParse(s, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定格式、区域性特定的格式信息和样式，将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符串值；如果转换失败，则为 MinValue。 如果字符串或 format 参数为 null，或者为空字符串，或者未包含对应于 format 中指定的模式的日期和时间，则转换失败
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="format">z字符串所需的格式</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime ToDateTimeExact(this string s, string format, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            DateTime.TryParseExact(s, format, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定格式、区域性特定的格式信息和样式，将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符串值；如果转换失败，则为 MinValue。 如果字符串或 format 参数为 null，或者为空字符串，或者未包含对应于 format 中指定的模式的日期和时间，则转换失败
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="formats">z字符串所需的格式数组</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        ///</param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime ToDateTimeExact(this string s, string[] formats, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            DateTime.TryParseExact(s, formats, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  如果转换成功，则包含与 <see cref="T:System.DateTime" /> 中包含的日期和时间等效的字符串值；如果转换失败，则返回 null。 如果字符串为 <see langword="null" />，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败。
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <returns></returns>
        public static DateTime? ToDateTimeNullable(this string s)
        {
            bool flag = DateTime.TryParse(s, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式信息和格式设置样式，将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  如果转换成功，则包含与 <see cref="T:System.DateTime" /> 中包含的日期和时间等效的字符串值；如果转换失败，则返回 null。 如果字符串为 <see langword="null" />，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime? ToDateTimeNullable(this string s, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            bool flag = DateTime.TryParse(s, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定格式、区域性特定的格式信息和样式，将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符串值；如果转换失败，则返回 null。 如果字符串或 format 参数为 null，或者为空字符串，或者未包含对应于 format 中指定的模式的日期和时间，则转换失败。
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="format">字符串所需的格式。例如：{"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt","MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss","M/d/yyyy hh:mm tt", "M/d/yyyy hh tt","M/d/yyyy h:mm", "M/d/yyyy h:mm","MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。例如： CultureInfo enUS = new CultureInfo("en-US"); 请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime? ToDateTimeExactNullable(this string s, string format, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            bool flag = DateTime.TryParseExact(s, format, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将指定格式、区域性特定的格式信息和样式，将日期和时间的指定字符串表示形式转换为其 <see cref="T:System.DateTime" /> 等效项。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符串值；如果转换失败，则返回 null。 如果字符串或 format 参数为 null，或者为空字符串，或者未包含对应于 format 中指定的模式的日期和时间，则转换失败
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="formats">字符串所需的格式数组。例如：{"M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt","MM/dd/yyyy hh:mm:ss", "M/d/yyyy h:mm:ss","M/d/yyyy hh:mm tt", "M/d/yyyy hh tt","M/d/yyyy h:mm", "M/d/yyyy h:mm","MM/dd/yyyy hh:mm", "M/dd/yyyy hh:mm"};</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。例如： CultureInfo enUS = new CultureInfo("en-US"); 请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        ///</param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime? ToDateTimeExactNullable(this string s, string[] formats, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            bool flag = DateTime.TryParseExact(s, formats, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将日期和时间的指定字符范围转换为其等效的 DateTime。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符范围值；如果转换失败，则为 MinValue。 如果字符范围为 null，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败
        /// </summary>
        /// <param name="s">包含要转换的日期和时间的字符串</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this ReadOnlySpan<char> s)
        {
            DateTime.TryParse(s, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将日期和时间的指定字符范围转换为其等效的 DateTime。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符范围值；如果转换失败，则为 MinValue。 如果字符范围为 null，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败
        /// </summary>
        /// <param name="s">包含要转换的日期和时间的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            DateTime.TryParse(s, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将日期和时间的指定字符范围转换为其等效的 DateTime。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符范围值；如果转换失败，则返回 null 。 如果字符范围为 null，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败
        /// </summary>
        /// <param name="s">包含要转换的日期和时间的字符串</param>
        /// <returns></returns>
        public static DateTime? ToDateTimeNullable(this ReadOnlySpan<char> s)
        {
            bool flag = DateTime.TryParse(s, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将日期和时间的指定字符范围转换为其等效的 DateTime。
        ///  当此方法返回时，如果转换成功，则包含与 DateTime 中包含的日期和时间等效的字符范围值；如果转换失败，则返回 null 。 如果字符范围为 null，是空字符串 ("") 或者不包含日期和时间的有效字符串表示形式，则转换失败
        /// </summary>
        /// <param name="s">包含要转换的日期和时间的字符串</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <param name="styles">枚举值的按位组合，该组合定义如何根据当前时区或当前日期解释已分析日期。 要指定的一个典型值为 <see cref="F:System.Globalization.DateTimeStyles.None" />。</param>
        /// <returns></returns>
        public static DateTime? ToDateTimeNullable(this ReadOnlySpan<char> s, IFormatProvider provider, DateTimeStyles styles = DateTimeStyles.None)
        {
            bool flag = DateTime.TryParse(s, provider, styles, out DateTime result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion

        #region ToTimeSpan

        /// <summary>
        ///  自定义扩展方法：时间间隔的字符串表示形式转换为其等效的 TimeSpan。
        ///  此方法返回时，包含表示由字符串指定的时间间隔的对象；或者如果转换失败，则包含 Zero。
        /// </summary>
        /// <param name="s">一个字符串，用于指定进行转换的时间间隔</param>
        /// <returns></returns>
        public static TimeSpan ToTimeSpan(this string s)
        {
            TimeSpan.TryParse(s, out TimeSpan result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将指定区域性特定格式设置信息，将时间间隔的字符串表示形式转换为其等效的 TimeSpan。
        ///  此方法返回时，包含表示由字符串指定的时间间隔的对象；或者如果转换失败，则包含 Zero。
        /// </summary>
        /// <param name="s">一个字符串，用于指定进行转换的时间间隔</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、TimeSpanFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns></returns>
        public static TimeSpan ToTimeSpan(this string s, IFormatProvider provider)
        {
            TimeSpan.TryParse(s, provider, out TimeSpan result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将时间间隔的指定字符串表示形式转换为其等效的 TimeSpan。
        ///  此方法返回时，包含表示由 input 指定的时间间隔的对象；或者如果转换失败，则包含 Zero。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的时间间隔的字符</param>
        /// <returns></returns>
        public static TimeSpan ToTimeSpan(this ReadOnlySpan<char> s)
        {
            TimeSpan.TryParse(s, out TimeSpan result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将时间间隔的指定字符串表示形式转换为其等效的 TimeSpan。
        ///  此方法返回时，包含表示由 input 指定的时间间隔的对象；或者如果转换失败，则包含 Zero。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的时间间隔的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、TimeSpanFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns></returns>
        public static TimeSpan ToTimeSpan(this ReadOnlySpan<char> s, IFormatProvider provider)
        {
            TimeSpan.TryParse(s, provider, out TimeSpan result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            return result;
        }

        /// <summary>
        ///  自定义扩展方法：将时间间隔的指定字符串表示形式转换为其等效的 TimeSpan。
        ///  此方法返回时，包含表示由 input 指定的时间间隔的对象；或者如果转换失败，则返回 null。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的时间间隔的字符</param>
        /// <returns></returns>
        public static TimeSpan? ToTimeSpanNullable(this ReadOnlySpan<char> s)
        {
            bool flag = TimeSpan.TryParse(s, out TimeSpan result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        /// <summary>
        ///  自定义扩展方法：将时间间隔的指定字符串表示形式转换为其等效的 TimeSpan。
        ///  此方法返回时，包含表示由 input 指定的时间间隔的对象；或者如果转换失败，则返回 null。
        /// </summary>
        /// <param name="s">一个范围，包含表示要转换的时间间隔的字符</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、TimeSpanFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns></returns>
        public static TimeSpan? ToTimeSpanNullable(this ReadOnlySpan<char> s, IFormatProvider provider)
        {
            bool flag = TimeSpan.TryParse(s, provider, out TimeSpan result); // 此参数未经初始化即进行传递；最初在 result 中提供的任何值都会被覆盖。
            if (flag)
                return result;

            return null;
        }

        #endregion
    }
}