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
                string idTurma = keys.Value.ToString();
                Modelo.Turma Turma = selectTurma.Select(idTurma);
                Session["NomeTurma"] = Turma.NomeTurma;
                Session["IdTurma"] = Turma.IdTurma;
                Session["IdDisciplina"] = Turma.IdDisciplina;
                Session["Turma"] = Turma;
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");
            }
            



           
    }
   }
}