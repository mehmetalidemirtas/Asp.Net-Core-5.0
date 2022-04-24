using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBus.ViewComponents
{
    public class MeetTheTeamViewComponent : ViewComponent
    {
        PlaceManager placeManager = new PlaceManager(new PlaceRepositoryEF());
        public IViewComponentResult Invoke()
        {
            var values = placeManager.GetPlaceWithCountry().OrderByDescending(z => z.PlaceID).Take(3);
            return View(values);
        }
    }
}
