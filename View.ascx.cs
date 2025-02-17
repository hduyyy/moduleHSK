﻿using LoginGG.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LoginGG.Controller;
namespace LoginGG
{
    public partial class View : BaseController
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var userControl = Request.QueryString["control"] ?? "Home";
                var portalmodule = (BaseController)LoadControl(userControl + ".ascx");
                portalmodule.ModuleConfiguration = ModuleConfiguration;
                portalmodule.ID = System.IO.Path.GetFileNameWithoutExtension(userControl);
                pnlContainer.Controls.Add(portalmodule);
            }
            catch (Exception ex)
            {
                Message.InnerHtml = ex.Message + "<br/>" + ex.InnerException?.Message;
            }
        }
    }
}