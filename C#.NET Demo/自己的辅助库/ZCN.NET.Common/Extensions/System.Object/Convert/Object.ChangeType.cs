using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ChangeType

        /// <summary>
        ///  自定义扩展方法： 返回一个指定类型的对象，该对象的值等于指定的对象
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="typeCode">要返回的对象的类型</param>
        /// <returns>一个基础类型为 typeCode 的对象，其值等效于 value。
        ///          如果 value 是 null，且 typeCode 是 System.TypeCode.Empty、System.TypeCode.String、 
        ///          或 System.TypeCode.object，则为 null 引用
        /// </returns>
        public static object ChangeType(this object value, TypeCode typeCode)
        {
            return Convert.ChangeType(value, typeCode);
        }

        /// <summary>
        ///  自定义扩展方法： 返回一个指定类型的对象，该对象的值等于指定的对象。参数提供区域性特定的格式设置信息
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="typeCode">要返回的对象的类型</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns>一个基础类型为 typeCode 的对象，其值等效于 value。
        ///          如果 value 是 null，且 typeCode 是 System.TypeCode.Empty、System.TypeCode.String、 
        ///          或 System.TypeCode.object，则为 null 引用
        /// </returns>
        public static object ChangeType(this object value, TypeCode typeCode, IFormatProvider provider)
        {
            return Convert.ChangeType(value, typeCode, provider);
        }

        /// <summary>
        ///  自定义扩展方法： 返回一个指定类型的对象，该对象的值等于指定的对象
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="conversionType">要返回的对象的类型</param>
        /// <returns> 一个类型为 conversionType 的对象，其值等效于 value。
        ///           如果 value 是 null，且 conversionType 不是值类型，则为 null 引用
        /// </returns>
        public static object ChangeType(this object value, Type conversionType)
        {
            return Convert.ChangeType(value, conversionType);
        }

        /// <summary>
        ///  自定义扩展方法： 返回一个指定类型的对象，该对象的值等于指定的对象。参数提供区域性特定的格式设置信息
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="conversionType">要返回的对象的类型</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns> 一个类型为 conversionType 的对象，其值等效于 value。
        ///           如果 value 是 null，且 conversionType 不是值类型，则为 null 引用
        /// </returns>
        public static object ChangeType(this object value, Type conversionType, IFormatProvider provider)
        {
            return Convert.ChangeType(value, conversionType, provider);
        }

        /// <summary>
        ///  自定义扩展方法： 返回一个指定类型的对象，该对象的值等于指定的对象
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <returns> 一个类型为 conversionType 的对象，其值等效于 value。
        ///           如果 value 是 null，且 conversionType 不是值类型，则为 null 引用
        /// </returns>
        public static object ChangeType<T>(this object value)
        {
            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        ///  自定义扩展方法： 返回一个指定类型的对象，该对象的值等于指定的对象。参数提供区域性特定的格式设置信息
        /// </summary>
        /// <param name="value">扩展对象</param>
        /// <param name="provider">一个对象，提供有关字符串的区域性特定格式设置信息。
        /// .NET Framework 包含以下三个预定义的 IFormatProvider 实现，以提供用于对数字和日期和时间值进行格式设置或分析的区域性特定信息，分别是NumberFormatInfo类、DateTimeFormatInfo类、CultureInfo表示特定区域性的类。请参考：https://docs.microsoft.com/zh-cn/dotnet/api/system.iformatprovider?view=netcore-3.1
        /// </param>
        /// <returns> 一个类型为 conversionType 的对象，其值等效于 value。
        ///           如果 value 是 null，且 conversionType 不是值类型，则为 null 引用
        /// </returns>
        public static object ChangeType<T>(this object value, IFormatProvider provider)
        {
            return (T)Convert.ChangeType(value, typeof(T), provider);
        }

        #endregion
    }
}