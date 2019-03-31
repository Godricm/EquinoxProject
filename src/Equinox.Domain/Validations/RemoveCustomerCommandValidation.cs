using Equinox.Domain.Commands.Customer;

namespace Equinox.Domain.Validations
{
    public class RemoveCustomerCommandValidation : CustomerValidation<RemoveCustomerCommand>
    {
        public RemoveCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}