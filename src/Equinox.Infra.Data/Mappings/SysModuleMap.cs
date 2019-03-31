using Equinox.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Equinox.Infra.Data.Mappings
{
	public class SysModuleMap : IEntityTypeConfiguration<SysModule>
	{
		public void Configure(EntityTypeBuilder<SysModule> builder)
		{ 
			builder.HasKey(c => c.Id);
			builder.Property(c => c.Id).HasMaxLength(50).IsRequired();
			builder.Property(c => c.ParentId).HasMaxLength(50);
			builder.Property(c => c.ModuleName).HasMaxLength(50);
			builder.Property(c => c.CategoryCode).HasMaxLength(10);
			builder.Property(c => c.Url).HasMaxLength(50);
			builder.Property(c => c.IsMenu).HasMaxLength(1).HasColumnType("bit(1)");
			builder.Property(c => c.IconFront).HasMaxLength(20);
			builder.Property(c => c.IsEnabled).HasMaxLength(1).HasColumnType("bit(1)");
			builder.Property(c => c.DeletionStateCode).HasMaxLength(1).HasColumnType("bit(1)");
			builder.Property(c => c.Remark).HasMaxLength(300);
			builder.Property(c => c.CreateOn);
			builder.Property(c => c.CreateUserId).HasMaxLength(50);
			builder.Property(c => c.CreateBy).HasMaxLength(20);
			builder.Property(c => c.ModifiedOn);
			builder.Property(c => c.ModifiedUserId).HasMaxLength(50);
			builder.Property(c => c.ModifiedBy).HasMaxLength(20);
		}
	}
}
