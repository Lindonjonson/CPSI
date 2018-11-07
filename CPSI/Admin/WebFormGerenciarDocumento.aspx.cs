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
            DAL.DALDocumento insert = new DAL.DALDocumento();
            Modelo.Documento documento = new Modelo.Documento(0,txtDocumento.Text.ToString());
            insert.Insert(documento);
            Response.Redirect("~\\Admin\\WebFormGerenciarDocumento.aspx");
        }

        protected void GridViewDocumentos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName=="Editar")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                DataKey keys = GridViewDocumentos.DataKeys[Index];
                string IdDocumento = keys.Value.ToString();
                Session["IdDocumento"] = IdDocumento;
                Response.Redirect("~\\Admin\\WebFormEditarDocumento.aspx");

            }
        }
    }
}