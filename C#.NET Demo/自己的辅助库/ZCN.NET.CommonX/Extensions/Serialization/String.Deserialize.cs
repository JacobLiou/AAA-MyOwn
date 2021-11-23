﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

/*.NET Core 3.0 里提供新的 JSON API:System.Text.Json.dll，目前功能还不是很完善。暂时使用 Newtonsoft.Json.dll，待 System.Text.Json.dll 完善后改成使用此DLL。*/
using Newtonsoft.Json;

namespace ZCN.NET.CommonX.Extensions
{
    public static partial class CommonExtensions
    {
        /// <summary>
        ///     自定义扩展方法:将 Json 字符串反序列化为指定类型的对象(一般是实体类等)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="this">json字符串</param>
        /// <param name="settings">json字符串</param>
        /// <returns></returns>
        public static T DeserializeJsonToObject<T>(this string @this, JsonSerializerSettings settings = null) where T : class
        {
            if (null == @this)
                return null;

            return JsonConvert.DeserializeObject<T>(@this, settings);
        }

        /// <summary>
        ///     自定义扩展方法:将json格式的<see cref="T:System.Xml.XmlNode" /> 字符串转换为XmlNode
        /// </summary>
        /// <param name="this">json字符串</param>
        /// <param name="deserializeRootElementName">反序列化时要附加的根元素的名称</param>
        /// <param name="writeArrayAttribute">指示是否写入json.net数组属性的标志。此属性有助于在将写入的XML转换回json时保留数组。</param>
        /// <returns></returns>
        public static XmlNode DeserializeJsonToXmlNode(this string @this, string deserializeRootElementName = null, bool writeArrayAttribute = false)
        {
            return JsonConvert.DeserializeXmlNode(@this, deserializeRootElementName, writeArrayAttribute);
        }

        /// <summary>
        ///     自定义扩展方法:将 Json格式的<see cref="T:System.Xml.Linq.XNode" /> 字符串反序列化为XDocument
        /// </summary>
        /// <param name="this">json字符串</param>
        /// <param name="deserializeRootElementName">反序列化时要附加的根元素的名称</param>
        /// <param name="writeArrayAttribute">指示是否写入json.net数组属性的标志。此属性有助于在将写入的XML转换回json时保留数组。</param>
        /// <returns></returns>
        public static XDocument DeserializeJsonToXNode(this string @this, string deserializeRootElementName = null, bool writeArrayAttribute = false)
        {
            return JsonConvert.DeserializeXNode(@this, deserializeRootElementName, writeArrayAttribute);
        }

        /// <summary>
        ///     自定义扩展方法： 将 XML 字符串反序列化为指定类型的对象。类及属性需要做xml特性标记，与xml文件格式对应。
        /// </summary>
        /// <typeparam name="T">泛型类型参数，例如 typeof(实体、DataTable、List集合等对象)</typeparam>
        /// <param name="this">XML字符串</param>
        /// <returns></returns>
        public static object DeserializeXmlToObject<T>(this string @this) where T : class
        {
            object obj;
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringReader strReader = new StringReader(@this);
            XmlReader reader = new XmlTextReader(strReader);

            try
            {
                obj = serializer.Deserialize(reader);
            }
            catch (InvalidOperationException ie)
            {
                throw new InvalidOperationException("无法将xml文件转换为object对象。", ie);
            }
            finally
            {
                reader.Close();
            }
            return obj;
        }

        /// <summary>
        ///     自定义扩展方法： 将 XML 字符串反序列化为泛型类型对象。类及属性需要做xml特性标记，与xml文件格式对应。
        /// </summary>
        /// <typeparam name="T">泛型类型参数，例如 typeof(实体、DataTable、List集合等对象)</typeparam>
        /// <param name="this">XML字符串</param>
        /// <returns></returns>
        public static T DeserializeXmlToTObject<T>(this string @this) where T : class
        {
            return (T)@this.DeserializeXmlToObject<T>();
        }

        #region 【由于 BinaryFormatter 存在安全漏洞，从 .NET 5.0 开始被标记为已过时。请考虑使用 JsonSerializer 或 XmlSerializer，而不是 BinaryFormatter】

        ///// <summary>
        /////   自定义扩展方法：使用当前操作系统默认的 ANSI 编码方式将二进制字符串反序列化为泛型类型对象
        ///// </summary>
        ///// <param name="this">扩展对象。二进制字符串</param>
        ///// <returns></returns>
        //public static T DeserializeFromBinary<T>(this string @this)
        //{
        //    using (var stream = new MemoryStream(Encoding.Default.GetBytes(@this)))
        //    {
        //        var binaryRead = new BinaryFormatter();
        //        return (T)binaryRead.Deserialize(stream);
        //    }
        //}

        ///// <summary>
        /////   自定义扩展方法：使用指定的编码方式将二进制字符串反序列化为泛型类型对象
        ///// </summary>
        ///// <param name="this">扩展对象。二进制字符串</param>
        ///// <param name="encoding">编码方式</param>
        ///// <returns></returns>
        //public static T DeserializeFromBinary<T>(this string @this, Encoding encoding)
        //{
        //    using (var stream = new MemoryStream(encoding.GetBytes(@this)))
        //    {
        //        var binaryRead = new BinaryFormatter();
        //        return (T)binaryRead.Deserialize(stream);
        //    }
        //}

        #endregion
    }
}