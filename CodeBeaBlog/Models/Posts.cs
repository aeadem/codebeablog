using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeBeaBlog.Models
{
    public class Posts
    {
        [Key]
        public int ID { get; set; }
        public string title { get; set; }
        public string article { get; set; }
        public string titleClean { get; set; }
        public string file { get; set; }
        public int authorId { get; set; }
        public DateTime datePublished { get; set; }
        public string bannerImage { get; set; }
        public string featured { get; set; }
        public string enabled { get; set; }
        public string commentsEnabled { get; set; }
        public int views { get; set; }

    }
    public class blog_category
    {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string name_clean { get; set; }
        public bool enabled { get; set; }
        public DateTime date_created { get; set; }

    }


}