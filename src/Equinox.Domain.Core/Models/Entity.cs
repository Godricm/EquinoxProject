using System;

namespace Equinox.Domain.Core.Models
{
    public abstract class Entity<T>
    {
        public T Id { get; protected set; }

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
		public DateTime CreateOn { get; protected set; }
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
		public DateTime ModifiedOn { get; protected set; }
		/// <summary>
		/// 更新人Id
		/// </summary>
		public string ModifiedUserId { get; protected set; }
		/// <summary>
		/// 更新人名称
		/// </summary>
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