using System;
using System.Reflection;
using Hangfire;
using Hangfire.MemoryStorage;

namespace UseHangfire
{
    /// <summary>
    /// 全局映射配置类
    /// </summary>
    public sealed class GlobalHangfireConfiguration
    {
        /// <summary>
        /// 单例
        /// </summary>
        private static readonly Lazy<GlobalHangfireConfiguration> s_LazyIntance = new Lazy<GlobalHangfireConfiguration>(() => new GlobalHangfireConfiguration());

        /// <summary>
        /// Instance
        /// </summary>
        public static GlobalHangfireConfiguration Instance
        {
            get
            {
                return s_LazyIntance.Value;
            }
        }


        /// <summary>
        /// 私有构造器
        /// </summary>
        private GlobalHangfireConfiguration()
        {
            GlobalConfiguration.Configuration.UseMemoryStorage();

        }

        public void DoJob()
        {

        }
    }
}
