using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410703523.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        
        public ActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult SignUp(string name, string account, string password)
        {
            if (name == null || name == "")
            {
                ViewBag.Namemessage = "請輸入姓名";   
            }
            if (account == null || account == "")
            {
                ViewBag.accountmessage = "請輸入帳號";
            }
            if (password == null || password == "")
            {
                ViewBag.Passwordmessage = "請輸入密碼";
            }
            if (name !=null && account!=null && password!=null)
            {
                ViewBag.Message = "註冊成功";
            }
            return View();

        }

    }
}