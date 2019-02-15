using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormVisualizarTurmas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewTurmas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Matriculados")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey keyIdTurma = GridViewTurmas.DataKeys[index];
                Session["IdTurma"] = keyIdTurma.Value;
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");

            }
        }
    }
}