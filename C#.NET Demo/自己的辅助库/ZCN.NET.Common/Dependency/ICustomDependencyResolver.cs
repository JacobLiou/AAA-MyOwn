using System;

namespace ZCN.NET.Common.Dependency
{
    /// <summary>
    ///  对象依赖解析器接口
    /// </summary>
    public interface ICustomDependencyResolver
    {
        /// <summary>
        ///  创建对象实例
        /// </summary>
        /// <param name="objectType">任意类型对象</param>
        /// <returns></returns>
        object CreateInstance(Type objectType);
    }
}