using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ַ�������
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns>�������ַ���</returns>
        public static string Reverse(this string @this)
        {
            if (@this.Length <= 1)
                return @this;

            char[] chars = @this.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}