using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Turma
{
    public partial class WebFormGerenciarTurma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

      

        protected void Turmas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "Editar")
            {

                DAL.DALTurma Insert = new DAL.DALTurma();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                DataKey keys = GridViewTurmas.DataKeys[index];
                string IdTurma = keys.Value.ToString();
                Session["IdTurma"] = IdTurma;
                Response.Redirect("~//Admin//WebFormEditarTurma.aspx");
            }
            if(e.CommandName== "VizualizarMatriculados ")
            {

              
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                DataKey keys = GridViewTurmas.DataKeys[index];
                string id = keys.Value.ToString();
                Session["IdTurma"] = id;
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");


            }
        }
    }
}