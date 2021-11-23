using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ ��������ָ�����ƵĹ������Ի��ֶΡ�
        ///  ���ؾ���ָ�����ƵĹ������Ի��ֶΣ�����Ҳ����򷵻� null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="name">Ҫ��ȡ�Ĺ������Ի��ֶε�����</param>
        /// <returns></returns>
        public static MemberInfo GetPropertyOrField<T>(this T @this,string name)
        {
            PropertyInfo property = @this.GetProperty(name);
            if(property != null)
            {
                return property;
            }

            FieldInfo field = @this.GetField(name);
            if(field != null)
            {
                return field;
            }

            return null;
        }
    }
}