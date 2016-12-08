using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace P5_TylerNowakCodyThompson
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SelectButton_Click(object sender, EventArgs e)
        {
            switch (ChoicesRadioButtonList.SelectedIndex)
            {
                case 2:
                    Response.Redirect("~/Search.aspx");
                    break;
                case 3:
                    Response.Redirect("~/Count.aspx");
                    break;
                case 4:
                    Response.Redirect("~/DisplayStatistics.aspx");
                    break;
                default:
                    NoAnswerLabel.Text = "Please pick an option";
                    break;
            }
        }

        protected void ChoicesRadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}