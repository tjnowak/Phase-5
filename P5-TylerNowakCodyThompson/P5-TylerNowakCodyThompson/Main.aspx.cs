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
        EventList theList;

        protected void Page_Load(object sender, EventArgs e)
        {
            // load in DB for a new user
            if (Session["theList"] == null)
            {
                theList.ReadData();
                Session["theList"] = theList;
            }    
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            switch (RadioButtonList1.SelectedIndex)
            {
                case 0:
                    Response.Redirect("~/Add.aspx");
                    break;
                case 1:
                    Response.Redirect("~/Modify.aspx");
                    break;
                case 2:
                    Response.Redirect("~/Search.aspx");
                    break;
                case 3:
                    Response.Redirect("~/Count.aspx");
                    break;
                case 4:
                    Response.Redirect("~/Statistics.aspx");
                    break;
                default:
                    Label2.Text = "Please Pick an option";
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