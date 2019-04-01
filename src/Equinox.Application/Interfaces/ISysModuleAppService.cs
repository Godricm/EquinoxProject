using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Application.ViewModels;

namespace Equinox.Application.Interfaces
{
    public interface ISysModuleAppService : IDisposable
    {
        void Instert(SysModuleViewModel sysModuleViewModel);
        IEnumerable<SysModuleViewModel> GetAll();
        SysModuleViewModel GetById(string id);
        void Update(SysModuleViewModel sysModuleViewModel);
        void Remove(string id); 
    }
}
