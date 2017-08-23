using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Core.Control;
using Blog.Core.Model;


namespace Blog.UI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            BlogControl _blogControl = new BlogControl();
            BlogPost _post = new BlogPost();
            _post.Author = "Yefry";
            _post.Title = "Post 1";
            _post.DatePost = DateTime.Now;
            _post.PostContent = "First Post";

            _blogControl.savePost(_post);
        }
    }
}