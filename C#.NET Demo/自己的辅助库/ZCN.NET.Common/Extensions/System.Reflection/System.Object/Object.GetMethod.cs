using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ ��������ָ�����ƵĹ���������
        ///  ���ؾ���ָ�����ƵĹ��������� System.Reflection.MethodInfo ��������ҵ��Ļ���������Ϊ null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="name">Ҫ��ȡ�Ĺ�������������</param>
        /// <returns>
        ///   ��ʾ����ָ�����ƵĹ��������� System.Reflection.MethodInfo ��������ҵ��Ļ���������Ϊ null
        /// </returns>
        public static MethodInfo GetMethod<T>(this T @this, string name)
        {
            return @this.GetType().GetMethod(name);
        }

        /// <summary>
        ///  �Զ�����չ������ ʹ��ָ����Լ������ָ��������
        ///  ���ؾ���ָ�����ƵĹ��������� System.Reflection.MethodInfo ��������ҵ��Ļ���������Ϊ null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="name">Ҫ��ȡ�Ĺ�������������</param>
        /// <param name="bindingAttr">һ��λ���Σ���һ������ָ������ִ�з�ʽ�� System.Reflection.BindingFlags ��ɡ�
        ///  �� �㣬�Է��� null
        /// </param>
        /// <returns></returns>
        public static MethodInfo GetMethod<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetMethod(name, bindingAttr);
        }
    }
}