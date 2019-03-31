using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equinox.Domain.Core.Models
{
    public abstract class Entity<T>
    {
		protected Entity(T id, bool deletionStateCode, string remark, DateTime createOn, string createUserId, string createBy, DateTime modifiedOn, string modifiedUserId, string modifiedBy)
		{
			Id = id;
			DeletionStateCode = deletionStateCode;
			Remark = remark;
			CreateOn = createOn;
			CreateUserId = createUserId;
			CreateBy = createBy;
			ModifiedOn = modifiedOn;
			ModifiedUserId = modifiedUserId;
			ModifiedBy = modifiedBy;
		}

		protected Entity()
		{
		}

		[Column("id")]
		public T Id { get; protected set; }

		/// <summary>
		/// 是否删除
		/// </summary>
		[Column("deletion_state_code")]
		public bool DeletionStateCode { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		[Column("remark")]
		public string Remark { get; protected set; }

		/// <summary>
		/// 创建日期
		/// </summary>
		[Column("create_on")]
		public DateTime? CreateOn { get; protected set; }
		/// <summary>
		/// 创建人Id
		/// </summary>
		[Column("create_user_id")]
		public string CreateUserId { get; protected set; }
		/// <summary>
		/// 创建人名称
		/// </summary>
		[Column("create_by")]
		public string CreateBy { get; protected set; }
		/// <summary>
		/// 更新时间
		/// </summary>
		[Column("modified_on")]
		public DateTime? ModifiedOn { get; protected set; }
		/// <summary>
		/// 更新人Id
		/// </summary>
		[Column("modified_user_id")]
		public string ModifiedUserId { get; protected set; }
		/// <summary>
		/// 更新人名称
		/// </summary>
		[Column("modified_by")]
		public string ModifiedBy { get; protected set; }


		public override bool Equals(object obj)
        {
            var compareTo = obj as Entity<T>;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity<T> a, Entity<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity<T> a, Entity<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}