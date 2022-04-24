using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBus.ViewComponents
{
    public class ContentsByIdViewComponent : ViewComponent
    {
        ContentManager contentManager = new ContentManager(new ContentRepositoryEF());
        public IViewComponentResult Invoke(int id)
        {
            var values = contentManager.GetList(id);
            return View(values);
        }
    }
}
