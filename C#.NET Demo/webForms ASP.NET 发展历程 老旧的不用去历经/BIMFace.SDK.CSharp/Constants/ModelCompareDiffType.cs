// /* ---------------------------------------------------------------------------------------
//    文件名：ModelCompareDiffType.cs
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

namespace BIMFace.SDK.CSharp.Constants
{
    /// <summary>
    ///  模型对比差异类型
    /// </summary>
    public enum ModelCompareDiffType
    {
        /// <summary>
        /// 新增
        /// </summary>
        NEW,

        /// <summary>
        /// 修改
        /// </summary>
        CHANGE,

        /// <summary>
        ///  删除
        /// </summary>
        DELETE,
    }
}