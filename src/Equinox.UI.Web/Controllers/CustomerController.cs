using System;
using Equinox.Application.Interfaces;
using Equinox.Application.ViewModels;
using Equinox.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Equinox.UI.Web.Controllers
{
    [Authorize]
    public class CustomerController : BaseController
    {
        private readonly ICustomerAppService _customerAppService;

        public CustomerController(ICustomerAppService customerAppService, 
                                  INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            _customerAppService = customerAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("customer-management/list-all")]
        public IActionResult Index()
        {
            return View(_customerAppService.GetAll());
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("customer-management/customer-details/{id:string}")]
        public IActionResult Details(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            var customerViewModel = _customerAppService.GetById(id);

            if (customerViewModel == null)
            {
                return NotFound();
            }

            return View(customerViewModel);
        }

        [HttpGet]
        [Authorize(Policy = "CanWriteCustomerData")]
        [Route("customer-management/register-new")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "CanWriteCustomerData")]
        [Route("customer-management/register-new")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CustomerViewModel customerViewModel)
        {
            if (!ModelState.IsValid) return View(customerViewModel);
            _customerAppService.Register(customerViewModel);

            if (IsValidOperation())
                ViewBag.Sucesso = "Customer Registered!";

            return View(customerViewModel);
        }
        
        [HttpGet]
        [Authorize(Policy = "CanWriteCustomerData")]
        [Route("customer-management/edit-customer/{id:string}")]
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            var customerViewModel = _customerAppService.GetById(id);

            if (customerViewModel == null)
            {
                return NotFound();
            }

            return View(customerViewModel);
        }

        [HttpPost]
        [Authorize(Policy = "CanWriteCustomerData")]
        [Route("customer-management/edit-customer/{id:string}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CustomerViewModel customerViewModel)
        {
            if (!ModelState.IsValid) return View(customerViewModel);

            _customerAppService.Update(customerViewModel);

            if (IsValidOperation())
                ViewBag.Sucesso = "Customer Updated!";

            return View(customerViewModel);
        }

        [HttpGet]
        [Authorize(Policy = "CanRemoveCustomerData")]
        [Route("customer-management/remove-customer/{id:string}")]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return NotFound();
            }

            var customerViewModel = _customerAppService.GetById(id);

            if (customerViewModel == null)
            {
                return NotFound();
            }

            return View(customerViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Policy = "CanRemoveCustomerData")]
        [Route("customer-management/remove-customer/{id:string}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            _customerAppService.Remove(id);

            if (!IsValidOperation()) return View(_customerAppService.GetById(id));

            ViewBag.Sucesso = "Customer Removed!";
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        [Route("customer-management/customer-history/{id:string}")]
        public JsonResult History(string id)
        {
            var customerHistoryData = _customerAppService.GetAllHistory(id);
            return Json(customerHistoryData);
        }
    }
}
