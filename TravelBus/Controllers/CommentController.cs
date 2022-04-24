using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBus.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new CommentRepositoryEF());
        
        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.PlaceID = 4;
            commentManager.TAdd(p);
            return RedirectToAction("Index","Home");
        }
    }
}
