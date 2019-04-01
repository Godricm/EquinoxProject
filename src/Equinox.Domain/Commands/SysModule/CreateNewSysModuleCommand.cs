using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Domain.Validations.SysModule;

namespace Equinox.Domain.Commands.SysModule
{
    public class CreateNewSysModuleCommand : SysModuleCommand
    {
        public CreateNewSysModuleCommand(string id, string parentId, string categoryCode, string moduleName, bool isMenu, bool isEnabled, string url, string iconFront, bool deletionStateCode, string remark)
        {
            Id = id;
            ParentId = parentId;
            CategoryCode = categoryCode;
            ModuleName = moduleName;
            IsMenu = isMenu;
            IsEnabled = isEnabled;
            Url = url;
            IconFront = iconFront;
            DeletionStateCode = deletionStateCode;
            Remark = remark; 
        }

        public override bool IsValid()
        {
            ValidationResult = new CreateNewSysModuleCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
