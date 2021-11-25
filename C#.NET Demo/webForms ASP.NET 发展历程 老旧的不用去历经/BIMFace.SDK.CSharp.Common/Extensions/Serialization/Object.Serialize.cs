#region using

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

using Newtonsoft.Json.Converters;

using Formatting = System.Xml.Formatting;

#endregion

namespace BIMFace.SDK.CSharp.Common.Extensions
{
    public static partial class CommonExtension
    {
        #region ToXml

        /// <summary>
        ///     自定义扩展方法：将 object 对象(一般指的是实体类等)序列化为 XML 字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <returns></returns>
        public static string SerializeToXml(this object @this, bool isFormat = false)
        {
            if (null == @this)
            {
                throw new ArgumentNullException("@this");
            }

            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            UTF8Encoding encoding = new UTF8Encoding(false);
            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, encoding)
            {
                Formatting = isFormat ? Formatting.Indented : Formatting.None
            };

            try
            {
                XmlSerializer serializer = new XmlSerializer(@this.GetType());
                serializer.Serialize(writer, @this, ns);
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Can not convert object to xml.");
            }
            finally
            {
                writer.Close();
            }

            return encoding.GetString(stream.ToArray());
        }

        #endregion

        #region ToJson

        /// <summary>
        ///     自定义扩展方法：将指定的对象对象序列化为 Json 字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <returns></returns>
        public static string SerializeToJson<T>(this T @this, bool isFormat = false) where T : class
        {
            Newtonsoft.Json.Formatting formatting = isFormat ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None;
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            return JsonConvert.SerializeObject(@this, formatting, timeConverter);
        }

        /// <summary>
        ///     自定义扩展方法：将 XML 文档中的单个节点序列化为 Json 字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">XML 文档中的单个节点</param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <param name="omitRootObject">是否省略写入根对象</param>
        /// <returns></returns>
        public static string SerializeToJson<T>(this XmlNode @this, bool isFormat = false,bool omitRootObject = false) where T : class
        {
            Newtonsoft.Json.Formatting formatting = isFormat ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None;

            return JsonConvert.SerializeXmlNode(@this, formatting, omitRootObject);
        }

        /// <summary>
        ///     自定义扩展方法：将 System.Xml.Linq.XNode 对象序列化为Json字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this"></param>
        /// <param name="isFormat">是否需要格式化，缩进显示</param>
        /// <param name="omitRootObject">是否省略写入根对象</param>
        /// <returns></returns>
        public static string SerializeToJson<T>(this XObject @this, bool isFormat = false,bool omitRootObject = false) where T : class
        {
            Newtonsoft.Json.Formatting formatting = isFormat ? Newtonsoft.Json.Formatting.Indented : Newtonsoft.Json.Formatting.None;

            return JsonConvert.SerializeXNode(@this, formatting, omitRootObject);
        }

        #endregion

        #region ToBinary

        /// <summary>
        ///     自定义扩展方法：使用当前操作系统默认的ANSI编码方式将泛型类型对象序列化为二进制字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <returns></returns>
        public static string SerializeToBinary<T>(this T @this)
        {
            var binaryWrite = new BinaryFormatter();

            using (var memoryStream = new MemoryStream())
            {
                binaryWrite.Serialize(memoryStream, @this);

                return Encoding.Default.GetString(memoryStream.ToArray());
            }
        }

        /// <summary>
        ///     自定义扩展方法：使用指定的编码方式将泛型类型对象序列化为二进制字符串
        /// </summary>
        /// <param name="this">扩展对象</param>
        /// <param name="encoding">编码方式</param>
        /// <returns></returns>
        public static string SerializeBinary<T>(this T @this, Encoding encoding)
        {
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