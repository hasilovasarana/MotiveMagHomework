using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackEnd.Models;
namespace BackEnd.Controllers
{
    public class BusinessController : Controller
    {
        MagNewsEntities db = new MagNewsEntities();
        // GET: Business
        public ActionResult Index()
        {
            var catBusiness= from h in db.News.ToList()
                            where h.news_category == 4
                            select h;

            ViewBag.catBusinessName = (from hN in db.Categories.ToList()
                                     where hN.id == 4
                                     select hN.category_name).SingleOrDefault();

            ViewBag.catBusiness = catBusiness.Take(4).ToList();
            return View();
        }
    }
}