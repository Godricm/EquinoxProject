using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Domain.Commands.SysModule;

namespace Equinox.Domain.Validations.SysModule
{
    public class UpdateSysModuleCommandValidation : SysModuleValidation<UpdateSysModuleCommand>
    {
        public UpdateSysModuleCommandValidation()
        {
            ValidateId();
            ValidateModuleName();
        }
    }
}
