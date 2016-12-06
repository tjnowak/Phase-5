using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Diagnostics;

namespace P5_TylerNowakCodyThompson
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            // Get error
            Exception objError = Server.GetLastError().GetBaseException();
            string error = "Error Caught in Application_Error event\n" +
                           "Error in: " + Request.Url.ToString() +
                           "\nError Message:" + objError.Message.ToString() +
                           "\nStack Trace:" + objError.StackTrace.ToString();
           
            // Write error to log
            EventLog.WriteEntry("Weather_WebApp", error, EventLogEntryType.Error);

            // Clear error
            Server.ClearError();

            // Redirect user
            Response.Redirect("~/ErrorRedirect.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}