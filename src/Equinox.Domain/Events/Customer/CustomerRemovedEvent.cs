using System;
using Equinox.Domain.Core.Events;

namespace Equinox.Domain.Events.Customer
{
    public class CustomerRemovedEvent : Event
    {
        public CustomerRemovedEvent(string id)
        {
            Id = id;
            AggregateId = id;
        }

        public string Id { get; set; }
    }
}