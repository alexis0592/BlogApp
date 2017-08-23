using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.Model;
using Blog.Core.Repositories;

namespace Blog.Core.Control
{
    public class BlogControl
    {
        public bool savePost(BlogPost model)
        {
            try
            {
                BlogRepository _repository = new BlogRepository();
                _repository.SavePost(model);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
