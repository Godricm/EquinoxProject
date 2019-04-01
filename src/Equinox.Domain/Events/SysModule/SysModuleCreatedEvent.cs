using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Domain.Core.Events;

namespace Equinox.Domain.Events.SysModule
{
    public class SysModuleCreatedEvent : Event
    {
        public SysModuleCreatedEvent(string id, string parentId, string categoryCode, string moduleName, bool isMenu, bool isEnabled, string url, string iconFront, bool deletionStateCode, string remark, DateTime? createOn, string createUserId, string createBy)
        {
            Id = id;
            ParentId = parentId;
            CategoryCode = categoryCode;
            ModuleName = moduleName;
            IsMenu = isMenu;
            IsEnabled = isEnabled;
            Url = url;
            IconFront = iconFront;
            DeletionStateCode = deletionStateCode;
            Remark = remark;
            CreateOn = createOn;
            CreateUserId = createUserId;
            CreateBy = createBy; 
            AggregateId = id;
        }

        public string Id { get; protected set; }

        /// <summary>
		/// 上级Id
		/// </summary> 
        public string ParentId { get; protected set; }

        /// <summary>
        /// 菜单分类 System/Application
        /// </summary> 
        public string CategoryCode { get; protected set; }

        /// <summary>
        /// 模块名称
        /// </summary> 
        public string ModuleName { get; protected set; }

        /// <summary>
        /// 是否是菜单
        /// </summary> 
        public bool IsMenu { get; protected set; }

        /// <summary>
        /// 是否有效
        /// </summary> 
        public bool IsEnabled { get; protected set; }

        /// <summary>
        /// Url地址
        /// </summary> 
        public string Url { get; protected set; }

        /// <summary>
        /// 字体样式
        /// </summary> 
        public string IconFront { get; protected set; }


        /// <summary>
		/// 是否删除
		/// </summary> 
        public bool DeletionStateCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary> 
        public string Remark { get; protected set; }

        /// <summary>
        /// 创建日期
        /// </summary> 
        public DateTime? CreateOn { get; protected set; }

        /// <summary>
        /// 创建人Id
        /// </summary> 
        public string CreateUserId { get; protected set; }

        /// <summary>
        /// 创建人名称
        /// </summary> 
        public string CreateBy { get; protected set; }
 
    }
}
