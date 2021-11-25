using BIMFace.SDK.CSharp.Common.Exceptions;
using System;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace BIMFace.SDK.CSharp.Common.Utils
{
    /// <summary>
    ///     web.config 或者 app.Config 文件操作辅助类
    /// </summary>
    public sealed class ConfigUtility
    {
        /// <summary>
        ///     获取appSetting节点下指定Key对应的Value值
        /// </summary>
        /// <param name="key">appSetting节点下指定Key</param>
        public static string GetAppSettingValue(string key)
        {
            var value = ConfigurationManager.AppSettings[key].Trim();
            if (string.IsNullOrWhiteSpace(value))
                throw new Configuration2Exception("配置文件中 " + nameof(key) + " 配置项为空。");

            return value;
        }

        /// <summary>
        ///     修改appSetting节点下指定Key对应的Value值
        /// </summary>
        /// <param name="key">appSetting节点下指定Key</param>
        /// <param name="value">要修改为的值</param>
        /// <param name="filePath">要修改的web.config 或者 app.Config文件或者自定义配置文件的相对路径。
        ///     <para>例如自定义配置文件 ~/XmlConfig/system.config 。</para>
        ///     <para>正常配置的Web.config或App.config</para>
        /// </param>
        public static void SetAppSettingValue(string key, string value, string filePath)
        {
            FileInfo file = new FileInfo(filePath);
            string fullName = file.FullName;

            XmlDocument xDoc = new XmlDocument();
            //xDoc.Load(HttpContext.Current.Server.MapPath(filePath));// ?? throw new InvalidOperationException()
            xDoc.Load(fullName);
            XmlNode xNode;
            XmlElement xElem1;
            XmlElement xElem2;
            xNode = xDoc.SelectSingleNode("//appSettings");

            xElem1 = (XmlElement)xNode.SelectSingleNode("//add[@key='" + key + "']");
            if (xElem1 != null) xElem1.SetAttribute("value", value);
            else
            {
                xElem2 = xDoc.CreateElement("add");
                xElem2.SetAttribute("key", key);
                xElem2.SetAttribute("value", value);
                xNode.AppendChild(xElem2);
            }

            //xDoc.Save(HttpContext.Current.Server.MapPath(filePath));
            xDoc.Save(fullName);
        }

        /// <summary>
        ///   获取connectionStrings节点下指定名称的配置对象
        /// </summary>
        /// <param name="name">connectionStrings节点下指定名称</param>
        public ConnectionStringSettings GetConnectionStringSettings(string name)
        {
            return ConfigurationManager.ConnectionStrings[name];
        }

        /// <summary>
        ///   获取connectionStrings节点下指定名称对应的数据库连接字符串
        /// </summary>
        /// <param name="name">connectionStrings节点下指定名称</param>
        public string GetConnectionString(string name)
        {
            var setting = GetConnectionStringSettings(name);
            return setting != null ? setting.ConnectionString : null;
        }

        /// <summary>
        ///   获取connectionStrings节点下指定名称对应的数据库提供程序名称
        /// </summary>
        /// <param name="name">connectionStrings节点下指定名称</param>
        public string GetProviderName(string name)
        {
            var setting = GetConnectionStringSettings(name);
            return setting != null ? setting.ProviderName : null;
        }

        /// <summary>
        ///     更新或新增[connectionStrings]节点的子节点值，存在则更新子节点,不存在则新增子节点，返回成功与否布尔值
        /// </summary>
        /// <param name="configurationFile">要操作的配置文件名称,枚举常量</param>
        /// <param name="name">子节点name值</param>
        /// <param name="connectionString">子节点connectionString值</param>
        /// <param name="providerName">子节点providerName值</param>
        /// <returns>返回成功与否布尔值</returns>
        public static bool UpdateOrCreateConnectionString(string configurationFile, string name, string connectionString, string providerName)
        {
            bool isSuccess = false;
            string fileName = AppDomain.CurrentDomain.BaseDirectory + configurationFile;

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName); //加载配置文件

            XmlNode node = doc.SelectSingleNode("//connectionStrings"); //得到[connectionStrings]节点
            try
            {
                ////得到[connectionStrings]节点中关于Name的子节点
                XmlElement element = (XmlElement)node.SelectSingleNode("//add[@name='" + name + "']");

                if (element != null)
                {
                    //存在则更新子节点
                    element.SetAttribute("connectionString", connectionString);
                    element.SetAttribute("providerName", providerName);
                }
                else
                {
                    //不存在则新增子节点
                    XmlElement subElement = doc.CreateElement("add");
                    subElement.SetAttribute("name", name);
                    subElement.SetAttribute("connectionString", connectionString);
                    subElement.SetAttribute("providerName", providerName);
                    node.AppendChild(subElement);
                }

                //保存至配置文件
                doc.Save(fileName);
                ConfigurationManager.RefreshSection("ConnectionStrings"); // 强制重新载入配置文件的ConnectionStrings配置节点

                isSuccess = true;
            }
            catch (System.Exception ex)
            {
                isSuccess = false;

                throw ex;
            }

            return isSuccess;
        }


        /// <summary>
        ///  从数据库连接字符串中提取数据库的名称。
        /// <para>推荐使用数据库产品的 ConnectionStringBuilder 类获取数据库的详细配置信息</para>
        /// </summary>
        /// <param name="connectionString">数据库连接字符串</param>
        /// <returns></returns>
        public static string GetDatabaseName(string connectionString)
        {
            // 使用数据库产品的 ConnectionStringBuilder 类获取数据库的详细配置信息

            string[] arrWords = { "Database", "Initial Catalog" };
            foreach (string word in arrWords)
            {
                #region 方法一

                if (connectionString.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Match databaseNameMatch = Regex.Match(connectionString,
                                                          word + "=([^;]+)",
                                                          RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace | RegexOptions.CultureInvariant
                                                         );
                    if (databaseNameMatch.Success)
                    {
                        GroupCollection groups = databaseNameMatch.Groups;
                        if (groups.Count > 1)
                        {
                            return groups[1].Value;
                        }
                    }
                }

                #endregion

                #region 方法二

                //Regex databaseNameRegex = new Regex(@"Database\W*=\W*(?<database>[^;]*)", RegexOptions.IgnoreCase);
                //Match databaseNameMatch = databaseNameRegex.Match(connectionString);

                //if (databaseNameMatch.Success)
                //{
                //    // 返回结果，例如 Database=information_schema
                //    return databaseNameMatch.Groups["database"].ToString();
                //}

                #endregion

            }
            return string.Empty;
        }
    }
}