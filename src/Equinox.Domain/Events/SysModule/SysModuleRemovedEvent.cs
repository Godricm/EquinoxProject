using System;
using System.Collections.Generic;
using System.Text;
using Equinox.Domain.Core.Events;

namespace Equinox.Domain.Events.SysModule
{
    public class SysModuleRemovedEvent:Event
    {
        public SysModuleRemovedEvent(string id)
        {
            Id = id;
            AggregateId = id;
        }

        public string Id { get; set; }
    }
}
