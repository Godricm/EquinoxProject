using Equinox.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Equinox.Domain.Models
{
	[Table("sys_module")]
	public class SysModule : Entity<string>
	{
		public SysModule()
		{
		} 
		public SysModule(string id, bool deletionStateCode, string remark, DateTime createOn, string createUserId, string createBy, DateTime modifiedOn, string modifiedUserId, string modifiedBy) : base(id, deletionStateCode, remark, createOn, createUserId, createBy, modifiedOn, modifiedUserId, modifiedBy)
		{
		}
		 
		/// <summary>
		/// 上级Id
		/// </summary>
		[Column("parent_id")]
		public string ParentId { get; set; }

		/// <summary>
		/// 菜单分类 System/Application
		/// </summary>
		[Column("category_code")]
		public string CategoryCode { get; set; }

		/// <summary>
		/// 模块名称
		/// </summary>
		[Column("module_name")]
		public string ModuleName { get; set; }

		/// <summary>
		/// 是否是菜单
		/// </summary>
		[Column("is_menu")]
		public bool IsMenu { get; set; }

		/// <summary>
		/// 是否有效
		/// </summary>
		[Column("is_enabled")]
		public bool IsEnabled { get; set; }

		/// <summary>
		/// Url地址
		/// </summary>
		[Column("url")]
		public string Url { get; set; }

		/// <summary>
		/// 字体样式
		/// </summary>
		[Column("icon_front")]
		public string IconFront { get; set; }
	}
}
