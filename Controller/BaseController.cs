using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI.WebControls;
using DotNetNuke.Common;
using DotNetNuke.Entities.Modules;
namespace LoginGG.Controller
{
    public class BaseController:PortalModuleBase
    {
        protected int DetailAt;

        //readonly HnueVideoDataContext hnueVideoDataContext = new HnueVideoDataContext();
        public virtual string BuildUrl(string control, params string[] ps)
        {
            var prm = ps.ToList();
            prm.Add("moduleId=" + ModuleId);
            if (!string.IsNullOrEmpty(control))
            {
                prm.Add("control=" + control);
            }
            return Globals.NavigateURL(TabId, "", prm.ToArray());
        }
        public string DetailUrl(object post, object tabId = null)
        {
            return Globals.NavigateURL(DetailAt == 0 ? Int16.Parse(tabId.ToString()) : DetailAt, PortalSettings, "", "p=" + post);
        }
    }
}