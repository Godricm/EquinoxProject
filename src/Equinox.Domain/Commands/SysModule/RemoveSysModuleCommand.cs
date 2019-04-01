using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Domain.Validations.SysModule;

namespace Equinox.Domain.Commands.SysModule
{
    public class RemoveSysModuleCommand : SysModuleCommand
    {
        public RemoveSysModuleCommand(string id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveSysModuleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
