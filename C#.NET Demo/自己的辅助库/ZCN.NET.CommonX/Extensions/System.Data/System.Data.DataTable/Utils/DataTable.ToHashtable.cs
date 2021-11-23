using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ�������� DataTable ת��Ϊ Hashtable ����ļ���
        /// </summary>
        /// <param name="dt">��չ����DataTable ʵ��</param>
        /// <param name="excludeEmptyRow">����������е����ݶ��ǿյģ��Ƿ��ų�������ӵ������С�Ĭ��ֵΪ false</param>
        /// <returns></returns>
        public static IList<Hashtable> ToHashtableList(this DataTable dt,bool excludeEmptyRow = false)
        {
            IList<Hashtable> lstHashtable = new List<Hashtable>();
            if(dt.IsNotNullAndEmpty())
            {
                foreach(DataRow dr in dt.Rows)
                {
                    if(excludeEmptyRow)
                    {
                        if(dr.IsNotEmpty())
                        {
                            Hashtable ht = dr.ToHashTable();
                            lstHashtable.Add(ht);
                        }
                    }
                    else
                    {
                        Hashtable ht = dr.ToHashTable();
                        lstHashtable.Add(ht);
                    }
                }
            }

            return lstHashtable;
        }


        /// <summary>
        ///  �Զ�����չ�������� DataTable ת��Ϊ Hashtable��
        /// </summary>
        /// <param name="dt">��չ����DataTable ʵ��</param>
        /// <returns></returns>
        [Obsolete("�÷���û��ʵ���ô�����ֻ���DataTable���һ�����ݼ�¼��Hashtable��")]
        private static Hashtable ToHashtable(this DataTable dt)
        {
            Hashtable ht = Hashtable.Synchronized(new Hashtable());
           
            if(dt.IsNotNullAndEmpty())
            {
                foreach(DataRow dr in dt.Rows)                //ѭ��ɨ����
                {
                    for(int i = 0; i < dt.Columns.Count; i++) //ѭ��ɨ��ÿ��ÿ��
                    {
                        string key = dt.Columns[i].ColumnName;
                        ht[key] = dr[key];
                    }
                }
            }

            return ht;
        }

        /// <summary>
        ///  �Զ�����չ�������� DataTable ת��Ϊָ���ļ�ֵ�Ե� Hashtable
        /// </summary>
        /// <param name="dt">��չ����DataTableʵ��</param>
        /// <param name="keyField">ָ����</param>
        /// <param name="valFiled">��ֵ</param>
        /// <returns></returns>
        [Obsolete("�÷���û��ʵ���ô������÷���ֻ���DataTableָ���е����һ�����ݼ�¼��Hashtable��")]
        private static Hashtable ToHashtableByKeyValue(this DataTable dt,string keyField,string valFiled)
        {
            Hashtable ht = Hashtable.Synchronized(new Hashtable());
            if(dt.IsNotNullAndEmpty())
            {
                foreach(DataRow dr in dt.Rows)
                {
                    string key = dr[keyField].ToString();
                    ht[key] = dr[valFiled];
                }
            }

            return ht;
        }
    }
}