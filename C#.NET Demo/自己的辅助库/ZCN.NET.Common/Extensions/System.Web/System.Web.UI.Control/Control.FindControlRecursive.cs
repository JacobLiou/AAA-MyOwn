#if NETFRAMEWORK

using System.Web.UI;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������ڵ�ǰ�������������������еݹ�������ָ�� id �����ķ������ؼ���
        ///  ����ָ���Ŀؼ�����Ϊ null�����ָ���Ŀؼ������ڵĻ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="id">�ؼ���id</param>
        /// <returns>ָ���Ŀؼ�����Ϊ null�����ָ���Ŀؼ������ڵĻ���</returns>
        public static Control FindControlRecursive(this Control @this, string id)
        {
            Control rControl = @this.FindControl(id);

            if(rControl == null)
            {
                foreach(Control control in @this.Controls)
                {
                    rControl = control.FindControl(id);
                    if(rControl != null)
                    {
                        break;
                    }
                }
            }

            return rControl;
        }

        /// <summary>
        ///  �Զ�����չ�������ڵ�ǰ�������������������еݹ�������ָ�� id �����ķ������ؼ���
        ///  ����ָ���Ŀؼ�����Ϊ null�����ָ���Ŀؼ������ڵĻ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="id">�ؼ���id</param>
        /// <returns>ָ���Ŀؼ�����Ϊ null�����ָ���Ŀؼ������ڵĻ���</returns>
        public static T FindControlRecursive<T>(this Control @this, string id) where T : class
        {
            Control rControl = @this.FindControl(id);

            if(rControl == null)
            {
                foreach(Control control in @this.Controls)
                {
                    rControl = control.FindControl(id);
                    if(rControl != null)
                    {
                        break;
                    }
                }
            }

            return rControl as T;
        }
    }
}

#endif