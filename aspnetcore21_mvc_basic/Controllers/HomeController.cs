using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore21_mvc_basic.Models.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore21_mvc_basic.Controllers
{
    public class HomeController : Controller
    {

        private AppSettings appSetting;

        public HomeController(AppSettings appSetting)
        {
            this.appSetting = appSetting;
        }

        public IActionResult Index()
        {
            ViewBag.Kl = DateTime.Now.ToLongTimeString();
            ViewBag.Setting = appSetting.Setting2;

            return View();
        }
    }
}