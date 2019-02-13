using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormMatricularListaEspera : System.Web.UI.Page
    {
        Modelo.Matricula matricula;
        protected void Page_Load(object sender, EventArgs e)
        {
            matricula =(Modelo.Matricula) Session["matricula"];
             
        }

        protected void Button_Matricular_Click(object sender, EventArgs e)
        {
            Modelo.ListaEspera listaEspera = new Modelo.ListaEspera();
            listaEspera.IdAluno = matricula.idAluno;
            listaEspera.idTurma = matricula.idTurma;
            listaEspera.dataInscricao = matricula.dataMatricula;
            new DAL.DALListaEspera().Insert(listaEspera);
            Session.Remove("matricula");
            Response.Redirect("~/Matricula/WebFormMatricular.aspx");
        }

        protected void Click_Cancelar(object sender, EventArgs e)
        {
            Session.Remove("matricula");
            Response.Redirect("~/Matricula/WebFormMatricular.aspx"); ;
        }
    }
}