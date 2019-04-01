using Equinox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Equinox.Domain.Interfaces
{
	public interface ISysModuleRepository : IRepository<SysModule>
	{
        /// <summary>
        /// 获取指定模块
        /// </summary>
        /// <param name="moduleName">模块名称</param>
        /// <returns></returns>
        SysModule GetByModuleName(string moduleName);
	}
}
