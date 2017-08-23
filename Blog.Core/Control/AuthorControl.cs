using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.Repositories;

namespace Blog.Core.Control
{
    public class AuthorControl
    {
        public Dictionary<int, string> getAuthor()
        {
            return new AuthorRepository().getAuthor();
        }
    }
}
