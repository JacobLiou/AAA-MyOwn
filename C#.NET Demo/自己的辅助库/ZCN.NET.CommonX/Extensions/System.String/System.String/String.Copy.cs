using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ ����һ����ָ���� System.String ������ֵͬ�� System.String ����ʵ��
        /// </summary>
        /// <param name="str">�ַ���</param>
        /// <returns> ֵ�� str ��ͬ�����ַ���</returns>
        public static string Copy(this string str)
        {
            /* �� .NET Core 3.0 ��ʼ���˷����ѹ�ʱ�� ���ǣ����ǲ��������κ�.NET ʵ����ʹ�á�
             * �ر��ǣ����� .NET Core 3.0 �е��ַ����ݴ淢���˸��ģ���ˣ���ĳЩ����£��� Copy ���������ᴴ���µ��ַ�������ֻ�᷵�ض������ݴ��ַ��������á�
             * ��ο� https://docs.microsoft.com/zh-cn/dotnet/api/system.string.copy?view=net-5.0
             */
            return String.Copy(str);
        }
    }
}