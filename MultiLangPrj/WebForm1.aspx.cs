using System;
using MultiLangPrj.Code;

namespace MultiLangPrj
{
    public partial class WebForm1 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Resources.Resource.String1;
        }
    }
}