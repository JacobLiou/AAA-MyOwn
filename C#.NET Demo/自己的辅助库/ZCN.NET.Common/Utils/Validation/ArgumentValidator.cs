using System;

namespace ZCN.NET.Common.Utils
{
    /// <summary>
    ///     参数校验工具类类
    /// </summary>
    public class ArgumentValidator
    {
        private ArgumentValidator()
        {
        }

        /// <summary>
        ///     <para>检查参数<paramref name="variable" />是否为空字符串。</para>
        /// </summary>
        /// <param name="variable">待检查的值</param>
        /// <param name="variableName">参数的名称</param>
        public static void CheckForEmptyString(string variable, string variableName)
        {
            CheckForNullReference(variable, variableName);
            CheckForNullReference(variableName, "variableName");
            if(variable.Length == 0)
            {
                string message = string.Format(EXCEPTION_EMPTY_STRING, variableName);

                throw new ArgumentException(message);
            }
        }

        /// <summary>
        ///     <para>检查参数<paramref name="variable" />是否为空引用(Null)。</para>
        /// </summary>
        /// <param name="variable">待检查的值</param>
        /// <param name="variableName">待检查变量的名称</param>
        public static void CheckForNullReference(object variable, string variableName)
        {
            if(variableName == null)
            {
                throw new ArgumentNullException("variableName");
            }

            if(null == variable)
            {
                throw new ArgumentNullException(variableName);
            }
        }

        /// <summary>
        ///     验证输入的参数messageName非空字符串，也非空引用
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <param name="messageName">参数的值</param>
        public static void CheckForInvalidNullNameReference(string name, string messageName)
        {
            if(string.IsNullOrEmpty(name))
            {
                string message = string.Format(EXCEPTION_INVALID_NULL_NAME_ARGUMENT, messageName);

                throw new InvalidOperationException(message);
            }
        }

        /// <summary>
        ///     <para>验证参数<paramref name="bytes" />非零长度，如果为零长度，则抛出异常<see cref="ArgumentException" />。</para>
        /// </summary>
        /// <param name="bytes">待检查的字节数组</param>
        /// <param name="variableName">待检查参数的名称</param>
        public static void CheckForZeroBytes(byte[] bytes, string variableName)
        {
            CheckForNullReference(bytes, "bytes");
            CheckForNullReference(variableName, "variableName");
            if(bytes.Length == 0)
            {
                string message = string.Format(EXCEPTION_BYTE_ARRAY_VALUE_MUST_BE_GREATER_THAN_ZERO_BYTES, variableName);

                throw new ArgumentException(message);
            }
        }

        /// <summary>
        ///     <para>检查参数<paramref name="variable" />是否符合指定的类型。</para>
        /// </summary>
        /// <param name="variable">待检查的值</param>
        /// <param name="type">参数variable的类型</param>
        public static void CheckExpectedType(object variable, Type type)
        {
            CheckForNullReference(variable, "variable");
            CheckForNullReference(type, "type");
            if(!type.IsInstanceOfType(variable))
            {
                string message = string.Format(EXCEPTION_EXPECTED_TYPE, type.FullName);

                throw new ArgumentException(message);
            }
        }

        /// <summary>
        ///     检查variable是否一个有效的<paramref name="enumType" />枚举类型
        /// </summary>
        /// <param name="variable">待检查的值</param>
        /// <param name="enumType">参数variable的枚举类型</param>
        /// <param name="variableName">变量variable的名称</param>
        public static void CheckEnumeration(Type enumType, object variable, string variableName)
        {
            CheckForNullReference(variable, "variable");
            CheckForNullReference(enumType, "enumType");
            CheckForNullReference(variableName, "variableName");

            if(!Enum.IsDefined(enumType, variable))
            {
                string message = string.Format(EXCEPTION_ENUMERATION_NOT_DEFINED,
                                               variable, enumType.FullName, variableName);

                throw new ArgumentException(message);
            }
        }

        #region 提示信息常量

        private const string EXCEPTION_EMPTY_STRING = "参数 '{0}'的值不能为空字符串。";
        private const string EXCEPTION_INVALID_NULL_NAME_ARGUMENT = "参数'{0}'的名称不能为空引用或空字符串。";
        private const string EXCEPTION_BYTE_ARRAY_VALUE_MUST_BE_GREATER_THAN_ZERO_BYTES = "数值必须大于0字节.";
        private const string EXCEPTION_EXPECTED_TYPE = "无效的类型，期待的类型必须为'{0}'。";
        private const string EXCEPTION_ENUMERATION_NOT_DEFINED = "{0}不是{1}的一个有效值";

        #endregion
    }
}