using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormVizualizarMatriculados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelNomeTurma.Text = Session["NomeTurma"].ToString();
            
        }

        protected void RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="RemoverAluno")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey key = GridViewMatriculados.DataKeys[index];
                string IdAluno = key.Values["IdAluno"].ToString() ;
                string IdTurma = Session["IdTurma"].ToString();
                DAL.DALMatricula DALMatricula = new DAL.DALMatricula();
                Modelo.Matricula matricula = DALMatricula.Select(IdAluno, IdTurma);
                matricula.CancelarMatricula();
                DALMatricula.Update(matricula);
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");

            }
            if (e.CommandName == "Editar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey dataKeyID = GridViewMatriculados.DataKeys[index];
                string ID = dataKeyID.Values["IdAluno"].ToString();
                Session["IdAluno"] = ID;
                Response.Redirect("~//Matricula//WebFormEditarAluno.aspx");


            }
        }

        protected void Matricular(object sender, EventArgs e)
        {
            Response.Redirect("~/Matricula/WebFormRegistrarMatricula.aspx");
        }
    }
}