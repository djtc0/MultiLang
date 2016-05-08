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
            string language = "en-us";

            //Detect User's Language.
            if (Request.UserLanguages != null)
            {
                //Set the Language.
                language = Request.UserLanguages[0];
            }
            string lang = string.Empty;//default to the invariant culture

            HttpCookie cookie = Request.Cookies["Language"];
            if (cookie != null)
            {
                language = cookie.Value;
            }

           
            //Set the Culture.
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }
    }
}