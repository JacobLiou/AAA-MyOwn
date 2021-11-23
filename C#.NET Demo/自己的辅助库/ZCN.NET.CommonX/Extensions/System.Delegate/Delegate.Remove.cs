using System;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ��������һ��ί�еĵ����б����Ƴ���һ��ί�е����һ�������б�
        ///  ����һ����ί�У�������б�Ĺ��ɷ���Ϊ����ȡ source �ĵ����б�
        ///  ����� source �ĵ����б����ҵ��� value �ĵ����б�������Ƴ� value �����һ�������б� 
        ///  ��� value Ϊ null������ source �ĵ����б���û���ҵ� value �ĵ����б��򷵻� source��
        ///  ��� value �ĵ����б���� source �ĵ����б��� source Ϊ�����ã��򷵻ؿ�����
        /// </summary>
        /// <param name="source">��չ����ί�У��������Ƴ� value �ĵ����б�</param>
        /// <param name="value">ί�У����ṩ���������Ƴ� source �ĵ����б�ĵ����б�</param>
        /// <returns></returns>
        public static Delegate Remove(this Delegate source,Delegate value)
        {
            return Delegate.Remove(source,value);
        }
    }
}