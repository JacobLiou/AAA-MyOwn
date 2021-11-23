using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ������ȷ����ǰ System.Type ��ʾ�����Ƿ��Ǵ�ָ���� System.Type ��ʾ����������
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="type">�뵱ǰ�� Type ���бȽϵ� Type</param>
        /// <returns></returns>
        public static bool IsSubclassOf<T>(this T @this, Type type)
        {
            return @this.GetType().IsSubclassOf(type);
        }
    }
}