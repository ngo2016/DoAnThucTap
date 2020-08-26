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
            return View();
        }
        
        public ActionResult PredictionXK()
        {            
            return View();
        }

        public ActionResult GetData()
        {
            int DT = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "DT                  ").Count();
            int DV_CNC = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "DV_CNC              ").Count();
            int DV_CNHT = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "DV_CNHT             ").Count();
            int DV_DS = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "DV_DS               ").Count();
            int DV_HC = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "DV_HC               ").Count();
            int DV_TM = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "DV_TM               ").Count();
            int PTHT = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "PTHT                ").Count();
            int RD = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "R&D                 ").Count();
            int SX_CNC = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "SX_CNC              ").Count();
            int SX_CNHT = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "SX_CNHT             ").Count();
            int UT = db.GIAY_CNDT.Where(x => x.MA_CTHTDT == "UT                  ").Count();

            HinhThucDauTu obj = new HinhThucDauTu();
            obj.DT = DT;
            obj.DV_CNC = DV_CNC;
            obj.DV_CNHT = DV_CNHT;
            obj.DV_DS = DV_DS;
            obj.DV_HC = DV_HC;
            obj.DV_TM = DV_TM;
            obj.PTHT = PTHT;
            obj.RD = RD;
            obj.SX_CNC = SX_CNC;
            obj.SX_CNHT = SX_CNHT;
            obj.UT = UT;

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        public ActionResult PileChartReport()
        {
            return View();
        }
    }
}