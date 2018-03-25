using CodeBeaBlog.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeBeaBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Blog()

        {
            
            return View();
        }
        public ActionResult BlogDetail()

        {
            
            return View();
        }
        public object GetPosts()
        {
            BlogRepository blog = new BlogRepository();
            List<Posts> aaa = blog.getPosts();
            return  JsonConvert.SerializeObject( aaa);
        }
    }
}