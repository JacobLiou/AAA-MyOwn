namespace ZCN.NET.Common.Objects
{
    /// <summary>
    ///  序号基类
    /// </summary>
    public class SequenceObjectBase : ISequenceObject
    {
        #region ISequenceNumber

        /// <summary>
        ///   获取或设置一个值,该值表示序号
        /// </summary>
        public virtual int? Sequence { get; set; }

        #endregion
    }
}