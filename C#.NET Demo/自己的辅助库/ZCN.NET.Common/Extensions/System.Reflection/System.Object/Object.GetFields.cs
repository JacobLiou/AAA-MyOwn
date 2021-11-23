using System.Reflection;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ص�ǰ System.Type �����й����ֶΡ�
        ///  ���û��Ϊ��ǰ System.Type ����Ĺ����ֶΣ���Ϊ System.Reflection.FieldInfo ���͵Ŀ�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static FieldInfo[] GetFields(this object @this)
        {
            return @this.GetType().GetFields();
        }

        /// <summary>
        ///  �Զ�����չ������ʹ��ָ����Լ��������Ϊ��ǰ System.Type ������ֶΡ�
        ///  ���û��Ϊ��ǰ System.Type ������ֶΣ��������û��һ��������ֶ�ƥ���Լ������Ϊ System.Reflection.FieldInfo ���͵Ŀ�����
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <param name="bindingAttr"> һ��λ���Σ���һ������ָ������ִ�з�ʽ�� System.Reflection.BindingFlags ��ɡ�
        ///  ���㣬�Է��� null
        /// </param>
        /// <returns></returns>
        public static FieldInfo[] GetFields(this object @this, BindingFlags bindingAttr)
        {
            return @this.GetType().GetFields(bindingAttr);
        }
    }
}