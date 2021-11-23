using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������������ָ�����ƵĹ����ֶΡ�
        ///  ���ҵ�����Ϊ��ʾ����ָ�����ƵĹ����ֶε� System.Reflection.FieldInfo ���󣻷���Ϊ null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="name">Ҫ��ȡ�������ֶε�����</param>
        /// <returns></returns>
        public static FieldInfo GetField<T>(this T @this, string name)
        {
            return @this.GetType().GetField(name);
        }

        /// <summary>
        ///  �Զ�����չ������ʹ��ָ����Լ������ָ���ֶΡ�
        ///  ���ط���ָ��Ҫ����ֶε� System.Reflection.FieldInfo ��������ҵ��Ļ���������Ϊ null
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="name">Ҫ��ȡ�������ֶε�����</param>
        /// <param name="bindingAttr">һ��λ���Σ���һ������ָ������ִ�з�ʽ�� System.Reflection.BindingFlags ��ɡ�
        ///  �� �㣬�Է��� null</param>
        /// <returns></returns>
        public static FieldInfo GetField<T>(this T @this, string name, BindingFlags bindingAttr)
        {
            return @this.GetType().GetField(name, bindingAttr);
        }
    }
}