using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeBeaBlog.Models
{
    public class BlogRepository
    {
        public object SaveNewPost(Posts post)
        {

            using (var ctx = new ApplicationDbContext())
            {
                Posts newPost = new Posts();// { title =post.title };
                newPost.title = post.title;
                newPost.article = post.article;
                newPost.authorId = 1;
                newPost.datePublished = DateTime.Now;
                ctx.posts.Add(newPost);
                ctx.SaveChanges();
            }
            return "sss";
        }

        public List<Posts> getPosts()
        {
            Posts newPost = new Posts();// { title =post.title };
            List<Posts> listPosts = new List<Posts>();
            using (var ctx = new ApplicationDbContext())
            {
                listPosts = ctx.posts.ToList();
            }


            return listPosts;

        }


    }

   
}