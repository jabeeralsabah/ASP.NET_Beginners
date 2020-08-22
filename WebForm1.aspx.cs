using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appPracitice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        /*
  ASP.Net Page Life Cycle Events: vvery imp topic

         preInit - ispostback, iscallback, iscrosspostback properties will set at this stage.
	  it allows us to set master page and theme of the applocation dynamically
	  it helps us to use when we are woring on dynamical controls 
Init    - it allows us to load asp.net server contols and initializing with webform's viewstate.
InetComplete - it fired just immediatly after Init Initialization
PreLoad - it will execute just before the page Load events.
Load : it execute just before the occurence of events of the server contols of webform.
Control Events - in this stage it will hit control events of the webforms on click of button, dropdownlist
Load complete - this event occurs immediatly after the control events of the webform triggred.
Prerender - this event , occurs once the just before rendering of the page at this stage.
PreRenedercomplete - this event, occurs immediatly after prereder occurs.
Unload - in this stage, controls  of th webform and page will be unloaded from the memory.
             */

        /*viewstate : 
               1. viewstate state variable is used to maintain state of the response in client side.
               2. this data available with in the single page, we can't move this data from one page to another page.
               3. this data will be stored in hidden field of the browser.So, not recommanding to store sensitive data such as password.
               4. this data we can store on browser very linitedly, like max capacity of storing is 4kb. browser not allow as to store morethat that.
               5. viewstate allow us to preserve date on postback. */

        /*
Sessionstate:
1. session is an instance of the browser, each user can have multiple sessions with different instaces of the different browser with different session ids
2.session variable will store in server.
3.session state variable can be available across all the page, for single sessions only.
4.session state variable is a single user global data.
5.sessions data can be clear once user timeout, by default timeout is 20 mins, this can be configurable in web.config
6.by default, session id will be stored in user's browser cookies. if we explicitly ser cookieless="true" in the browser then
  browser will not allow us to set session id in cookies rather it apeends to URL as response.

Application State:
1. application state variable is available across all pages and across all the sessions. simple we can call this as multi user global data.
2. this data will be stored in with in the web server.
3. application variable we can cleared, once when we stop the posses of the hosting of the application.
4. this data avaiable from one page to another page.

*/

        /*
        Response.Redirect() : it used to navigate page to other server or with in the same server, in this redirection it will not hide destination URL.
        Server.Transfer() : it is used to navigate with in the same server, but it hides destination URL.
        */
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            Response.Write("Pre_Inet" + "<br/>");
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            Response.Write("Inet" + "<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            Response.Write("InetComplete" + "<br/>");
        }
        protected  void Page_PreLoad(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            //If the page is post back, then label contrl values will be loaded from view state.  
            //E.g: If you string str = lblName.Text, then str will contain viewstate values.  
            Response.Write("Pre_Load" + "<br/>");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            Response.Write("Loadcomplete" + "<br/>");
        }
        protected  void Page_PreRender(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            Response.Write("PreRender" + "<br/>");
        }
        protected  void Page_PreRenderComplete(object sender, EventArgs e)
        {
            //Work and It will assign the values to label.  
            //But "SaveStateComplete" values will not be available during post back. i.e. View state.  
            Response.Write("Pre_PreRendercomplete" + "<br/>");
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //Work and it will not effect label contrl, view stae and post back data.  
           // Response.Write("Unload" + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("button_click" + "<br/>");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Click"] == null)
                {
                    ViewState["Click"] = "0";
                }
                TextBox1.Text = ViewState["Click"].ToString();

                if (Session["Click"] == null)
                {
                    Session["Click"] = "0";
                }
                TextBox2.Text = Session["Click"].ToString();

                if (Application["Click"] == null)
                {
                    Application["Click"] = "0";
                }
                TextBox3.Text = Application["Click"].ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text =  (Convert.ToInt32(ViewState["Click"])+1).ToString();
            ViewState["Click"] = TextBox1.Text;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox2.Text = (Convert.ToInt32(Session["Click"]) + 1).ToString();
            Session["Click"] = TextBox2.Text;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/SessionandViewStatecheck.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = (Convert.ToInt32(Application["Click"]) + 1).ToString();
            Application["Click"] = TextBox3.Text;
        }
    }
}