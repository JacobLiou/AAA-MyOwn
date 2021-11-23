using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  �Զ�����չ������ ��ȡ IDataRecord �е��е����Ƽ���
        /// </summary>
        /// <param name="this">��չ����</param>
        /// <returns></returns>
        public static List<string> GetColumnNames(this IDataRecord @this)
        {
            return Enumerable.Range(0, @this.FieldCount)
                             .Select(@this.GetName)
                             .ToList();
        }
    }
}