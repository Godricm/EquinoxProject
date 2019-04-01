﻿using System;
using Equinox.Domain.Core.Events;

namespace Equinox.Domain.Events.Customer
{
    public class CustomerRegisteredEvent : Event
    {
        public CustomerRegisteredEvent(string id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            AggregateId = id;
        }
        public string Id { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}