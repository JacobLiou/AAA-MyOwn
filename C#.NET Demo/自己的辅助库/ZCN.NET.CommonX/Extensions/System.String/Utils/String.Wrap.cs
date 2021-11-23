using System.Text;

using ZCN.NET.CommonX.Utils;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   自定义扩展方法：给字符串添加前缀与后缀
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="prefix">前缀</param>
        /// <param name="suffix">后缀</param>
        /// <returns></returns>
        public static string Wrap(this string @this, string prefix, string suffix)
        {
            if (prefix == null)
            {
                prefix = string.Empty;
            }
            if (suffix == null)
            {
                suffix = string.Empty;
            }

            return DoWrap(@this, prefix, suffix);
        }

        /// <summary>
        ///   自定义扩展方法：给字符串添加前缀与后缀
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="prefix">前缀</param>
        /// <param name="suffix">后缀</param>
        /// <returns></returns>
        private static string DoWrap(string @this, string prefix, string suffix)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return string.Empty;

            return prefix + @this + suffix;
        }

        /// <summary>
        ///   自定义扩展方法：使用中文状态下的方括号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回【ProductName】
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithBracketsZh(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.Brackets_Left_Zh, StringUtils.Symbol.Brackets_Right_Zh);
        }

        /// <summary>
        ///   自定义扩展方法：使用英文状态下的方括号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回[ProductName]
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithBracketsEn(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.Brackets_Left_En, StringUtils.Symbol.Brackets_Right_En);
        }

        /// <summary>
        ///   自定义扩展方法：使用花括号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回{ProductName}
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithBraces(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.Braces_Left, StringUtils.Symbol.Braces_Right);
        }

        /// <summary>
        ///   自定义扩展方法：使用中文状态下的圆括号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回（ProductName）
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithParenthesesZh(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.Parentheses_Left_Zh, StringUtils.Symbol.Parentheses_Right_Zh);
        }

        /// <summary>
        ///   自定义扩展方法：使用英文状态下的圆括号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回(ProductName)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithParenthesesEn(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.Parentheses_Left_En, StringUtils.Symbol.Parentheses_Right_En);
        }

        /// <summary>
        ///   自定义扩展方法：使用中文状态下的单引号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回‘ProductName’
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithSingleQuotationZh(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.SingleQuotation_Left_Zh, StringUtils.Symbol.SingleQuotation_Right_Zh);
        }

        /// <summary>
        ///   自定义扩展方法：使用英文状态下的单引号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回'ProductName'
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithSingleQuotationEn(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.SingleQuotation_Left_En, StringUtils.Symbol.SingleQuotation_Right_En);
        }

        /// <summary>
        ///   自定义扩展方法：使用英文状态下的单引号来包裹字符串数组中的每个元素并使用逗号分隔拼接成字符串。
        ///   例如：{ProductName,ProductPrice}，执行该方法后返回'ProductName','ProductPrice'
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithSingleQuotationEn(this string[] @this)
        {
            if (@this == null || @this.Length == 0)
                return string.Empty;

            StringBuilder sb = new StringBuilder();
            foreach (string str in @this)
            {
                sb.Append(StringUtils.Symbol.SingleQuotation_Left_En);
                sb.Append(str);
                sb.Append(StringUtils.Symbol.SingleQuotation_Right_En);
                sb.Append(StringUtils.Symbol.Comma_En);
            }

            return sb.ToString().TrimEnd(',');
        }

        /// <summary>
        ///   自定义扩展方法：使用中文状态下的双引号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回“ProductName”
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithDoubleQuotationZh(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.DoubleQuotation_Left_Zh, StringUtils.Symbol.DoubleQuotation_Right_Zh);
        }

        /// <summary>
        ///   自定义扩展方法：使用英文状态下的双引号来包裹字符串。
        ///   如果扩展对象本身为null或者空或者空白字符串，则返回空字符串。
        ///   例如：ProductName，执行该方法后返回"ProductName"
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string WrapWithDoubleQuotationEn(this string @this)
        {
            return DoWrap(@this, StringUtils.Symbol.DoubleQuotation_Left_En, StringUtils.Symbol.DoubleQuotation_Right_En);
        }

    }
}