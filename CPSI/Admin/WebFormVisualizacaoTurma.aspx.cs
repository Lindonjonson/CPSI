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
            if (e.CommandName == "Matriculados")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey keyIdTurma = GridViewTurmas.DataKeys[index];
                Session["IdTurma"] = keyIdTurma.Value;
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");

            }
            if (e.CommandName == "Espera")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey keyIdTurma = GridViewTurmas.DataKeys[index];
                Session["IdTurma"] = keyIdTurma.Value;
                Response.Redirect("~/Matricula/WebFormVisualizarListaEspera.aspx");

            }
        }

        protected void Inserir_Click(object sender, EventArgs e)
        {
            Session.Remove("IdTurma");
            Response.Redirect("~/Admin/WebFormGerenciarTurma.aspx");
        }
    }
}