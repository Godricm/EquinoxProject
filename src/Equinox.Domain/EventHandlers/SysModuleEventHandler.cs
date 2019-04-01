using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Equinox.Domain.Events.SysModule;
using MediatR;

namespace Equinox.Domain.EventHandlers
{
    public class SysModuleEventHandler :
        INotificationHandler<SysModuleCreatedEvent>,
        INotificationHandler<SysModuleUpdatedEvent>,
        INotificationHandler<SysModuleRemovedEvent>
    {
        public Task Handle(SysModuleCreatedEvent notification, CancellationToken cancellationToken)
        {
            //Do SomeThing
            return Task.CompletedTask;
        }

        public Task Handle(SysModuleUpdatedEvent notification, CancellationToken cancellationToken)
        {
            //Do SomeThing
            return Task.CompletedTask;
        }

        public Task Handle(SysModuleRemovedEvent notification, CancellationToken cancellationToken)
        {
            //Do SomeThing
            return Task.CompletedTask;
        }
    }
}
