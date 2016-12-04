using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class Main : System.Web.UI.Page
    {
        
 
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if new user or not
            if (Session["beenHereBefore"] == null)
                Label1.Text = "Hello, please select an option below.";
            else
                Label1.Text = "Welcome back, please select another option.";
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            switch (RadioButtonList1.SelectedIndex)
            {
                case 0:
                    Response.Redirect("~/Add.aspx");
                    Session["beenHereBefore"] = 1;     // user is no longer new
                    break;
                case 1:
                    Response.Redirect("~/Modify.aspx");
                    Session["beenHereBefore"] = 1;
                    break;
                case 2:
                    Response.Redirect("~/Search.aspx");
                    Session["beenHereBefore"] = 1;
                    break;
                case 3:
                    Response.Redirect("~/Count.aspx");
                    Session["beenHereBefore"] = 1;
                    break;
                case 4:
                    Response.Redirect("~/Statistics.aspx");
                    Session["beenHereBefore"] = 1;
                    break;
                default:
                    Label2.Text = "Please Pick an option";
                    Session["beenHereBefore"] = 1;
                    break;
            }



            /*using (tjnowak_1583911Entities MyTables = new tjnowak_1583911Entities())
            {
                var items = from i in MyTables.All_Events
                            select i;

            }*/
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}