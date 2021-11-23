using System.Data;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        /// �Զ�����չ�����������������ṩ���У���Դ��������ӳ�䵽��������
        /// </summary>
        /// <param name="sourceRow">��չ����Դ������</param>
        /// <param name="newRow">��չ����Ŀ��������</param>
        /// <param name="fieldNames">Ҫӳ�䵽���������е��е�����(�����������������Դ�����е������򱻺���)</param>
        /// <returns></returns>
        private static DataRow ToNewDataRow(this DataRow sourceRow, DataRow newRow, string[] fieldNames)
        {
            foreach (string fieldName in fieldNames)
            {
                if (sourceRow.Table.Columns.Contains(fieldName))
                {
                    newRow[fieldName] = sourceRow[fieldName];
                }
            }

            return newRow;
        }
    }
}