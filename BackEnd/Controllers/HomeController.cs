using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Models;

namespace BackEnd.Controllers
{
    public class HomeController : Controller
    {
        MagNewsEntities db = new MagNewsEntities();

        public ActionResult Index()
        {
      
                // home page data           
 
          


            // slider data
            ViewBag.slider = db.News.ToList();


            //Technology news
            var catTech = from cat in db.News.ToList()
                                where cat.news_category== 5
                                select cat;
            ViewBag.catTechName = (from catName in db.Categories.ToList()
                                   where catName.id == 5
                                   select catName.category_name).SingleOrDefault();
            ViewBag.catTech = catTech.Take(4).ToList();



            // latest articles






        

            return View();
        }



        public ActionResult Details(int? id)
        {               
            ViewBag.MyNews = db.News.Find(id);           
            db.SaveChanges();
            return View();
        }
        
        
    }
}