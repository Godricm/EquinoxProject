using System;
using Equinox.Domain.Core.Commands;

namespace Equinox.Domain.Commands.Customer
{
    public abstract class CustomerCommand : Command
    {
        public string Id { get; protected set; }

        public string Name { get; protected set; }

        public string Email { get; protected set; }

        public DateTime BirthDate { get; protected set; }
    }
}