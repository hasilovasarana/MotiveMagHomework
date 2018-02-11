using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Models;
namespace BackEnd.Controllers
{
    public class WeatherController : Controller
    {
        MagNewsEntities db = new MagNewsEntities();
        // GET: Weather
        public ActionResult Index()
        {
            var catWeather = from w in db.News.ToList()
                           where w.news_category == 6
                           select w;

            ViewBag.catWeatherName = (from sN in db.Categories.ToList()
                                    where sN.id == 6
                                    select sN.category_name).SingleOrDefault();

            ViewBag.catWeather = catWeather.Take(4).ToList();
            return View();
        }
    }
}