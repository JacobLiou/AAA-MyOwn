using System;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ַ������Ƴ�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static string RemoveNumber(this string @this)
        {
            return new string(@this.ToCharArray().Where(x => !Char.IsNumber(x)).ToArray());
        }
    }
}