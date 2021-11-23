#if NETFRAMEWORK

using System.Web.UI;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ڵ�ǰ������������������ָ�� id �����ķ������ؼ���
        ///  ����ָ���Ŀؼ�����Ϊ null�����ָ���Ŀؼ������ڵĻ���
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="id">�ؼ���id</param>
        /// <returns>ָ���Ŀؼ�����Ϊ null�����ָ���Ŀؼ������ڵĻ���</returns>
        public static T FindControl<T>(this Control @this, string id) where T : class
        {
            return (@this.FindControl(id) as T);
        }
    }
}

#endif