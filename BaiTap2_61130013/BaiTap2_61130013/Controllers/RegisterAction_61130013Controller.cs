using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap2_61130013.Controllers
{
    public class RegisterAction_61130013Controller : Controller
    {
        // GET: RegisterAction        
        public ActionResult Index()
        {
            return View();
        }
        // Request       
        [HttpPost]
        public ActionResult RegisterAction(string Id, string Name, float Marks)
        {
            ViewBag.Id = Id;
            ViewBag.Name = Name;
            ViewBag.Marks = Marks;
            return View();
        }
    }
}