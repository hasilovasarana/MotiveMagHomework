using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Models;
namespace BackEnd.Controllers
{
    public class HealthController : Controller
    {
        MagNewsEntities db = new MagNewsEntities();
        // GET: Health
        public ActionResult Index()
        {
            var catHealth = from h in db.News.ToList()
                           where h.news_category == 7
                           select h;

            ViewBag.catHealthName = (from hN in db.Categories.ToList()
                                    where hN.id == 7
                                    select hN.category_name).SingleOrDefault();

            ViewBag.catHealth = catHealth.Take(4).ToList();
            return View();
        }
    }
}