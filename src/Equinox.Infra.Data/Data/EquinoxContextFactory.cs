using Equinox.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Equinox.Infra.Data.Data
{
	public class EquinoxContextFactory : IDesignTimeDbContextFactory<EquinoxContext>
	{
		 

		public EquinoxContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<EquinoxContext>();
			optionsBuilder.UseMySQL("host=localhost;port=3306;database=equinox;uid=root;pwd=123456;Convert Zero Datetime=True;");
			return new EquinoxContext(optionsBuilder);
		}
	}
}
