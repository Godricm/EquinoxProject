using System;
using System.Collections.Generic;
using Equinox.Application.EventSourcedNormalizers;
using Equinox.Application.ViewModels;

namespace Equinox.Application.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        void Register(CustomerViewModel customerViewModel);
        IEnumerable<CustomerViewModel> GetAll();
        CustomerViewModel GetById(string id);
        void Update(CustomerViewModel customerViewModel);
        void Remove(string id);
        IList<CustomerHistoryData> GetAllHistory(string id);
    }
}
