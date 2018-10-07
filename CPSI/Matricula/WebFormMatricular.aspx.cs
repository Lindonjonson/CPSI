using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormMatricular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewAlunos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Matricular")
            {
                DAL.DALMatricula insert = new DAL.DALMatricula();
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey dataKeyID = GridViewAlunos.DataKeys[index];
                string ID = dataKeyID.Values["IdAluno"].ToString();
                Modelo.Matricula matricula = new Modelo.Matricula(int.Parse(ID), int.Parse(Session["IdTurma"].ToString()),1 ,DateTime.Now);
                insert.Insert(matricula);
                Response.Redirect("~/Matricula/WebFormVisualizarMatriculados.aspx");


            }
        }
    }
}