using CodeBeaBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBeaBlog.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BlogPosts()
        {

            return View();
        }
        public ActionResult NewPost()
        {
            return View();
        }

        public  object SaveNewPost(Posts cust)
        {
             BlogRepository blog = new BlogRepository();
            object aaa = blog.SaveNewPost(cust);
            return "";
        }
    }
}