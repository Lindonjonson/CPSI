using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin
{
    public partial class WebFormVisualizacaoTurma1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewTurmas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {

                DAL.DALTurma Insert = new DAL.DALTurma();
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                DataKey keys = GridViewTurmas.DataKeys[index];
                string IdTurma = keys.Value.ToString();
                Session["IdTurma"] = IdTurma;
                Response.Redirect("~/Admin/WebFormGerenciarTurma.aspx");
            }
        }
    }
}