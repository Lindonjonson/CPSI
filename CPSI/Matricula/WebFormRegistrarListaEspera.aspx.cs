using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormRegistrarListaEspera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCancelarEspera_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Matricula/WebFormGerenciarAluno.aspx");
        }

        protected void Click_Matricular(object sender, EventArgs e)
        {
            DAL.DALListaEspera DalListaEspera = new DAL.DALListaEspera();
            DataKey dataKeyIDAluno = DetailsViewAluno.DataKey;
            string IDAluno = dataKeyIDAluno.Values["IdAluno"].ToString();
            Modelo.ListaEspera ListaEspera = new Modelo.ListaEspera(int.Parse(Session["IdTurma"].ToString()), int.Parse(IDAluno), DateTime.Now);
            DalListaEspera.Insert(ListaEspera);
            Response.Redirect("~/Matricula/WebFormVisualizarTurma.aspx");
        }
    }
}