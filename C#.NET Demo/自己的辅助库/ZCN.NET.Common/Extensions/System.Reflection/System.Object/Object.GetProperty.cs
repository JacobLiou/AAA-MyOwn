using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������������ָ�����ƵĹ������ԡ�
        ///  ���ؾ���ָ�����ƵĹ������Ե� System.Reflection.PropertyInfo ��������ҵ��Ļ���������Ϊ null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="name">Ҫ��ȡ�Ĺ������Ե�����</param>
        /// <returns></returns>
        public static PropertyInfo GetProperty<T>(this T @this,string name)
        {
            return @this.GetType().GetProperty(name);
        }

        /// <summary>
        ///  �Զ�����չ������ ʹ��ָ����Լ������ָ�����ԡ�
        ///  ���ؾ���ָ�����ƵĹ������Ե� System.Reflection.PropertyInfo ��������ҵ��Ļ���������Ϊ null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="name">Ҫ��ȡ�Ĺ������Ե�����</param>
        /// <param name="bindingAttr">һ��λ���Σ���һ������ָ������ִ�з�ʽ�� System.Reflection.BindingFlags ��ɡ�
        ///  �� �㣬�Է��� null
        /// </param>
        /// <returns></returns>
        public static PropertyInfo GetProperty<T>(this T @this,string name,BindingFlags bindingAttr)
        {
            return @this.GetType().GetProperty(name,bindingAttr);
        }
    }
}
