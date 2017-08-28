using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Blog.Core;
using Blog.Core.Control;
using Blog.Core.Model;

namespace Blog.UI
{
    public partial class ConsultPost : System.Web.UI.Page
    {
        BlogControl control;

        protected void Page_Load(object sender, EventArgs e)
        {
            control = new BlogControl();
            Loadgrid();
        }

         void Loadgrid() {
            
            dg_posts.DataSource = control.ConsultPost();
            dg_posts.DataBind();
        }



        protected void dg_posts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var post = dg_posts.SelectedRow.Cells[1].Text;
            control.deletePost(int.Parse(post));
            Loadgrid();
        }

        protected void dg_posts_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dg_posts.PageIndex = e.NewPageIndex;
            Loadgrid();
        }

        protected void dg_posts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string alert = "";
            TableCell cell = dg_posts.Rows[e.RowIndex].Cells[1];

            if (control.deletePost(int.Parse(cell.Text)))
            {
                alert = "alert(\"Registro eliminado exitosamente\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerConsoleScript", alert, true);
                Loadgrid();
            }
            else
            {
                alert = "alert(\"Error eliminando registro. Intente nuevamente\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerConsoleScript", alert, true);
            }
            
        }
    }
}