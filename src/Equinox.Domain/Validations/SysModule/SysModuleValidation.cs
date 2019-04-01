using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Domain.Commands.SysModule;
using FluentValidation;

namespace Equinox.Domain.Validations.SysModule
{
    /// <summary>
    /// 系统模块验证
    /// </summary>
    public abstract class SysModuleValidation<T> : AbstractValidator<T> where T : SysModuleCommand
    {

        protected void ValidateModuleName()
        {
            RuleFor(c => c.ModuleName).NotEmpty()
                .WithMessage("Please ensure you have entered the Name")
                .Length(2, 50).WithMessage("The ModuleName must have between 2 and 150 characters");
        }

        protected void ValidateId()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage("Please ensure you have the Id");
        }
    }
}
