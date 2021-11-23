using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 DataTable 转换为 Hashtable 对象的集合
        /// </summary>
        /// <param name="dt">扩展对象。DataTable 实例</param>
        /// <param name="excludeEmptyRow">如果数据行中的数据都是空的，是否排除并不添加到集合中。默认值为 false</param>
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
        ///  自定义扩展方法：将 DataTable 转换为 Hashtable。
        /// </summary>
        /// <param name="dt">扩展对象。DataTable 实例</param>
        /// <returns></returns>
        [Obsolete("该方法没有实际用处。它只会把DataTable最后一行数据记录在Hashtable中")]
        private static Hashtable ToHashtable(this DataTable dt)
        {
            Hashtable ht = Hashtable.Synchronized(new Hashtable());
           
            if(dt.IsNotNullAndEmpty())
            {
                foreach(DataRow dr in dt.Rows)                //循环扫描行
                {
                    for(int i = 0; i < dt.Columns.Count; i++) //循环扫描每行每列
                    {
                        string key = dt.Columns[i].ColumnName;
                        ht[key] = dr[key];
                    }
                }
            }

            return ht;
        }

        /// <summary>
        ///  自定义扩展方法：将 DataTable 转换为指定的键值对的 Hashtable
        /// </summary>
        /// <param name="dt">扩展对象。DataTable实例</param>
        /// <param name="keyField">指定键</param>
        /// <param name="valFiled">键值</param>
        /// <returns></returns>
        [Obsolete("该方法没有实际用处。它该方法只会把DataTable指定列的最后一行数据记录在Hashtable中")]
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