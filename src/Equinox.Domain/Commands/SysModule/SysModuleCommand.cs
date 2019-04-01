using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Domain.Core.Commands;

namespace Equinox.Domain.Commands.SysModule
{
    public abstract class SysModuleCommand : Command
    { 

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

        /// <summary>
        /// 更新时间
        /// </summary> 
        public DateTime? ModifiedOn { get; protected set; }

        /// <summary>
        /// 更新人Id
        /// </summary> 
        public string ModifiedUserId { get; protected set; }

        /// <summary>
        /// 更新人名称
        /// </summary> 
        public string ModifiedBy { get; protected set; }
    }
}
