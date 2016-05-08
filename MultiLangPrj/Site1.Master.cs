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
            setLanguageIcon();
        }

        protected void ImageButton_Click(object sender, ImageClickEventArgs e)
        {
            Session["selectedLanguage"] = ((ImageButton)sender).CommandArgument;
            setLanguageIcon();
        }

        private void setLanguageIcon()
        {
            string language = Session["selectedLanguage"] != null ? Session["selectedLanguage"].ToString() : (Request.UserLanguages[0] != null ? Request.UserLanguages[0] : "pt");

            if (language.Contains("en"))
            {
                ImageButton_SelectLanguage_EN.Attributes.Add("disabled", "disabled");
                ImageButton_SelectLanguage_EN.ImageUrl = "~\\images\\United-Kingdom-icon-big.jpg";
                ImageButton_SelectLanguage_PT.Attributes.Remove("disabled");
                ImageButton_SelectLanguage_PT.ImageUrl = "~\\images\\Portugal-icon-small.jpg";
            }

            else
            {
                ImageButton_SelectLanguage_PT.Attributes.Add("disabled", "disabled");
                ImageButton_SelectLanguage_PT.ImageUrl = "~\\images\\Portugal-icon-big.jpg";
                ImageButton_SelectLanguage_EN.Attributes.Remove("disabled");
                ImageButton_SelectLanguage_EN.ImageUrl = "~\\images\\United-Kingdom-icon-small.jpg";
            }
        }
    }
}