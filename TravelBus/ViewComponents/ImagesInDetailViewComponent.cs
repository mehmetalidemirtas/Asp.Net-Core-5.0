using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBus.ViewComponents
{
    public class ImagesInDetailViewComponent :ViewComponent
    {
        ImageManager imageManager = new ImageManager(new ImageRepositoryEF());
        public IViewComponentResult Invoke(int id)
        {
            var values = imageManager.GetList(id);    
            return View(values);
        }
    }
}
