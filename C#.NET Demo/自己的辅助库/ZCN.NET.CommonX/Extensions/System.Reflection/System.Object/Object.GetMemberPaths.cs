using System;
using System.Collections.Generic;
using System.Reflection;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ���������ݳ�Ա�����ȫ���ƻ�ȡ���еĳ�Ա��Ϣ
        /// </summary>
        /// <typeparam name="T">�������Ͳ���</typeparam>
        /// <param name="this">��չ����</param>
        /// <param name="path">��Ա�����ȫ���ƣ����� �����ռ�.����.���� ��</param>
        /// <returns></returns>
        public static MemberInfo[] GetMemberPaths<T>(this T @this, string path)
        {
            Type lastType = @this.GetType();
            string[] paths = path.Split('.');

            var memberPaths = new List<MemberInfo>();

            foreach(string item in paths)
            {
                PropertyInfo propertyInfo = lastType.GetProperty(item);
                FieldInfo fieldInfo = lastType.GetField(item);

                if(propertyInfo != null)
                {
                    memberPaths.Add(propertyInfo);
                    lastType = propertyInfo.PropertyType;
                }
                if(fieldInfo != null)
                {
                    memberPaths.Add(fieldInfo);
                    lastType = fieldInfo.FieldType;
                }
            }

            return memberPaths.ToArray();
        }
    }
}