using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///   �Զ�����չ������ȷ����ǰ System.Type ��ʾ��������ָ���������Ƿ���ȣ�
        ///   �����Ƿ��Ǵ�ָ���� System.Type ��ʾ����������
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="type">�뵱ǰ�� Type ���бȽϵ� Type</param>
        /// <returns></returns>
        public static bool IsTypeOrInheritsOf<T>(this T @this, Type type)
        {
            Type objectType = @this.GetType();

            while (true)
            {
                if (objectType.Equals(type))
                    return true;

                if ((objectType == objectType.BaseType) || (objectType.BaseType == null))
                    return false;

                objectType = objectType.BaseType;
            }
        }
    }
}