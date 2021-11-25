// /* ---------------------------------------------------------------------------------------
//    文件名：GeneralResponse.cs
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
    ///  请求 BIMFACE 服务端 API的响应结果统一的返回类
    /// </summary>
    [Serializable]
    public class GeneralResponse<T> //where T : class, new()
    {
        #region 属性

        /// <summary>
        ///  请求返回代码，success 或者 xxxx.failed。
        /// </summary>
        [JsonProperty("code")]
        public virtual string Code { get; set; }

        /// <summary>
        ///  失败的错误原因。
        ///  如果 Code 为 success 则 Message 为空。
        ///  如果 Code 为 xxxx.failed 则 Message 为具体的失败信息。
        /// </summary>
        [JsonProperty("message")]
        public virtual string Message { get; set; }

        /// <summary>
        ///  执行成功后的返回结果
        /// </summary>
        [JsonProperty("data")]
        public virtual T Data { get; set; }

        #endregion

        #region 构造函数
        public GeneralResponse()
        {
        }

        public GeneralResponse(T data)
        {
            this.Data = data;
        }

        #endregion

        #region 方法
        public override string ToString()
        {
            if (Data != null)
            {
                return string.Format("GeneralResponse [code={0}, message={1}, data={2}]", Code, Message, Data);
            }
            else
            {
                return string.Format("GeneralResponse [code={0}, message={1}, data={2}]", Code, Message, "");
            }
        }

        #endregion
    }
}