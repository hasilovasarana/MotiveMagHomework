using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class EntertainmentController : Controller
    {
        MagNewsEntities db = new MagNewsEntities();
        // GET: Entertainment
        public ActionResult Index()
        {
            var catEntertainment = from catEnter in db.News.ToList()
                                   where catEnter.news_category == 3
                                   select catEnter;
            ViewBag.catEnterName = (from catName in db.Categories.ToList()
                                where catName.id == 3
                                select catName.category_name).SingleOrDefault();
            ViewBag.catEntertain = catEntertainment.Take(5).ToList();




            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.goToDetail = db.News.ToList();
            return View();
        }
    }
}