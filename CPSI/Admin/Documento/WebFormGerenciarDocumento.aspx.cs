using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Documento
{
    public partial class WebFormGerenciarDocumento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Inserir_Click(object sender, EventArgs e)
        {
            Modelo.Documento documento = new Modelo.Documento(int.Parse(txtIdDocumento.Text),txtDocumento.Text.ToString());
            DAL.DALDocumento insert= new DAL.DALDocumento();
            insert.Insert(documento);
            Response.Redirect("~\\Admin\\Documento\\WebFormGerenciarDocumento.aspx");
        }
    }
}