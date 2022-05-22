using Facebook_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Facebook_Project.User;

namespace Facebook_Project.Controllers
{
    public class HomeController : Controller
    {
        private User1 user = new User1();

        [HttpGet]
        public ActionResult Index()
        {
            Session["Iduser"] = "0";
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            userinfo u = user.login(form["email"].ToString(), form["pass"].ToString());

            if (u == null)
            {
                return View();
            }

            Session["Iduser"] = u.Id.ToString();
            return RedirectToAction("Index", "Porfile");
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}