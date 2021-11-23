namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        #region IEnumerable<T>����չ���� JoinWith �Ѿ�ʵ�����¹���

        ///// <summary>
        ///// �Զ�����չ�����������ַ������������Ԫ�أ�������ÿ��Ԫ��֮�佫ָ���ָ���
        ///// </summary>
        ///// <param name="values">һ�����飬���а���Ҫ���ӵ�Ԫ��</param>
        ///// <param name="separator">Ҫ�����ָ������ַ���</param>
        ///// <returns> һ���� value �е�Ԫ����ɵ��ַ�������ЩԪ���� separator �ַ����ָ�</returns>
        //public static string Join(this string[] values,string separator)
        //{
        //    return string.Join(separator, values);
        //}

        ///// <summary>
        ///// �Զ�����չ������ ������������ĸ���Ԫ�أ�������ÿ��Ԫ��֮�佫ָ���ָ���
        ///// </summary>
        ///// <param name="values">һ�����飬���а���Ҫ���ӵ�Ԫ��</param>
        ///// <param name="separator">Ҫ�����ָ������ַ���</param>
        ///// <returns> һ���� value �е�Ԫ����ɵ��ַ�������ЩԪ���� separator �ַ����ָ�</returns>
        //public static string Join(this object[] values, string separator)
        //{
        //    return string.Join(separator, values);
        //}

        ///// <summary>
        ///// �Զ�����չ������ �����ַ������ϵĳ�Ա��������ÿ����Ա֮�佫ָ���ָ���
        ///// </summary>
        ///// <typeparam name="T">�������Ͳ���</typeparam>
        ///// <param name="values">һ�����飬���а���Ҫ���ӵ�Ԫ��</param>
        ///// <param name="separator">Ҫ�����ָ������ַ���</param>
        ///// <returns> һ���� value �е�Ԫ����ɵ��ַ�������ЩԪ���� separator �ַ����ָ�</returns>
        //public static string Join<T>(this IEnumerable<T> values, string separator)
        //{
        //    return string.Join(separator, values);
        //}

        ///// <summary>
        ///// �Զ�����չ������ ��������Ϊ System.string �� System.Collections.Generic.IEnumerable`1 ���켯�ϵĳ�Ա��������ÿ����Ա֮�佫ָ���ָ���
        ///// </summary>
        ///// <param name="values">һ������Ҫ�������ַ����ļ���</param>
        ///// <param name="separator">Ҫ�����ָ������ַ���</param>
        ///// <returns> һ���� values �ĳ�Ա��ɵ��ַ�������Щ��Ա�� separator �ַ����ָ�</returns>
        //public static string Join(this IEnumerable<string> values,string separator)
        //{
        //    return string.Join(separator, values);
        //}

        /// <summary>
        ///  �Զ�����չ�����������ַ��������ָ��Ԫ�أ�������ÿ��Ԫ��֮�佫ָ���ָ���
        /// </summary>
        /// <param name="values">һ������Ҫ�������ַ����ļ���</param>
        /// <param name="separator">Ҫ�����ָ������ַ���</param>
        /// <param name="startIndex">value ��Ҫʹ�õĵ�һ��Ԫ��</param>
        /// <param name="count"> Ҫʹ�õ� value ��Ԫ����</param>
        /// <returns>�� value �е��ַ�����ɵ��ַ�������Щ�ַ����� separator �ַ����ָ���
        ///          ��� count Ϊ�㣬value û��Ԫ�أ��� separator�Լ� value ��ȫ��Ԫ�ؾ�Ϊ System.string.Empty����Ϊ System.string.Empty
        /// </returns>
        public static string JoinWith(this string[] values,string separator, int startIndex, int count)
        {
            return string.Join(separator, values, startIndex, count);
        }

        #endregion
    }
}