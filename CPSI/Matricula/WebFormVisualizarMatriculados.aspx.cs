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

        }

        protected void RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName=="Remover")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey key = GridViewMatriculados.DataKeys[index];
                string IdAluno = key.Values["IdAluno"].ToString() ;
                DAL.DALMatricula Remover = new DAL.DALMatricula();
                Remover.Delete(IdAluno);

            }
        }
    }
}