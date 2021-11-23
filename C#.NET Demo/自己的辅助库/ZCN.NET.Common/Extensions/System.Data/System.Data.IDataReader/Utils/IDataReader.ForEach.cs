using System;
using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ѭ�� IDataReader ������ִ��ָ���ķ���������Դ IDataReader ����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="action">����</param>
        /// <returns></returns>
        public static IDataReader ForEach(this IDataReader @this, Action<IDataReader> action)
        {
            while(@this.Read())
            {
                action(@this);
            }

            return @this;
        }
    }
}