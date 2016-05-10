using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MultiLangPrj
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string language = HF_CurrentSelectedLanguage.Value != null ? HF_CurrentSelectedLanguage.Value : (Request.UserLanguages[0] != null ? Request.UserLanguages[0] : "pt");
           
                if (language == "en")
                {
                    ImageButton_SelectLanguage_EN.Attributes.Add("disabled", "disabled");
                ImageButton_SelectLanguage_EN.ImageUrl = "~\\images\\United-Kingdom-icon-big.jpg";
                    ImageButton_SelectLanguage_PT.Attributes.Remove("disabled");
                ImageButton_SelectLanguage_PT.ImageUrl = "~\\images\\Portugal-icon-small.jpg";
            }

                else {
                    ImageButton_SelectLanguage_PT.Attributes.Add("disabled", "disabled");
                ImageButton_SelectLanguage_PT.ImageUrl = "~\\images\\Portugal-icon-big.jpg";
                ImageButton_SelectLanguage_EN.Attributes.Remove("disabled");
                ImageButton_SelectLanguage_EN.ImageUrl = "~\\images\\United-Kingdom-icon-small.jpg";
            }
        }

        protected void ImageButton1_EN_Click(object sender, ImageClickEventArgs e)
        {
            this.setLanguageCookie(ImageButton_SelectLanguage_EN.CommandArgument);
        }

        protected void ImageButton2_PT_Click(object sender, ImageClickEventArgs e)
        {
            this.setLanguageCookie(ImageButton_SelectLanguage_PT.CommandArgument);
        }

        protected void setLanguageCookie(string language)
        {
            if (Request.Cookies["Language"] != null)
            {
                Response.Cookies["Language"].Value = language;
            }
            else
            {
                HttpCookie cookie = new HttpCookie("Language");
                cookie.HttpOnly = true;
                cookie.Expires = DateTime.Now.AddDays(-1);
                cookie.Value = language;
                Response.SetCookie(cookie);
            }
        }
    }
}