using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2_61130013.Controllers
{
    public class RegisterFormCollection_61130013Controller : Controller
    {
        // GET: RegisterFormCollection_61130013
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterFormCollection(FormCollection field)
        {
            ViewBag.Id = field["Id"];
            ViewBag.Name = field["Name"];
            ViewBag.Marks = field["Marks"];
            return View();
        }
    }
}