using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Commands.SysModule;
using Equinox.Domain.Core.Bus;
using Equinox.Domain.Interfaces;
using Equinox.Infra.EventBus.Repository;

namespace Equinox.Application.Services
{
    public class SysModuleAppService : ISysModuleAppService
    {
        private readonly IMapper _mapper;
        private readonly ISysModuleRepository _sysModuleRepository;
        private readonly IEventStoreRepository _eventStoreRepository;
        private readonly IMediatorHandler Bus;

        public SysModuleAppService(IMapper mapper, ISysModuleRepository sysModuleRepository, IEventStoreRepository eventStoreRepository, IMediatorHandler bus)
        {
            _mapper = mapper;
            _sysModuleRepository = sysModuleRepository;
            _eventStoreRepository = eventStoreRepository;
            Bus = bus;
        }

        public void Dispose()
        {
            //_sysModuleRepository.Dispose();
            //_eventStoreRepository.Dispose(); 
            GC.SuppressFinalize(this);
        }

        public IEnumerable<SysModuleViewModel> GetAll()
        {
            return _sysModuleRepository.GetAll().ProjectTo<SysModuleViewModel>(_mapper.ConfigurationProvider);
        }
         

        public SysModuleViewModel GetById(string id)
        {
            return _mapper.Map<SysModuleViewModel>(_sysModuleRepository.GetById(id));
        }

        public void Instert(SysModuleViewModel sysModuleViewModel)
        {
            var createCommand = _mapper.Map<CreateNewSysModuleCommand>(sysModuleViewModel);
            Bus.SendCommand(createCommand);
        }

        public void Remove(string id)
        {
            var removeCommand = new RemoveSysModuleCommand(id);
            Bus.SendCommand(removeCommand);
        }

        public void Update(SysModuleViewModel sysModuleViewModel)
        {
            var updateCommand = _mapper.Map<UpdateSysModuleCommand>(sysModuleViewModel);
            Bus.SendCommand(updateCommand);
        }
    }
}
