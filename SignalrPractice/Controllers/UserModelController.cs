using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SignalrPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SignalrPractice.Controllers
{
    public class UserModelController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: UserModel
        public ActionResult Index()
        {
            //try
            //{
            //    //ApplicationDbContext db = new ApplicationDbContext();
            //    var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            //    var currentUser = manager.FindById(User.Identity.GetUserId());
                
            //    //intantiate database
               

            //    //instantiate Music class object
            //    UserModel Adder = new UserModel();

            //    //add current user info to user class
            //    Adder.displayName = currentUser.displayName;
            //    Adder.description = currentUser.description;
            //    Adder.age = currentUser.age;
            //    Adder.userName = currentUser.UserName;
            //    Adder.dateTime = DateTime.Now;
            //    //add model and save changes
            //    db.userModels.Add(Adder);
            //    db.SaveChanges();

              
            //    //return  RedirectToAction("Index", "Home");
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //get current user info
            //make datbase list
            var dblist = db.userModels.ToList();
            var sortuser = from m in dblist select m;
            return View(sortuser.ToList());
           // return View();
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
          var app = db.userModels.Find(id);
            if (app == null)
            {
                return HttpNotFound();
            }
            return View(app);
        }
    }
}