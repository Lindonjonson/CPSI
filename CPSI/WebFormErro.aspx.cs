using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI
{
	public partial class WebFormErro : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
          
            if (!IsPostBack)
            {
                Session["UrlRetorno"] = Request.UrlReferrer;
                LabelBoxErro.Text = Session["Erro"].ToString();
            }
                
		}

        protected void ButtonRetorno_Click(object sender, EventArgs e)
        {
            string url = Session["UrlRetorno"].ToString();
            Session.Remove("UrlRetorno");
            Session.Remove("Erro");
            Response.Redirect(url);
        }
    }
}