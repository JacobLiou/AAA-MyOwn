// /* ---------------------------------------------------------------------------------------
//    文件名：SingleModelViews.cs
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

using System;
using System.Collections.Generic;

namespace BIMFace.SDK.CSharp.Entity.Response
{
    /// <summary>
    ///  获取三维视点或二维视图列表的返回结果类
    /// </summary>
    [Serializable]
    public class SingleModelViews : GeneralResponse<List<ViewInfo>>
    {

    }
}