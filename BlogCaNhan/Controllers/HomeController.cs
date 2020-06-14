using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogCaNhan.Data.EF;

namespace BlogCaNhan.Controllers
{
    public class HomeController : Controller
    {
        BlogCaNhanDB db = new BlogCaNhanDB();
        public ActionResult Index()
        {
            var listDMBV = db.DanhMucBaiViets.ToList();
            ViewBag.lstmenu = listDMBV;
            return View();
        }
        public ActionResult MenuPrograming()
        {
            return PartialView();
        }
        public ActionResult SendContact()
        {
            return PartialView();
        }
        
    }
}