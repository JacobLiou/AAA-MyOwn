using Newtonsoft.Json;
using System;

namespace BIMFace.SDK.CSharp.Sample.Model
{
    public class AccessTokenItem
    {
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        [JsonProperty("expireTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime expireTime { get; set; }
    }
}