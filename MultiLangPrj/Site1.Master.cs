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

            //if (!this.IsPostBack)
            //{
            //    if (ddlLanguages.Items.FindByValue(CultureInfo.CurrentCulture.Name) != null)
            //    {
            //        ddlLanguages.Items.FindByValue(CultureInfo.CurrentCulture.Name).Selected = true;

            //    }
            //    //Request.UserLanguages[0];
                
            //}
            string language = Request.Cookies["language"] != null ? Request.Cookies["language"].Value : (Request.UserLanguages[0] != null ? Request.UserLanguages[0] : "pt");

           
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
            Response.Redirect(this.Request.Url.ToString());
        }

        protected void ImageButton2_PT_Click(object sender, ImageClickEventArgs e)
        {
         
            this.setLanguageCookie(ImageButton_SelectLanguage_PT.CommandArgument);
            Response.Redirect(this.Request.Url.ToString());

        }

        //protected void ddlLanguages_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.setLanguageCookie(ddlLanguages.SelectedValue);

        //}

        protected void setLanguageCookie(string language)
        {
            if (Request.Cookies["Language"] != null)
            {
                Response.Cookies["Language"].Value = language;
            }
            else
            {
                HttpCookie cookie = new HttpCookie("Language");
                cookie.Value = language;
                Response.SetCookie(cookie);
            }
        }
    }
}