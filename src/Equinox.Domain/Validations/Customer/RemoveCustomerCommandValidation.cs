using Equinox.Domain.Commands.Customer;

namespace Equinox.Domain.Validations.Customer
{
    public class RemoveCustomerCommandValidation : CustomerValidation<RemoveCustomerCommand>
    {
        public RemoveCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}