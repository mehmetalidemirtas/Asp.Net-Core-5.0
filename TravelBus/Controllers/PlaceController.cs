using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using X.PagedList;

namespace TravelBus.Controllers
{
    public class PlaceController : Controller
    {
        PlaceManager placeManager = new PlaceManager(new PlaceRepositoryEF());
        Place place;

        public IActionResult PlaceDetails(int id)
        {
            ViewBag.i = id;
            place = placeManager.GetByID(id);
            string city = place.CityName;
            var values = placeManager.GetPlaceByID(id);
            string api = "0b665c031af8b88018c6b10cfd28bc09";
            string link1 = "https://api.openweathermap.org/data/2.5/weather?q=";
            string link2 = "&mode=xml&units=metric&appid=";
            string connection= link1+city+link2+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.weather = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View(values);
        }

        public IActionResult ListAllPlaces(int id,int page=1)
        {
            var values = placeManager.GetPlaceByCountry(id).OrderByDescending(z => z.PlaceID).ToPagedList(page, 9);
            return View(values);
        }
    }
}
