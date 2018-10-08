using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormVizualizarTurma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
          
    protected void Turmas_RowCommand(object sender, GridViewCommandEventArgs e)
    {
            if (e.CommandName == "VisualizarMatriculados")
            {
            
                DAL.DALTurma selectTurma = new DAL.DALTurma();
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                DataKey keys = GridViewTurmas.DataKeys[index];
                string id = keys.Value.ToString();
                
                Session["NomeTurma"] = selectTurma.Select(id).NomeTurma;
                Session["IdTurma"] = id;
                Session["IdDisciplina"] =selectTurma.Select(id).IdDisciplina;
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");
            }
    }
   }
}