using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace TravelBus.Controllers
{
    public class CountryController : Controller
    {
        CountryManager countryManager = new CountryManager(new CountryRepositoryEF());
        public IActionResult Index(int page=1)
        {
            var values = countryManager.GetList().ToPagedList(page, 12);
            return View(values);
        }
    }
}
