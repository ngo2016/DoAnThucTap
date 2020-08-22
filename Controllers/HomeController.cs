using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAnThucTap.Models;
using DoAnThucTap.ViewModel;

namespace DoAnThucTap.Controllers
{
    public class HomeController : Controller
    {
        private readonly DUAN_KHUCNCEntities db = new DUAN_KHUCNCEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Report()
        {
            var tables = new RDViewModel
            {
                RDCost = db.TY_LE_CHI_RD.ToList(),
                RDEmployee = db.TY_LE_LAO_DONG_RD.ToList(),
            };
            return View(tables);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}