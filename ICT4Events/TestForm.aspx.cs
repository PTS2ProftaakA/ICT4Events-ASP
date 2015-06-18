using System;

namespace ICT4Events
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Request.IsAuthenticated);
        }
    }
}