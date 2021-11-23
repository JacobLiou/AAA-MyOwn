using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ�������жϵ�ǰ System.Type ��ʾ��������ָ���������Ƿ����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="type">�뵱ǰ�� Type ���бȽϵ� Type</param>
        /// <returns></returns>
        public static bool IsTypeOf<T>(this T @this, Type type)
        {
            return @this.GetType() == type;
        }
    }
}