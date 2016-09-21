using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MensajesWebApplication
{
    public partial class MasterSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MensajeriaButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MensajesWebForm.aspx");
        }
    }
}