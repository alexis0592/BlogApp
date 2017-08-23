using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Core.Control;

namespace Blog.UI
{
    public partial class CreatePost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList_author.DataSource = new AuthorControl().getAuthor();
        }

        protected void DropDownList_author_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}