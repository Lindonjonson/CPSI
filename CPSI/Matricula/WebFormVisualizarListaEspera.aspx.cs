using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormVisualizarListaEspera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelNomeTurma.Text = new DAL.DALTurma().Select(Session["IdTurma"].ToString()).nomeTurma;
        }
    }
}