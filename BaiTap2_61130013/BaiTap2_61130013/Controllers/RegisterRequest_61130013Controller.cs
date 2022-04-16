using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2_61130013.Controllers
{
    public class RegisterRequest_61130013Controller : Controller
    {
        // GET: RegisterRequest_61130013
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterRequest()
        {
            ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["Name"];
            ViewBag.Marks = Request["Marks"];
            return View();
        }
    }
}