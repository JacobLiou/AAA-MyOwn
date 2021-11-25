// /* ---------------------------------------------------------------------------------------
//    文件名：ModelElementSpaceRelationCalculationApi.cs
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

using System;

using BIMFace.SDK.CSharp.Common.Extensions;
using BIMFace.SDK.CSharp.Common.Http;
using BIMFace.SDK.CSharp.Constants;
using BIMFace.SDK.CSharp.Entity.Response;
using BIMFace.SDK.CSharp.Exceptions;
using BIMFace.SDK.CSharp.Http;

namespace BIMFace.SDK.CSharp.API
{
    /// <summary>
    ///  构件空间关系计算API实现类
    /// </summary>
    public class ModelElementSpaceRelationCalculationApi : IModelElementSpaceRelationCalculationApi
    {
        /* 在进行BIM应用的时候，经常需要计算某个房间与构件之间的空间关系，比如某个房间内包含的构件，或者某个构件属于哪个房间。而这些信息，在原始的模型文件里是不存在。
         * 幸运的是，BIMFACE利用强大的云计算能力，提供了实时计算空间关系的API, 助力BIM深度应用。
         */

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
        public virtual QueryFloorRoomsResponse QueryFloorRoomsByFileId(string accessToken, long fileId, string elementId = null, string floorId = null, RoomTolerance roomToleranceXY = RoomTolerance.ORDINARY, RoomTolerance roomToleranceZ = RoomTolerance.STRICT)
        {
            //GET https://api.bimface.com/data/v2/files/{fileId}/rooms

            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/files/{0}/rooms?p=1", fileId);
            if (elementId.IsNotNullAndWhiteSpace())
            {
                url += "&elementId=" + elementId;
            }
            if (floorId.IsNotNullAndWhiteSpace())
            {
                url += "&floorId=" + floorId;
            }

            url += "&roomToleranceXY=" + roomToleranceXY;
            url += "&roomToleranceZ=" + roomToleranceZ;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                QueryFloorRoomsResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<QueryFloorRoomsResponse>();
                }
                else
                {
                    response = new QueryFloorRoomsResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取楼层对应房间列表]发生异常！", ex);
            }
        }

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
        public virtual QueryFloorRoomsResponse QueryFloorRoomsByIntegrateId(string accessToken, long integrateId, string elementId = null, string fileIdHash = null, string floorId = null, RoomTolerance roomToleranceXY = RoomTolerance.ORDINARY, RoomTolerance roomToleranceZ = RoomTolerance.STRICT)
        {
            //GET https://api.bimface.com/data/v2/integrations/{integrateId}/rooms

            string url = string.Format(BIMFaceConstants.API_HOST + "/data/v2/integrations/{0}/rooms?p=1", integrateId);
            if (elementId.IsNotNullAndWhiteSpace())
            {
                url += "&elementId=" + elementId;
            }
            if (floorId.IsNotNullAndWhiteSpace())
            {
                url += "&floorId=" + floorId;
            }
            if (fileIdHash.IsNotNullAndWhiteSpace())
            {
                url += "&fileIdHash=" + fileIdHash;
            }

            url += "&roomToleranceXY=" + roomToleranceXY;
            url += "&roomToleranceZ=" + roomToleranceZ;

            BIMFaceHttpHeaders headers = new BIMFaceHttpHeaders();
            headers.AddOAuth2Header(accessToken);

            try
            {
                QueryFloorRoomsResponse response;

                HttpManager httpManager = new HttpManager(headers);
                HttpResult httpResult = httpManager.Get(url);
                if (httpResult.Status == HttpResult.STATUS_SUCCESS)
                {
                    response = httpResult.Text.DeserializeJsonToObject<QueryFloorRoomsResponse>();
                }
                else
                {
                    response = new QueryFloorRoomsResponse
                    {
                        Message = httpResult.RefText
                    };
                }

                return response;
            }
            catch (Exception ex)
            {
                throw new BIMFaceException("[获取楼层对应房间列表]发生异常！", ex);
            }
        }
    }
}