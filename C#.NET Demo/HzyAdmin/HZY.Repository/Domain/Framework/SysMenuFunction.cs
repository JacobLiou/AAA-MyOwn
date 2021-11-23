﻿using HZY.Repository.AppCore.Models;
using System;

namespace HZY.Repository.Domain.Framework
{
    /// <summary>
    /// 菜单与功能绑定
    /// </summary>
    public class SysMenuFunction : GuidKeyBaseModel
    {
        public Guid MenuId { get; set; }
        public Guid FunctionId { get; set; }
    }
}