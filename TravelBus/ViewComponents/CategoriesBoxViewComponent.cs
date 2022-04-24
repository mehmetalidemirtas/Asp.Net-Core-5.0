using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBus.ViewComponents
{
    public class CategoriesBoxViewComponent : ViewComponent
    {
        CountryManager countryManager = new CountryManager(new CountryRepositoryEF());
        public IViewComponentResult Invoke()
        {
            var values = countryManager.GetList().Take(3);
            return View(values);
        }
    }
}
