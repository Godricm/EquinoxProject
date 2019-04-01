using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Equinox.Domain.Commands.SysModule;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Core.Notifications;
using Equinox.Domain.Events.SysModule;
using Equinox.Domain.Interfaces;
using Equinox.Domain.Models;
using MediatR;

namespace Equinox.Domain.CommandHandlers
{
    public class SysModuleCommandHandler :
        CommandHandler,
        IRequestHandler<CreateNewSysModuleCommand, bool>,
        IRequestHandler<UpdateSysModuleCommand, bool>,
        IRequestHandler<RemoveSysModuleCommand, bool>
    {

        private readonly ISysModuleRepository _sysModuleRepository;
        private readonly IMediatorHandler Bus;
        public SysModuleCommandHandler(ISysModuleRepository sysModuleRepository,
                               IUnitOfWork uow,
                               IMediatorHandler bus,
                               INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _sysModuleRepository = sysModuleRepository;
            Bus = bus;
        }

        public Task<bool> Handle(CreateNewSysModuleCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(false);
            }
            var sysModule = new SysModule(Guid.NewGuid().ToString("N"), request.ParentId, request.CategoryCode, request.ModuleName, request.IsMenu, request.IsEnabled, request.DeletionStateCode, request.Remark);
            //获取同名的ModuleName
            if (_sysModuleRepository.GetByModuleName(sysModule.ModuleName) != null)
            {
                Bus.RaiseEvent(new DomainNotification(request.MessageType, "The Module Name has already been taken"));
                return Task.FromResult(false);
            }

            _sysModuleRepository.Add(sysModule);
            if (Commit())
            {
                Bus.RaiseEvent(new SysModuleCreatedEvent(sysModule.Id, sysModule.ParentId, sysModule.CategoryCode, sysModule.ModuleName, sysModule.IsMenu, sysModule.IsEnabled, sysModule.Url, sysModule.IconFront, sysModule.DeletionStateCode, sysModule.Remark, sysModule.CreateOn, sysModule.CreateUserId, sysModule.CreateBy));
            }
            return Task.FromResult(true);
        }

        public Task<bool> Handle(UpdateSysModuleCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(false);
            }
            var sysModule = new SysModule(request.Id, request.ParentId, request.CategoryCode, request.ModuleName, request.IsMenu, request.IsEnabled, request.DeletionStateCode, request.Remark);
            var existingSysModule = _sysModuleRepository.GetByModuleName(sysModule.ModuleName);
            if (existingSysModule != null && existingSysModule.Id != sysModule.Id)
            {
                if (!existingSysModule.Equals(sysModule))
                {
                    Bus.RaiseEvent(new DomainNotification(request.MessageType, "The Module Name has already been taken."));
                    return Task.FromResult(false);
                }
            }
             
            _sysModuleRepository.Update(sysModule);
            if (Commit())
            {
                //更新事件
                Bus.RaiseEvent(new SysModuleUpdatedEvent(sysModule.Id, sysModule.ParentId, sysModule.CategoryCode, sysModule.ModuleName, sysModule.IsMenu, sysModule.IsEnabled, sysModule.Url, sysModule.IconFront, sysModule.DeletionStateCode, sysModule.Remark, sysModule.ModifiedOn, sysModule.ModifiedUserId, sysModule.ModifiedBy));
            }
            return Task.FromResult(true);
        }

        public Task<bool> Handle(RemoveSysModuleCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return Task.FromResult(false);
            }
            _sysModuleRepository.Remove(request.Id);

            if (Commit())
            {
                Bus.RaiseEvent(new SysModuleRemovedEvent(request.Id));
            }

            return Task.FromResult(true);
        }
    }
}
