using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using X.PagedList.Mvc.Core;

namespace TravelBus.ViewComponents
{
    public class BestPlacesViewComponent : ViewComponent
    {
        PlaceManager placeManager = new PlaceManager(new PlaceRepositoryEF());
        public IViewComponentResult Invoke()
        {
            var values = placeManager.GetPlaceWithCountry().OrderByDescending(z => z.PlaceID).Take(6);
            return View(values);
        }
    }
}
