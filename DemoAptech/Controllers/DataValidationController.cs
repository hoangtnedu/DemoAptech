using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoAptech.Models;
namespace DemoAptech.Controllers
{
    public class DataValidationController : Controller
    {
        // GET: DataValidation
        public ActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Index(User model)
        //{
        //    string modelEmailId = model.email;
        //    string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
        //    if (System.Text.RegularExpressions.Regex.IsMatch(modelEmailId,
        //    regexPattern))
        //    {
        //        /*Implement registration process*/
        //        return Content("You have successfully registered");
        //    }
        //    else
        //    {
        //        return View();
        //    }

        //}
        [HttpPost]
        public ActionResult Index(Login model)
        {
            String modelPassword = model.password;
            if (modelPassword.Length < 7)
            {

                return View();
            }
            else
            {
                /*Implement registration process*/
                return Content("You have successfully registered");
            }
        }

        public ActionResult Email()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Email(User model)
        {
            string modelEmailId = model.email;
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if (System.Text.RegularExpressions.Regex.IsMatch(modelEmailId,
            regexPattern))
            {
                /*Implement registration process*/
                return Content("You have successfully registered");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LoginV()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginV(UserValidate user)
        {
            if (ModelState.IsValid)
            {
                //Xử lý bình thường
            }
            else return Content("Nhập ko đúng ");
            return View();
        }
    }

}
