using DemoPar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoPar.Controllers
{
    public class HomeController : Controller
    {
        List<hehe> mang;
        public HomeController()
        {
             mang = new List<hehe>();
            for(int i = 1; i < 5; i++)
            {
                hehe h = new hehe();
                h.ID = i;
                h.Name = "thang " + i;
                mang.Add(h);
            }
        }
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult PhatCTL()
        {

            return PartialView("PhatPartial",mang);
        }
        public ActionResult PhatCTL1()
        {
            return PartialView("Phat1Partial",mang);
        }
        public ActionResult PhatCTL2()
        {
            return PartialView("Phat2Partial");
        }
    }
}