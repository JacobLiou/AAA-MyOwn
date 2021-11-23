using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

/*.NET Core 3.0 里提供新的 JSON API:System.Text.Json.dll，目前功能还不是很完善。暂时使用 Newtonsoft.Json.dll，待 System.Text.Json.dll 完善后改成使用此DLL。*/
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ZCN.NET.Common.Extensions
{
    public static partial class CommonExtensions
    {
        #region ToJson

        /// <summary>
        ///     自定义扩展方法：将指定的对象对象(一般是实体类等)序列化为 Json 字符串。
        ///     如果参数为null，则返回空字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <returns></returns>
        public static string SerializeToJson<T>(this T @this, bool isFormat = false) where T : class
        {
            if (null == @this)
                return string.Empty;

            Newtonsoft.Json.Formatting formatting = isFormat ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None;
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            return JsonConvert.SerializeObject(@this, formatting, timeConverter);
        }

        /// <summary>
        ///     自定义扩展方法：将 XML 文档中的单个节点序列化为 Json 字符串。
        ///     如果参数为null，则返回空字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">XML 文档中的单个节点</param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <param name="omitRootObject">是否省略写入根对象</param>
        /// <returns></returns>
        public static string SerializeToJson<T>(this XmlNode @this, bool isFormat = false, bool omitRootObject = false) where T : class
        {
            if (null == @this)
                return string.Empty;

            Newtonsoft.Json.Formatting formatting =
                isFormat ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None;

            return JsonConvert.SerializeXmlNode(@this, formatting, omitRootObject);
        }

        /// <summary>
        ///     自定义扩展方法：将 System.Xml.Linq.XNode 对象序列化为Json字符串。
        ///     如果参数为null，则返回空字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <param name="omitRootObject">是否省略写入根对象</param>
        /// <returns></returns>
        public static string SerializeToJson<T>(this XObject @this, bool isFormat = false, bool omitRootObject = false) where T : class
        {
            if (null == @this)
                return string.Empty;

            Newtonsoft.Json.Formatting formatting =
                isFormat ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None;

            return JsonConvert.SerializeXNode(@this, formatting, omitRootObject);
        }

        #endregion

        #region ToXml

        /// <summary>
        ///     自定义扩展方法：将 object 对象(一般是实体类等)序列化为 XML 字符串。
        ///     如果参数为null，则返回空字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <returns></returns>
        public static string SerializeToXml(this object @this, bool isFormat = false)
        {
            if (null == @this)
                return string.Empty;

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            UTF8Encoding encoding = new UTF8Encoding(false);
            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, encoding)
            {
                Formatting = isFormat ? System.Xml.Formatting.Indented : System.Xml.Formatting.None
            };

            try
            {
                XmlSerializer serializer = new XmlSerializer(@this.GetType());
                serializer.Serialize(writer, @this, ns);
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("无法转换为xml。");
            }
            finally
            {
                writer.Close();
            }

            return encoding.GetString(stream.ToArray());
        }

        #endregion

        #region ToBinary

        /// <summary>
        ///     自定义扩展方法：使用当前操作系统默认的ANSI编码方式将泛型类型对象(一般是实体类等)序列化为二进制字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string SerializeToBinary<T>(this T @this)
        {
            if (null == @this)
                return string.Empty;

            var binaryWrite = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryWrite.Serialize(memoryStream, @this);
                return Encoding.Default.GetString(memoryStream.ToArray());
            }
        }

        /// <summary>
        ///     自定义扩展方法：使用指定的编码方式将泛型类型对象(一般是实体类等)序列化为二进制字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns></returns>
        public static string SerializeBinary<T>(this T @this, Encoding encoding)
        {
            if (null == @this)
                return string.Empty;

            var binaryWrite = new BinaryFormatter();
            using (var memoryStream = new MemoryStream())
            {
                binaryWrite.Serialize(memoryStream, @this);
                return encoding.GetString(memoryStream.ToArray());
            }
        }

        #endregion
    }
}