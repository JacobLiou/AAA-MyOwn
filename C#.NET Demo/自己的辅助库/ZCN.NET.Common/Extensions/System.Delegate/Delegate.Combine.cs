using System;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������������ί�еĵ����б�������һ��
        ///  ����һ����ί�У����ĵ����б� a �� b �ĵ����б���˳��������һ��
        ///  ��� b Ϊ null���򷵻� a��
        ///  ��� a Ϊ null���򷵻� b��
        ///  ��� a �� b ��Ϊ�����ã��򷵻ؿ�����
        /// </summary>
        /// <param name="a">��չ�������ȳ���������б��ί��</param>
        /// <param name="b">������������б��ί��</param>
        /// <returns></returns>
        public static Delegate Combine(this Delegate a,Delegate b)
        {
            return Delegate.Combine(a,b);
        }
    }
}