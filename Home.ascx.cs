using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LoginGG.Controller;
namespace LoginGG
{
    public partial class Home : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnlogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("http://dnnregrister.com");
        }
    }
}