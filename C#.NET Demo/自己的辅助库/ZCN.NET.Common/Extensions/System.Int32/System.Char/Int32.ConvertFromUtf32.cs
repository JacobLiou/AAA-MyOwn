using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ��������ָ�� Unicode ��λת��Ϊ UTF-16 �����ַ�����
        /// ������һ�� System.Char �����һ�� System.Char ����Ĵ��������ɵ��ַ�����
        /// ��Ч�� utf32 ������ָ������λ
        /// </summary>
        /// <param name="utf32">��չ����21 λ Unicode ��λ</param>
        /// <returns></returns>
        public static string ConvertFromUtf32(this Int32 utf32)
        {
            return Char.ConvertFromUtf32(utf32);
        }
    }
}