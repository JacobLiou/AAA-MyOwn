using System;

namespace ZCN.NET.CommonX.Objects
{
    /// <summary>
    ///     名称对象基类
    /// </summary>
    /// <typeparam name="T">泛型类型参数，具体的名称对象(例如：数据库架构名称、类的实例名称、属性名称等等)</typeparam>
    [Serializable]
    public abstract class NamedObjectBase<T> : IEquatable<T>, INamedObject where T : NamedObjectBase<T>
    {
        #region IEquatable 接口成员

        /// <summary>
        ///     判断当前对象是否等于同一类型的另一个对象
        /// </summary>
        /// <param name="other">目标对比对象</param>
        public virtual bool Equals(T other)
        {
            if (other == null)
            {
                return false;
            }

            if (Name == null && other.Name == null)
            {
                return Equals(this, other);
            }

            return Name == other.Name;
        }

        #endregion

        #region 属性

        #region INamedObject 接口成员

        /// <summary>
        ///     获取或设置一个值,该值表示对象的名称
        /// </summary>
        public virtual string Name { get; set; }

        #endregion

        #region 扩展属性

        /// <summary>
        ///     定义一个标签，用于保存该类的其他自定义信息
        /// </summary>
        public object Tag { get; set; }

        #endregion

        #endregion

        #region 构造函数

        #endregion

        #region 方法

        /// <summary>
        ///     判断当前对象是否等于同一类型的另一个对象
        /// </summary>
        /// <param name="obj">目标对比对象</param>
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            var o = (NamedObjectBase<T>)obj;
            if (Name == null && o.Name == null)
            {
                return base.Equals(obj);
            }

            return Name == o.Name;
        }

        /// <summary>
        ///     获取当前类对象的名称的哈希值
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return base.GetHashCode();
            }

            return Name.GetHashCode();
        }

        /// <summary>
        ///     返回属性Name的值
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}