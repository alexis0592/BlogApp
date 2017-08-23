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
    }
}
