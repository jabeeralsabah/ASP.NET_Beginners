using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appPracitice
{
    public partial class SessionState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Click"] == null)
                {
                    Response.Write("Webform1.aspx page View state is Available as : " + "NotAvailable" +"<br/>");
                }

                Response.Write("Webform1.aspx page session state is Available as : " + Session["Click"].ToString() + "<br/>");

              
                Response.Write("Webform1.aspx page Application state is Available as : " + Application["Click"].ToString() + "<br/>");
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
        Response.Redirect("~/Webform1.aspx");
        }
    }
}