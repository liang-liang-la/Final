using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Eaxm()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Music()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Music(String name,String num)
        {
            if (name.IsNullOrWhiteSpace()) {
                ViewBag.NameMessage = "請輸入姓名";
            }
            if (num.IsNullOrWhiteSpace())
            {
                ViewBag.NameMessage = "請輸入數字";
            }

            if (num == "1")
            {
                ViewBag.Result = "do";
            }
            else if (num == "2") {
                ViewBag.Result = "re";
            }
            else if (num == "3")
            {
                ViewBag.Result = "mi";
            }
            else if (num == "4")
            {
                ViewBag.Result = "fa";
            }
            else if (num == "5")
            {
                ViewBag.Result = "so";
            }
            else if (num == "6")
            {
                ViewBag.Result = "la";
            }
            else if (num == "7")
            {
                ViewBag.Result = "xi";
            }
            else
            {
                ViewBag.Result = "錯誤";
            }

            ViewBag.Name = name;
            return View();
        }

    }
}