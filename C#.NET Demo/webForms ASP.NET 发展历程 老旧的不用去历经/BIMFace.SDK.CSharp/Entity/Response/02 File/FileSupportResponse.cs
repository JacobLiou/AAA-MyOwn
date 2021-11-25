// /* ---------------------------------------------------------------------------------------
//    文件名：FileSupportResponse.cs
//    文件功能描述：
// 
//    创建标识：20200308
//    作   者：张传宁  （QQ：905442693  微信：savionzhang）
//    作者博客：https://www.cnblogs.com/SavionZhang/
//    BIMFace专栏地址：https://www.cnblogs.com/SavionZhang/p/11424431.html
// 
//    修改标识： 
//    修改描述：
//  ------------------------------------------------------------------------------------------*/

using System;

using Newtonsoft.Json;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  获取应用支持的文件类型返回的结果类
    /// </summary>
    public class FileSupportResponse : GeneralResponse<FileSupportEntity>
    {

    }

    [Serializable]
    public class FileSupportEntity
    {
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public long? Length { get; set; }

        /// <summary>
        /// 支持的文件类型
        /// </summary>
        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Types { get; set; }


        /// <summary>返回表示当前对象的字符串。</summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("FileSupportEntity [length={0}, types={1}]",
                                 Length, string.Join("、", Types));
        }
    }
}