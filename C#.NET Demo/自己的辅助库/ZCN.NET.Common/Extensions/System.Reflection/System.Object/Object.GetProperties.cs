using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ص�ǰ System.Type �����й������ԡ�
        ///  ���ص�ǰ System.Type �����й������Ե� System.Reflection.PropertyInfo �������顣
        ///  �����ǰ System.Type û�й������ԣ���Ϊ System.Reflection.PropertyInfo ���͵Ŀ�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static PropertyInfo[] GetProperties(this object @this)
        {
            return @this.GetType().GetProperties();
        }

        /// <summary>
        ///  �Զ�����չ���������ص�ǰ System.Type �����й������ԡ�
        ///  ���ص�ǰ System.Type �����й������Ե� System.Reflection.PropertyInfo �������顣
        ///  �����ǰ System.Type û�й������ԣ���Ϊ System.Reflection.PropertyInfo ���͵Ŀ�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="bindingAttr">һ��λ���Σ���һ������ָ������ִ�з�ʽ�� System.Reflection.BindingFlags ��ɡ�
        ///  ���㣬�Է��� null</param>
        /// <returns></returns>
        public static PropertyInfo[] GetProperties(this object @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetProperties(bindingAttr);
        }
    }
}