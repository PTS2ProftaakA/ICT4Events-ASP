using System;
using System.Web.Security;

namespace ICT4Events
{
    public partial class Uitloggen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Inloggen.aspx");
        }
    }
}