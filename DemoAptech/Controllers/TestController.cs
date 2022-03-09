using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoAptech.Controllers;
using DemoAptech.Models;
namespace DemoAptech
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var user = new DemoAptech.Models.User();
            user.name = "John Smith";
            user.address = "Park Street";
            user.email = "john@mvcexample.com";
            ViewBag.user = user;

            return View();
        }
        //Sử dụng ViewBag thông thường.
        public ActionResult IndexUsers()
        {
            var user = new List<User>(); var user1 = new User();
            user1.name = "Mark Smith";
            user1.address = "Park Street";
            user1.email = "Mark@mvcexample.com";
            var user2 = new User();
            user2.name = "John Parker"; user2.address = "New Park"; user2.email = "John@mvcexample.com";
            var user3 = new User();
            user3.name = "Steave Edward "; user3.address = "Melbourne Street"; user3.email = "steave@mvcexample.com";
            user.Add(user1); user.Add(user2); user.Add(user3);
            ViewBag.user = user;
            return View();
        }
        //Suer dụng @model
        public ActionResult IndexUserModel()
        {
            var user = new DemoAptech.Models.User();
            user.name = "John Smith";
            user.address = "Park Street";
            user.email = "john@mvcexample.com";
            //ViewBag.user = user;

            return View(user);
           
        }
        //ActionResult sử dụng IEnumber
        public ActionResult IndexUsersModel()
        {
            var user = new List<User>(); 
            var user1 = new User();
            user1.name = "Mark Smith";
            user1.address = "Park Street";
            user1.email = "Mark@mvcexample.com";
            var user2 = new User();
            user2.name = "John Parker"; user2.address = "New Park"; user2.email = "John@mvcexample.com";
            var user3 = new User();
            user3.name = "Steave Edward "; user3.address = "Melbourne Street"; user3.email = "steave@mvcexample.com";
            user.Add(user1); user.Add(user2); user.Add(user3);
            return View(user);
        }
        // Sử dụng Helper Method
        public ActionResult IndexHelperMethod()
        {
            var user = new DemoAptech.Models.User();
            user.name = "John Smith";
            user.address = "Park Street";
            user.email = "john@mvcexample.com";
            //ViewBag.user = user;

            return View(user);


        }

        //Tao login
        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(string userName, string password)
        {
            if (userName == "Peter" && password == "pass@123")
            {
                string msg = "Welcome " + userName; 
                return Content(msg);
            }
            else
            {
                return View();
            } 

        }

        public ActionResult AutoGenaralModel()
        {
            var user = new List<User>();
        
            var user1 = new User();
            user1.name = "Mark Smith";
            user1.address = "Park Street";
            user1.email = "Mark@mvcexample.com";
            var user2 = new User();
            user2.name = "John Parker"; user2.address = "New Park"; user2.email = "John@mvcexample.com";
            var user3 = new User();
            user3.name = "Steave Edward "; user3.address = "Melbourne Street"; user3.email = "steave@mvcexample.com";
            user.Add(user1); user.Add(user2); user.Add(user3);
            //Code to populate the user collection
            return View(user);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit
            ()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
    }
}