using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Equinox.Application.ViewModels
{
    public class SysModuleViewModel
    {
        [Key]
        public string Id { get; protected set; }

        /// <summary>
        /// 上级Id
        /// </summary>  
        public string ParentId { get; protected set; }

        /// <summary>
        /// 菜单分类 System/Application
        /// </summary> 
        [Required(ErrorMessage = "The CategoryCode is Required")] 
        [DisplayName("CategoryCode")]
        public string CategoryCode { get; protected set; }

        /// <summary>
        /// 模块名称
        /// </summary> 
        [Required(ErrorMessage = "The ModuleName is Required")]
        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("ModuleName")]
        public string ModuleName { get; protected set; }

        /// <summary>
        /// 是否是菜单
        /// </summary> 
        [DisplayName("IsMenu")] 
        public bool IsMenu { get; protected set; }

        /// <summary>
        /// 是否有效
        /// </summary> 
        [DisplayName("IsEnabled")]
        public bool IsEnabled { get; protected set; }

        /// <summary>
        /// Url地址
        /// </summary> 
        [DisplayName("Url")]
        [MinLength(2)]
        [MaxLength(50)]
        public string Url { get; protected set; }

        /// <summary>
        /// 字体样式
        /// </summary>  
        [DisplayName("IconFront")]
        public string IconFront { get; protected set; }


        /// <summary>
		/// 是否删除
		/// </summary> 
        [DisplayName("DeletionStateCode")]
        public bool DeletionStateCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary> 
        [DisplayName("Remark")]
        public string Remark { get; protected set; }

        /// <summary>
        /// 创建日期
        /// </summary>   
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("CreateOn")]
        public DateTime? CreateOn { get; protected set; }

        /// <summary>
        /// 创建人Id
        /// </summary>  
        public string CreateUserId { get; protected set; }

        /// <summary>
        /// 创建人名称
        /// </summary> 
        [DisplayName("CreateBy")]
        public string CreateBy { get; protected set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("ModifiedOn")]
        public DateTime? ModifiedOn { get; protected set; }

        /// <summary>
        /// 更新人Id
        /// </summary> 
        public string ModifiedUserId { get; protected set; }

        /// <summary>
        /// 更新人名称
        /// </summary> 
        [DisplayName("ModifiedBy")]
        public string ModifiedBy { get; protected set; }
    }
}
