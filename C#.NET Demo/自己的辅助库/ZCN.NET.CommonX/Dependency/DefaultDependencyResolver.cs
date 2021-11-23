using System;

namespace ZCN.NET.CommonX.Dependency
{
    /// <summary>
    ///  对象依赖解析器的默认实现类
    /// </summary>
    public class DefaultDependencyResolver : ICustomDependencyResolver
    {
        /// <summary>
        ///  创建对象实例
        /// </summary>
        /// <param name="objectType">任意类型对象</param>
        /// <returns></returns>
        public object CreateInstance(Type objectType)
        {
            return Activator.CreateInstance(objectType);
        }
    }
}