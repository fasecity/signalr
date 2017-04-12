using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SignalrPractice.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SignalrPractice.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            




            ////  // Instantiate the ASP.NET Identity system
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var currentUser = manager.FindById(User.Identity.GetUserId());


            //string cname = currentUser;

            // Recover the profile information about the logged in user
            ViewBag.displayName = currentUser.displayName;
            ViewBag.age = currentUser.age;
            ViewBag.description = currentUser.description;
            ViewBag.description = currentUser.UserName;






            return View();
        }

        public ActionResult Contact()
        {
     


            return View();
        }
    }
}