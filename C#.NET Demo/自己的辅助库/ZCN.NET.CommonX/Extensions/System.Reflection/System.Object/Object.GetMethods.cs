using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ص�ǰ System.Type �����й���������
        ///  ����Ϊ��ǰ System.Type ��������й��������� System.Reflection.MethodInfo �������顣
        ///  ���û��Ϊ��ǰ System.Type ����Ĺ�����������Ϊ System.Reflection.MethodInfo ���͵Ŀ�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static MethodInfo[] GetMethods<T>(this T @this)
        {
            return @this.GetType().GetMethods();
        }

        /// <summary>
        ///  �Զ�����չ���������ص�ǰ System.Type �����й���������
        ///  ����Ϊ��ǰ System.Type ��������й��������� System.Reflection.MethodInfo �������顣
        ///  ���û��Ϊ��ǰ System.Type ����Ĺ�����������Ϊ System.Reflection.MethodInfo ���͵Ŀ�����
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="bindingAttr">һ��λ���Σ���һ������ָ������ִ�з�ʽ�� System.Reflection.BindingFlags ��ɡ�
        ///  ���㣬�Է��� null</param>
        /// <returns></returns>
        public static MethodInfo[] GetMethods<T>(this T @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetMethods(bindingAttr);
        }
    }
}