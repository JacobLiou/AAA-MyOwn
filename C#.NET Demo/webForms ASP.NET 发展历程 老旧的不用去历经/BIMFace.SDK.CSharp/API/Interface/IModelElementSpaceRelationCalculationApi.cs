// /* ---------------------------------------------------------------------------------------
//    文件名：IModelElementSpaceRelationCalculationApi.cs
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

using BIMFace.SDK.CSharp.Constants;
using BIMFace.SDK.CSharp.Entity.Response;

namespace BIMFace.SDK.CSharp.API
{   /// <summary>
    ///  构件空间关系计算API接口
    /// </summary>
    public interface IModelElementSpaceRelationCalculationApi
    {
        /// <summary>
        /// 获取楼层对应房间列表。
        /// 当前支持两种方式查询房间列表：1）使用楼层ID查询属于给定楼层的房间列表 2）使用构件ID在空间中计算查询包含该构件的房间列表，这两种方式只能取其一，楼层ID优先。
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="fileId">【必填】文件ID</param>
        /// <param name="elementId">构件ID</param>
        /// <param name="floorId">楼层ID</param>
        /// <param name="roomToleranceXY">XY方向的误差容许程度</param>
        /// <param name="roomToleranceZ">Z方向的误差容许程度</param>
        /// <returns></returns>
        QueryFloorRoomsResponse QueryFloorRoomsByFileId(string accessToken, long fileId, string elementId = null, string floorId = null,
                                                        RoomTolerance roomToleranceXY = RoomTolerance.ORDINARY, RoomTolerance roomToleranceZ = RoomTolerance.STRICT);


        /// <summary>
        /// 根据楼层ID或构件ID获取对应房间列表。
        /// 当前支持两种方式查询房间列表：1）使用楼层ID查询属于给定楼层的房间列表 2）使用构件ID在空间中计算查询包含该构件的房间列表，这两种方式只能取其一，楼层ID优先。
        /// </summary>
        /// <param name="accessToken">【必填】令牌</param>
        /// <param name="integrateId">【必填】模型集成ID</param>
        /// <param name="elementId">构件ID</param>
        /// <param name="fileIdHash"></param>
        /// <param name="floorId">楼层ID</param>
        /// <param name="roomToleranceXY">XY方向的误差容许程度</param>
        /// <param name="roomToleranceZ">Z方向的误差容许程度</param>
        /// <returns></returns>
        QueryFloorRoomsResponse QueryFloorRoomsByIntegrateId(string accessToken, long integrateId, string elementId = null, string fileIdHash = null, string floorId = null,
                                                             RoomTolerance roomToleranceXY = RoomTolerance.ORDINARY, RoomTolerance roomToleranceZ = RoomTolerance.STRICT);
    }
}