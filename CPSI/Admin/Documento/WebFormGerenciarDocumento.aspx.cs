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

        protected void GridViewDocumentos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DAL.DALDocumento DALDocumento = new DAL.DALDocumento();
            if (e.CommandName == "Excluir")
            {

                int Index = Convert.ToInt32(e.CommandArgument);
                string ID = GridViewDocumentos.Rows[Index].Cells[0].Text;
                DALDocumento.Delete(ID);
                Response.Redirect("~\\Admin\\Documento\\WebFormGerenciarDocumento.aspx");

            }
            if (e.CommandName=="Editar")
            {


                int Index = Convert.ToInt32(e.CommandArgument);
                string ID = GridViewDocumentos.Rows[Index].Cells[0].Text;
                Response.Redirect("~\\Admin\\Documento\\WebFormEditarDocumento.aspx?ID="+ID);

            }
        }
    }
}