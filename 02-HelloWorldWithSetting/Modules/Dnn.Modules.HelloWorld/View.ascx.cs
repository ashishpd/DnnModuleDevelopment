using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Entities.Modules;

namespace Dnn.Modules.HelloWorld
{
    public partial class View : PortalModuleBase
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lblDays.Text = Settings.ContainsKey("Days") ? Settings["Days"].ToString() : "5";            
        }
    }
}