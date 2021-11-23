using System;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ַ������Ƴ�ָ���������ַ�
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="predicate">��������</param>
        /// <returns></returns>
        public static string RemoveWhere(this string @this, Func<char, bool> predicate)
        {
            return new string(@this.ToCharArray().Where(x => !predicate(x)).ToArray());
        }
    }
}