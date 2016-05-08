using System.Threading;
using System.Globalization;
using System.Web;

namespace MultiLangPrj.Code
{
    ///<summary>
    /// Summary description for BasePage
    ///</summary>
    public class BasePage : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            string language = "pt";

            //Detect User's Language.
            if (Request.UserLanguages != null)
            {
                //Set the Language.
                language = Request.UserLanguages[0];
            }
            
            if (Request.Form["ctl00$HF_CurrentSelectedLanguage"] != null)
            {
                language = Request.Form["ctl00$HF_CurrentSelectedLanguage"];
            }

            else //look at the session
            {
                
                if (Session["selectedLanguage"] != null)
                {
                    language = Session["selectedLanguage"].ToString();
                }
            }
            
            //Set the Culture.
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }
    }
}