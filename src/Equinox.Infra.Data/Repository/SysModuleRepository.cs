using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using Equinox.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Equinox.Infra.Data.Repository
{
	public class SysModuleRepository : Repository<SysModule>, ISysModuleRepository
	{
		public SysModuleRepository(EquinoxContext context) : base(context)
		{
		}
	}
}
