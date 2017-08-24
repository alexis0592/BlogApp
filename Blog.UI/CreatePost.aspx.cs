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
    public partial class CreatePost : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> authorsDictionary = new AuthorControl().getAuthor();
            ListItem item;

            if (!Page.IsPostBack)
            {

                foreach (int key in authorsDictionary.Keys)
                {
                    item = new ListItem();
                    item.Value = key.ToString();
                    item.Text = authorsDictionary[key];

                    DropDownList_author.Items.Add(item);
                }
            }
            //DropDownList_author.DataSource = new AuthorControl().getAuthor();
        }

        protected void DropDownList_author_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_clean_Click(object sender, EventArgs e)
        {
            cleanForm();
           
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            BlogControl _blogControl = new BlogControl();
            BlogPost _post = new BlogPost();
            _post.Author = new AuthorControl().getAuthor(Convert.ToInt32(DropDownList_author.SelectedValue));
            _post.Title = txt_title.Text;
            _post.DatePost = DateTime.Now;
            _post.PostContent = txt_contenido.Text;



            if (_blogControl.savePost(_post))
            {
                lbl_msg.Text = "Post Publicado";
                lbl_msg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lbl_msg.Text = "Error publicando Post!";
                lbl_msg.ForeColor = System.Drawing.Color.Red;
            }

            cleanForm();
            
        }

        void cleanForm()
        {
            txt_title.Text = "";
            txt_contenido.Text = "";
            DropDownList_author.SelectedValue = "1";
        }
    }
}