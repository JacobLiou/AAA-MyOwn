// /* ---------------------------------------------------------------------------------------
//    文件名：ViewType.cs
//    文件功能描述：
// 
//    创建标识：20200316
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
    /// 视图类型
    /// </summary>
    public enum ViewType
    {
        /// <summary>
        /// 当不给出viewType值时，则返回所有集合
        /// </summary>
        None,

        /// <summary>
        ///  楼层俯视二维视图
        /// </summary>
        FloorPlan,

        /// <summary>
        /// 三维视图
        /// </summary>
        ThreeD,

        /// <summary>
        /// 天花板仰视二维视图
        /// </summary>
        CeilingPlan,

        /// <summary>
        /// 轴侧二维视图
        /// </summary>
        Elevation,

        EngineeringPlan,

        Rendering,

        DrawingSheet
    }
}