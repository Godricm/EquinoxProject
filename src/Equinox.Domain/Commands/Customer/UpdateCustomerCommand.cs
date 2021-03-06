﻿using System;
using Equinox.Domain.Validations.Customer;

namespace Equinox.Domain.Commands.Customer
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(string id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}