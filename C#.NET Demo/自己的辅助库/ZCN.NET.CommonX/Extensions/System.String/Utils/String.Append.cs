using System;

using ZCN.NET.CommonX.Utils;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region Append

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加值
        /// </summary>
        /// <param name="this">扩展对象,要连接的第一个字符串</param>
        /// <param name="value">要连接的第二个字符串</param>
        /// <returns></returns>
        public static string Append(this string @this,string value)
        {
            return @this + value;
        }

        #endregion

        #region AppendDot

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加1个点
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendDot(this string @this)
        {
            return @this + StringUtils.Symbol.Dot1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加3个点
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendDot3(this string @this)
        {
            return @this + StringUtils.Symbol.Dot3;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加6个点
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendDot6(this string @this)
        {
            return @this + StringUtils.Symbol.Dot6;
        }

        #endregion

        #region AppendNewLine
        /// <summary>
        ///   自定义扩展方法：在字符串后面添加1个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine(this string @this)
        {
            return @this + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加2个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine2(this string @this)
        {
            return @this
                + Environment.NewLine
                + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加3个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine3(this string @this)
        {
            return @this
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加4个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine4(this string @this)
        {
            return @this
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加5个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine5(this string @this)
        {
            return @this
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加6个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine6(this string @this)
        {
            return @this
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加7个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine7(this string @this)
        {
            return @this
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加8个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine8(this string @this)
        {
            return @this
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加9个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine9(this string @this)
        {
            return @this
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加10个换行符号
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendNewLine10(this string @this)
        {
            return @this
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine
                 + Environment.NewLine;
        }
        #endregion

        #region AppendSpace

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加1个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace(this string @this)
        {
            return @this + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加2个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace2(this string @this)
        {
            return @this
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加3个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace3(this string @this)
        {
            return @this
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加4个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace4(this string @this)
        {
            return @this
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加5个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace5(this string @this)
        {
            return @this
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加6个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace6(this string @this)
        {
            return @this
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1
                + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加7个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace7(this string @this)
        {
            return @this
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加8个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace8(this string @this)
        {
            return @this
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加9个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace9(this string @this)
        {
            return @this
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加10个空格
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSpace10(this string @this)
        {
            return @this
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1
                 + StringUtils.Symbol.Space1;
        }
        #endregion

        #region AppendBrackets

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的方括号左边部分【
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendBracketsLeftZh(this string @this)
        {
            return @this + StringUtils.Symbol.Brackets_Left_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的方括号右边部分】
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendBracketsRightZh(this string @this)
        {
            return @this + StringUtils.Symbol.Brackets_Right_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的方括号左边部分[
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendBracketsLeftEn(this string @this)
        {
            return @this + StringUtils.Symbol.Brackets_Left_En;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的方括号右边部分]
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendBracketsRightEn(this string @this)
        {
            return @this + StringUtils.Symbol.Brackets_Right_En;
        }

        #endregion

        #region AppendBraces

        /// <summary>
        ///   自定义扩展方法：在字符串后面大括号左边部分{
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendBracesLeft(this string @this)
        {
            return @this + StringUtils.Symbol.Braces_Left;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加大括号右边部分}
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendBracesRight(this string @this)
        {
            return @this + StringUtils.Symbol.Braces_Right;
        }

        #endregion

        #region AppendParentheses

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的圆括号左边部分（
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendParenthesessLeftZh(this string @this)
        {
            return @this + StringUtils.Symbol.Parentheses_Left_Zh;             
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的圆括号右边部分）
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendParenthesessRightZh(this string @this)
        {
            return @this + StringUtils.Symbol.Parentheses_Right_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的圆括号左边部分(
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendParenthesessLeftEn(this string @this)
        {
            return @this + StringUtils.Symbol.Parentheses_Left_En;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的圆括号右边部分)
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendParenthesessRightEn(this string @this)
        {
            return @this + StringUtils.Symbol.Parentheses_Right_En;
        }

        #endregion

        #region AppendLine

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加下划线_
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendUnderline(this string @this)
        {
            return @this + StringUtils.Symbol.Underline;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下中划线—
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendModdilelineZh(this string @this)
        {
            return @this + StringUtils.Symbol.Middileline_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文文状态下中划线-
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendModdilelineEn(this string @this)
        {
            return @this + StringUtils.Symbol.Middileline_En;
        }

        #endregion

        #region AppendComma

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下逗号，
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendCommaZh(this string @this)
        {
            return @this + StringUtils.Symbol.Comma_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文文状态下逗号,
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendCommaEn(this string @this)
        {
            return @this + StringUtils.Symbol.Comma_En;
        }

        #endregion

        #region AppendColon

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下冒号：
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendColonZh(this string @this)
        {
            return @this + StringUtils.Symbol.Colon_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文文状态下冒号:
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendColonEn(this string @this)
        {
            return @this + StringUtils.Symbol.Colon_En;
        }


        #endregion

        #region AppendSingleQuotation

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的单引号左边部分‘
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSingleQuotationLeftZh(this string @this)
        {
            return @this + StringUtils.Symbol.SingleQuotation_Left_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的单引号右边部分’
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSingleQuotationRightZh(this string @this)
        {
            return @this + StringUtils.Symbol.SingleQuotation_Right_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的单引号左边部分'
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSingleQuotationLeftEn(this string @this)
        {
            return @this + StringUtils.Symbol.SingleQuotation_Left_En;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的单引号右边部分'
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendSingleQuotationRightEn(this string @this)
        {
            return @this + StringUtils.Symbol.SingleQuotation_Right_En;
        }

        #endregion

        #region AppendDoubleQuotation 

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的双引号左边部分“
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendDoubleQuotationLeftZh(this string @this)
        {
            return @this + StringUtils.Symbol.DoubleQuotation_Left_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加中文状态下的双引号右边部分”
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendDoubleQuotationRightZh(this string @this)
        {
            return @this + StringUtils.Symbol.DoubleQuotation_Right_Zh;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的双引号左边部分"
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendDoubleQuotationLeftEn(this string @this)
        {
            return @this + StringUtils.Symbol.DoubleQuotation_Left_En;
        }

        /// <summary>
        ///   自定义扩展方法：在字符串后面添加英文状态下的双引号右边部分"
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string AppendDoubleQuotationRightEn(this string @this)
        {
            return @this + StringUtils.Symbol.DoubleQuotation_Right_En;
        }

        #endregion
    }
}