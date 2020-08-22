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

        public ActionResult Prediction()
        {
            List<SelectListItem> mySkills = new List<SelectListItem>() {
        new SelectListItem {
            Text = "ASP.NET MVC", Value = "1"
        },
        new SelectListItem {
            Text = "ASP.NET WEB API", Value = "2"
        },
        new SelectListItem {
            Text = "ENTITY FRAMEWORK", Value = "3"
        },
        new SelectListItem {
            Text = "DOCUSIGN", Value = "4"
        },
        new SelectListItem {
            Text = "ORCHARD CMS", Value = "5"
        },
        new SelectListItem {
            Text = "JQUERY", Value = "6"
        },
        new SelectListItem {
            Text = "ZENDESK", Value = "7"
        },
        new SelectListItem {
            Text = "LINQ", Value = "8"
        },
        new SelectListItem {
            Text = "C#", Value = "9"
        },
        new SelectListItem {
            Text = "GOOGLE ANALYTICS", Value = "10"
        },
    };
            ViewBag.MySkills = mySkills;

            return View();
        }
    }
}