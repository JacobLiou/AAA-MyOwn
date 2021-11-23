using System.Data;
using System.IO;
using System.Xml;

namespace ZCN.NET.CommonX.Utils
{
    /// <summary>
    ///  xml 操作辅助类
    /// </summary>
    public class XmlUtils
    {
        /// <summary>
        ///  自定义工具类，将 XML 字符串转换为 DataSet 数据集
        /// </summary>
        /// <param name="xml">有效的xml字符串</param>
        /// <returns></returns>
        public static DataSet ConvertXmlToDataSet(string xml)
        {
            if(string.IsNullOrWhiteSpace(xml))
                return null;

            DataSet ds = new DataSet();
            
            using(StringReader stringReader = new StringReader(xml))
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader(stringReader))
                {
                    ds.ReadXml(xmlTextReader);
                }
            }

            return ds;
        }
    }
}