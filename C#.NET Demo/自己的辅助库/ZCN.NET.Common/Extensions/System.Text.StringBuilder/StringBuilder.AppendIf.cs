using System;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�����������������е�����Ԫ��ѭ������ί�к�����ִ�У�
        ///  �������ִ�н��Ϊtrue����Ԫ��׷�ӵ���չ�����β
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="predicate">����ί�к���</param>
        /// <param name="values">������������</param>
        /// <returns></returns>
        public static StringBuilder AppendIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (var value in values)
            {
                if (predicate(value))
                {
                    @this.Append(value);
                }
            }

            return @this;
        }
        
        /// <summary>
        ///  �Զ�����չ�����������������е�����Ԫ��ѭ������ί�к�����ִ�У�
        ///  �������ִ�н��Ϊtrue����Ԫ��׷�ӵ���չ�����β(���л��з���) 
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="predicate">����ί�к���</param>
        /// <param name="values">������������</param>
        /// <returns></returns>
        public static StringBuilder AppendLineIf<T>(this StringBuilder @this, Func<T, bool> predicate, params T[] values)
        {
            foreach (var value in values)
            {
                if (predicate(value))
                {
                    @this.AppendLine(value.ToString());
                }
            }

            return @this;
        }
    }
}