using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P5_TylerNowakCodyThompson
{
    public partial class DisplayStatistics : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DisplayStatsButton_Click(object sender, EventArgs e)
        {
            switch (StatsOptionsRBList.SelectedIndex)
            {
                case 0:
                    {
                        NoneSelected.Visible = false;
                        Response.Redirect("~/TopThree.aspx");
                        break;
                    }
                case 1:
                    {
                        NoneSelected.Visible = false;
                        Response.Redirect("~/Fatalities.aspx");
                        break;
                    }
                case 2:
                    {
                        NoneSelected.Visible = false;
                        Response.Redirect("~/AvgTorDamg.aspx");
                        break;
                    }
                case 3:
                    {
                        NoneSelected.Visible = false;
                        Response.Redirect("~/Main.aspx");
                        break;
                    }
                default:
                    {
                        NoneSelected.Visible = true;
                        break;
                    }
            }
        }
    }
}