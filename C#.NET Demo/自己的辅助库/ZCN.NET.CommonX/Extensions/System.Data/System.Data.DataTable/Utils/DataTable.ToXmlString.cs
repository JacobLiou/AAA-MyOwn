using System.Data;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///  自定义扩展方法：将 DataTable 内容转换为 XML 格式字符串。
        ///  如果 DataTable 为 null 或者其行计数为0，则返回空字符串
        /// </summary>
        /// <param name="dt">扩展对象</param>
        /// <returns></returns>

        public static string ToXmlString(this DataTable dt)
        {
            string result;
            if(dt.IsNotNullAndEmpty())
            {
                StringBuilder sb = new StringBuilder();
                XmlWriter writer = XmlWriter.Create(sb);
                XmlSerializer serializer = new XmlSerializer(typeof(DataTable));
                serializer.Serialize(writer,dt);
                writer.Close();
                result = sb.ToString();
            }
            else
            {
                result = string.Empty;
            }

            return result;
        }
    }
}