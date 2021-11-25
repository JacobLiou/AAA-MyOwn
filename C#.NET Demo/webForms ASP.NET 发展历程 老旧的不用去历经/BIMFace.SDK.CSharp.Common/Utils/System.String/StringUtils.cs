
namespace BIMFace.SDK.CSharp.Common.Utils
{
    /// <summary>
    ///   字符串操作辅助类
    /// </summary>
    public partial class StringUtils
    {
        /// <summary>
        /// 字符串中一些常用的符号
        /// </summary>
        public class Symbol
        {
            /// <summary>
            ///  获取一个值，该值表示字符串中的一个空格
            /// </summary> 
            public const string Space1 = " ";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的一个点.
            /// </summary>
            public const string Dot1 = ".";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的三个点.
            /// </summary>
            public const string Dot3 = "...";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的六个点.
            /// </summary>
            public const string Dot6 = "......";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的方括号左边部分【
            /// </summary>
            public const string Brackets_Left_Zh = "【";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的方括号右边部分】
            /// </summary>
            public const string Brackets_Right_Zh = "】";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的方括号左边部分[
            /// </summary>
            public const string Brackets_Left_En = "[";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的方括号右边部分]
            /// </summary>
            public const string Brackets_Right_En = "]";

            /// <summary>
            ///  获取一个值，该值表示花括号左边部分{
            /// </summary>
            public const string Braces_Left = "{";

            /// <summary>
            ///  获取一个值，该值表示花括号右边部分}
            /// </summary>
            public const string Braces_Right = "}";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的圆括号左边部分（
            /// </summary>
            public const string Parentheses_Left_Zh = "（";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的圆括号右边部分）
            /// </summary>
            public const string Parentheses_Right_Zh = "）";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的圆括号左边部分(
            /// </summary>
            public const string Parentheses_Left_En = "(";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的圆括号右边部分)
            /// </summary>
            public const string Parentheses_Right_En = ")";

            /// <summary>
            ///  获取一个值，该值表示下划线_
            /// </summary>
            public const string Underline = "_";

            /// <summary>
            ///  获取一个值，该值表示中文状态下中划线—
            /// </summary>
            public const string Middileline_Zh = "—";

            /// <summary>
            ///  获取一个值，该值表示英文状态下中划线-
            /// </summary>
            public const string Middileline_En = "-";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的逗号，
            /// </summary>
            public const string Comma_Zh = "，";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的逗号,
            /// </summary>
            public const string Comma_En = ",";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的冒号：
            /// </summary>
            public const string Colon_Zh = "：";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的冒号:
            /// </summary>
            public const string Colon_En = ":";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的单引号左边部分‘
            /// </summary>
            public const string SingleQuotation_Left_Zh = "‘";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的单引号右边部分’
            /// </summary>
            public const string SingleQuotation_Right_Zh = "’";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的单引号左边部分'
            /// </summary>
            public const string SingleQuotation_Left_En = "'";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的单引号右边部分'
            /// </summary>
            public const string SingleQuotation_Right_En = "'";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的双引号左边部分“
            /// </summary>
            public const string DoubleQuotation_Left_Zh = "“";

            /// <summary>
            ///  获取一个值，该值表示中文状态下的双引号右边部分”
            /// </summary>
            public const string DoubleQuotation_Right_Zh = "”";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的双引号左边部分"
            /// </summary>
            public const string DoubleQuotation_Left_En = "\"";

            /// <summary>
            ///  获取一个值，该值表示英文状态下的双引号右边部分"
            /// </summary>
            public const string DoubleQuotation_Right_En = "\"";

            /// <summary>
            ///  后缀符号。用于拼接某些场景下 FormData 数据的键值对中的键，避免某些键是C#关键字而无法添加。
            ///  解析时再去除该后缀。
            /// </summary>
            public const string KEY_SUFFIX = "_" + BIMFace_SDK_CSharp.ALIAS + "_";
        }

        /// <summary>
        ///  选项集合
        /// </summary>
        public class PikList
        {
            /// <summary>
            ///  获取一个值，该值表示选择项的空项，值为空字符串
            /// </summary> 
            public const string EmptyString = "";

            /// <summary>
            ///  获取一个值，该值表示选择项的空项，值为 ===请选择===
            /// </summary> 
            public const string EmptyItemText = "===请选择===";

            /// <summary>
            ///  获取一个值，该值表示选择项的空项，值为空字符串
            /// </summary> 
            public const string EmptyItemValue = "";
        }
    }
}