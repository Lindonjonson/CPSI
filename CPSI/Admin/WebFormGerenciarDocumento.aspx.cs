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
            DAL.DALDocumento DALDocumento = new DAL.DALDocumento();
            if (e.CommandName == "Excluir")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                DataKey keys = GridViewDocumentos.DataKeys[Index];
                string ID = keys.Value.ToString();
                DALDocumento.Delete(ID);
                Response.Redirect("~\\Admin\\WebFormGerenciarDocumento.aspx");

            }
            if (e.CommandName=="Editar")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                DataKey keys = GridViewDocumentos.DataKeys[Index];
                string ID = keys.Value.ToString();
                Response.Redirect("~\\Admin\\WebFormEditarDocumento.aspx?ID="+ID);

            }
        }
    }
}