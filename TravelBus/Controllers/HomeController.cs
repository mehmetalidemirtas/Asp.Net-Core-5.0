using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace TravelBus.Controllers
{
    public class HomeController : Controller
    {
        PlaceManager placeManager = new PlaceManager(new PlaceRepositoryEF());
        SubscribeManager subscribeManager = new SubscribeManager(new SubscribeRepositoryEF());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult Subscribe(Subscribe sm)
        {
            SubscribeValidator subscribeValidator = new SubscribeValidator();
            ValidationResult result = subscribeValidator.Validate(sm);
            if (result.IsValid)
            {
                subscribeManager.TAdd(sm);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
