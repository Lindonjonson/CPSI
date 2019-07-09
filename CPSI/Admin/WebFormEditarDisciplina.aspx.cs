using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Disciplina
{
    public partial class WebFormEditarDisciplina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Labeldisciplina.Text = DetailsViewDisciplina.Rows[0].Cells[1].Text;
        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            DAL.DALDisciplina dALDisciplina = new DAL.DALDisciplina();
            DataKey keys = DetailsViewDisciplina.DataKey;
            string id = keys.Value.ToString();
            dALDisciplina.Delete(id);
            Response.Redirect("~\\Admin\\WebFormGerenciarDisciplina.aspx");
        }
    }
}