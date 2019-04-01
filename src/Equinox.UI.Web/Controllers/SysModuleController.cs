using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Equinox.Application.Interfaces;
using Equinox.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Equinox.UI.Web.Controllers
{
    [Authorize]
    public class SysModuleController : BaseController
    {
        private ISysModuleAppService _sysModuleAppService;

        public SysModuleController(ISysModuleAppService sysModuleAppService, INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            _sysModuleAppService = sysModuleAppService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}