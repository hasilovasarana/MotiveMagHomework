using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Models;
namespace BackEnd.Controllers
{
    public class SportsController : Controller
    {
        MagNewsEntities db = new MagNewsEntities();
        // GET: Sports
        public ActionResult Index()
        {
            var catSport = from s in db.News.ToList()
                           where s.news_category == 2
                           select s;

            ViewBag.catSportName = (from sN in db.Categories.ToList()
                                    where sN.id == 2
                                    select sN.category_name).SingleOrDefault();

            ViewBag.catSport = catSport.Take(4).ToList();
            return View();
        }
    }
}