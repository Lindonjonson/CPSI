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

      

        protected void Excluir_Documento(object sender, EventArgs e)
        {

          
            int Index = Convert.ToInt32(GridViewDocumentos.SelectedRow.RowIndex);
            DataKey keys = GridViewDocumentos.DataKeys[Index];
            string IdDocumento = keys.Value.ToString();
            DAL.DALDocumento dALDocumento = new DAL.DALDocumento();
            dALDocumento.Delete(IdDocumento);
            Response.Redirect(Request.RawUrl);
        }

        protected void GridViewDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewDocumentos.SelectedRow.BackColor = System.Drawing.Color.AliceBlue;
            LabelDocumento.Text = GridViewDocumentos.SelectedRow.Cells[1].Text;
            
        }
    }
}