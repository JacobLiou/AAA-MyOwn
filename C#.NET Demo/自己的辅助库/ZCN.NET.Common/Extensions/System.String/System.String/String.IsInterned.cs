using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ������ ������ָ�� System.String ������
        /// </summary>
        /// <param name="str">Ҫ���ݴ�����������ַ���</param>
        /// <returns> ��� str �ڹ�����������ʱ���ݴ���У��򷵻ض��������ã����򷵻� null</returns>
        public static string IsInterned(this string str)
        {
            return String.IsInterned(str);
        }
    }
}