using System;
using System.Globalization;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ʹ����ָ������ƥ��̶���ߵĹ��캯������ָ�����͵�ʵ��
        /// </summary>
        /// <param name="type">��չ����Ҫ�����Ķ��������</param>
        /// <param name="bindingAttr">Ӱ�� type ���캯���������������λ��־����ϡ�
        ///  ��� bindingAttr Ϊ�㣬��Թ������캯���������ִ�Сд������
        /// </param>
        /// <param name="binder"> ʹ�� bindingAttr �� args �����Һͱ�ʶ type ���캯���Ķ���
        ///  ��� binder Ϊ null����ʹ��Ĭ���������
        /// </param>
        /// <param name="args">��Ҫ���ù��캯���Ĳ���������˳�������ƥ��Ĳ������顣
        ///  ��� args Ϊ������� null������ò����κβ����Ĺ��캯����Ĭ�Ϲ��캯����
        /// </param>
        /// <param name="culture">�������ض�����Ϣ����Щ��Ϣ���ƽ� args ǿ��ת��Ϊ type ���캯������������ʽ���͡�
        ///  ��� culture Ϊ null����ʹ�õ�ǰ�̵߳� System.Globalization.CultureInfo
        /// </param>
        /// <returns>���´������������</returns>
        public static Object CreateInstance(this Type type,
                                                   BindingFlags bindingAttr,
                                                   Binder binder,
                                                   Object[] args,
                                                   CultureInfo culture)
        {
            return Activator.CreateInstance(type, bindingAttr, binder, args, culture);
        }

        /// <summary>
        /// �Զ�����չ������
        /// </summary>
        /// <param name="type">��չ����Ҫ�����Ķ��������</param>
        /// <param name="bindingAttr">Ӱ�� type ���캯���������������λ��־����ϡ�
        ///  ��� bindingAttr Ϊ�㣬��Թ������캯���������ִ�Сд������
        /// </param>
        /// <param name="binder"> ʹ�� bindingAttr �� args �����Һͱ�ʶ type ���캯���Ķ���
        ///  ��� binder Ϊ null����ʹ��Ĭ���������
        /// </param>
        /// <param name="args">��Ҫ���ù��캯���Ĳ���������˳�������ƥ��Ĳ������顣
        ///  ��� args Ϊ������� null������ò����κβ����Ĺ��캯����Ĭ�Ϲ��캯����
        /// </param>
        /// <param name="culture">�������ض�����Ϣ����Щ��Ϣ���ƽ� args ǿ��ת��Ϊ type ���캯������������ʽ���͡�
        ///  ��� culture Ϊ null����ʹ�õ�ǰ�̵߳� System.Globalization.CultureInfo
        /// </param>
        /// <param name="activationAttributes">����һ���������Բ��뼤������Ե����顣
        ///  ͨ��Ϊ�������� System.Runtime.Remoting.Activation.UrlAttribute ���������
        /// </param>
        /// <returns>���´������������</returns>
        public static System.Object CreateInstance(this Type type,
                                                   BindingFlags bindingAttr,
                                                   Binder binder,
                                                   Object[] args,
                                                   CultureInfo culture,
                                                   Object[] activationAttributes)
        {
            return Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
        }

        /// <summary>
        /// �Զ�����չ������ʹ����ָ������ƥ��̶���ߵĹ��캯������ָ�����͵�ʵ��
        /// </summary>
        /// <param name="type">��չ����Ҫ�����Ķ��������</param>
        /// <param name="args">��Ҫ���ù��캯���Ĳ���������˳�������ƥ��Ĳ������顣
        ///  ��� args Ϊ������� null������ò����κβ����Ĺ��캯����Ĭ�Ϲ��캯����
        /// </param>
        /// <returns>���´������������</returns>
        public static Object CreateInstance(this Type type, Object[] args)
        {
            return Activator.CreateInstance(type, args);
        }

        /// <summary>
        /// �Զ�����չ������
        /// </summary>ʹ����ָ������ƥ��̶���ߵĹ��캯������ָ�����͵�ʵ��
        /// <param name="type">��չ����Ҫ�����Ķ��������</param>
        /// <param name="args">��Ҫ���ù��캯���Ĳ���������˳�������ƥ��Ĳ������顣
        ///  ��� args Ϊ������� null������ò����κβ����Ĺ��캯����Ĭ�Ϲ��캯����
        /// </param>
        /// <param name="activationAttributes">����һ���������Բ��뼤������Ե����顣
        ///  ͨ��Ϊ�������� System.Runtime.Remoting.Activation.UrlAttribute ���������
        /// </param>
        /// <returns>���´������������</returns>
        public static Object CreateInstance(this Type type, Object[] args, Object[] activationAttributes)
        {
            return Activator.CreateInstance(type, args, activationAttributes);
        }

        /// <summary>
        /// �Զ�����չ������ʹ��ָ�����͵�Ĭ�Ϲ��캯�������������͵�ʵ��
        /// </summary>
        /// <param name="type">��չ����Ҫ�����Ķ��������</param>
        /// <returns>���´������������</returns>
        public static Object CreateInstance(this Type type)
        {
            return Activator.CreateInstance(type);
        }

        /// <summary>
        /// �Զ�����չ������ʹ��ָ�����͵�Ĭ�Ϲ��캯�������������͵�ʵ��
        /// </summary>
        /// <param name="type">��չ����Ҫ�����Ķ��������</param>
        /// <param name="nonPublic">���������ǹ���Ĭ�Ϲ��캯������ƥ�䣬��Ϊ true�����ֻ�й���Ĭ�Ϲ��캯������ƥ�䣬��Ϊ false</param>
        /// <returns>���´������������</returns>
        public static Object CreateInstance(this Type type, Boolean nonPublic)
        {
            return Activator.CreateInstance(type, nonPublic);
        }
    }
}