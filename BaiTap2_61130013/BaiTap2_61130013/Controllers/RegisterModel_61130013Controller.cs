using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2_61130013.Models;

namespace BaiTap2_61130013.Controllers
{
    public class RegisterModel_61130013Controller : Controller
    {
        // GET: RegisterModel_61130013
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterModel(Student st)
        {
            ViewBag.Id = st.mssv;
            ViewBag.Name = st.name;
            ViewBag.Marks = st.marks;
            return View();
        }
    }
}