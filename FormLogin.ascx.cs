using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LoginGG.Controller;
namespace LoginGG
{
    public partial class FormRegrister : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogingg_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoadFormGG" );
        }
    }
}