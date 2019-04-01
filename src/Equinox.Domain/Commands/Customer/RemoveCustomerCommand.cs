using System;
using Equinox.Domain.Validations.Customer;

namespace Equinox.Domain.Commands.Customer
{
    public class RemoveCustomerCommand : CustomerCommand
    {
        public RemoveCustomerCommand(string id)
        {
            Id = id;
            AggregateId = id;
        }

        public override bool IsValid()
        {
            ValidationResult = new RemoveCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}