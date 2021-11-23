using System.Collections.Generic;
using System.Text;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region AppendJoin

        /// <summary>
        /// �Զ�����չ������ʹ�÷ָ������������ͼ����е�Ԫ�ش���������Ȼ��׷�ӵ���չ�����β
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ���</param>
        /// <param name="values">�������ͼ���</param>
        /// <returns></returns>
        public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
        {
            return @this.Append(string.Join(separator, values));
        }

        /// <summary>
        /// �Զ�����չ������ʹ�÷ָ������������������е�Ԫ�ش���������Ȼ��׷�ӵ���չ�����β
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ���</param>
        /// <param name="values">������������</param>
        /// <returns></returns>
        public static StringBuilder AppendJoin<T>(this StringBuilder @this, string separator, params T[] values)
        {
            return @this.Append(string.Join(separator, values));
        }

        #endregion

        #region AppendLineJoin

        /// <summary>
        /// �Զ�����չ������ʹ�÷ָ������������ͼ����е�Ԫ�ش���������Ȼ��׷�ӵ���չ�����β(���л��з���)
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ���</param>
        /// <param name="values">�������ͼ���</param>
        /// <returns></returns>
        public static StringBuilder AppendLineJoin<T>(this StringBuilder @this, string separator, IEnumerable<T> values)
        {
            return @this.AppendLine(string.Join(separator, values));

        }

        /// <summary>
        /// �Զ�����չ������ʹ�÷ָ������������������е�Ԫ�ش���������Ȼ��׷�ӵ���չ�����β(���л��з���)
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="separator">�ָ���</param>
        /// <param name="values">������������</param>
        /// <returns></returns>
        public static StringBuilder AppendLineJoin(this StringBuilder @this, string separator, params object[] values)
        {
            return @this.AppendLine(string.Join(separator, values));
        }

        #endregion
    }
}