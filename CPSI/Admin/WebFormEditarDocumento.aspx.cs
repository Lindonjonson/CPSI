using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Documento
{
    public partial class WebFormEditarDocumento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelDocumento.Text = DetailsViewDocumento.Rows[1].Cells[0].Text; 
        }
        protected void Excluir_Click(object sender,EventArgs e)
        {
            DAL.DALDocumento dALDocumento = new DAL.DALDocumento();
            DataKey keys = DetailsViewDocumento.DataKey;
            string ID = keys.Value.ToString();
            dALDocumento.Delete(ID);
            Response.Redirect("~\\Admin\\WebFormGerenciarDocumento.aspx");

        }
    }
}