using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MultiLangPrj
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string language = "pt";

            //Detect User's Language.
            if (Request.UserLanguages != null)
            {
                //Set the Language.
                language = Request.UserLanguages[0];
            }
            string lang = string.Empty;//default to the invariant culture



            if (Request.Form["ctl00$HF_CurrentSelectedLanguage"] != null)
            {
                language = Request.Form["ctl00$HF_CurrentSelectedLanguage"];
            }

            else //look at the cookie
            {
                HttpCookie cookie = Request.Cookies["Language"];
                if (cookie != null)
                {
                    language = cookie.Value;
                }
            }

            //Set the Culture.
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }
    }
}