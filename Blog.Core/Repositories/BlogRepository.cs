using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.Model;

namespace Blog.Core.Repositories
{
    class BlogRepository
    {
        public bool SavePost(BlogPost post)
        {
            try
            {
                //abre una conexión por el momento que se use el objeto
                using (var db = new cursonetEntities())
                {
                    db.BlogPosts.Add(post);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
        }

        public List<BlogPost> ConsultPost()
        {
            List<BlogPost> posts = new List<BlogPost>();

            try
            {
                using(var db = new cursonetEntities())
                {
                    posts = db.BlogPosts.ToList();
                }

                return posts;
            }
            catch (Exception e)
            {
                return new List<BlogPost>();
            }
        }

        public bool deletePost(int id)
        {
            BlogPost blogPost = new BlogPost();

            try
            {
                using(var db = new cursonetEntities())
                {
                    blogPost = db.BlogPosts.ToList().Where(i => i.Id == id).FirstOrDefault();
                    db.BlogPosts.Remove(blogPost);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
