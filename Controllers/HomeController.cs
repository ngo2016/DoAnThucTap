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
            List<SelectListItem> doanhNghiep = new List<SelectListItem>() {
                new SelectListItem {
                    Text = "DaeYoung", Value = "1"
                },
                new SelectListItem {
                    Text = "Daikou", Value = "2"
                },
                new SelectListItem {
                    Text = "Datalogic", Value = "3"
                },
                new SelectListItem {
                    Text = "DGS", Value = "4"
                },
                new SelectListItem {
                    Text = "Jabil", Value = "5"
                },
                new SelectListItem {
                    Text = "Nidec Sankyo ", Value = "6"
                },
                new SelectListItem {
                    Text = "Nidec Servo ", Value = "7"
                },
                new SelectListItem {
                    Text = "Platel Vina", Value = "8"
                },
                new SelectListItem {
                    Text = "Samsung", Value = "9"
                },
                new SelectListItem {
                    Text = "Sanofi", Value = "10"
                },
                new SelectListItem {
                    Text = "Sonion ", Value = "11"
                },
                new SelectListItem {
                    Text = "STID", Value = "12"
                },
                new SelectListItem {
                    Text = "T.C", Value = "13"
                },
                new SelectListItem {
                    Text = "The Gioi GEN", Value = "14"
                },
                new SelectListItem {
                    Text = "United Healthcare ", Value = "15"
                },
            };
            ViewBag.DoanhNghiep = doanhNghiep;

            return View();
        }
    }
}