using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormEditarAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelAluno.Text = DetailsViewAluno.Rows[0].Cells[1].Text;
            LabelCPF.Text = DetailsViewAluno.Rows[2].Cells[1].Text;
        }
        protected void Excluir_Click(object sender, EventArgs e)
        {
            
            DataKey dataKeyID = DetailsViewAluno.DataKey;
            string ID = dataKeyID.Value.ToString();
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            dALAluno.Delete(ID);
            Response.Redirect("~//Matricula//WebFormGerenciarAluno.aspx");

        }
    }
}