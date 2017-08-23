using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Repositories
{
    class AuthorRepository
    {
        public Dictionary<int, string> getAuthor()
        {
            Dictionary<int, string> authors = new Dictionary<int, string>();

            authors.Add(1, "Author1");
            authors.Add(1, "Author2");
            authors.Add(1, "Author3");
            authors.Add(1, "Author4");

            return authors;
        }
    }
}
