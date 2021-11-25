// /* ---------------------------------------------------------------------------------------
//    文件名：SingleIntegrateModelElements.cs
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

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    /// 查询满足条件的构件ID列表（根据六个维度（专业，系统类型，楼层，构件类型，族，族类型）获取对应的构件ID列表，任何维度都是可选的。）的响应结果类
    /// </summary>
    public class SingleIntegrateModelElements : GeneralResponse<ElementsWithBoundingBox>
    {

    }
}