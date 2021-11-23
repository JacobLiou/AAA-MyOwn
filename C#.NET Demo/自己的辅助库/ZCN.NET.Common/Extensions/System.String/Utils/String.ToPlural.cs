//using System.Data.Entity.Design.PluralizationServices;
//using System.Globalization;

//namespace ZCN.NET.Common.Extensions
//{
//    public static partial class CommonExtensions
//    {
//        /// <summary>
//        ///   自定义扩展方法：返回指定单词的复数形式
//        /// </summary>
//        /// <param name="this">扩展对象</param>
//        /// <returns>单词的复数形式</returns>
//        public static string ToPlural(this string @this)
//        {
//            return PluralizationService.CreateService(new CultureInfo("en-US")).Pluralize(@this);
//        }

//        /// <summary>
//        ///   自定义扩展方法：返回指定单词的复数形式
//        /// </summary>
//        /// <param name="this">扩展对象</param>
//        /// <param name="cultureInfo">区域信息对象</param>
//        /// <returns>单词的复数形式</returns>
//        public static string ToPlural(this string @this, CultureInfo cultureInfo)
//        {
//            return PluralizationService.CreateService(cultureInfo).Pluralize(@this);
//        }
//    }
//}