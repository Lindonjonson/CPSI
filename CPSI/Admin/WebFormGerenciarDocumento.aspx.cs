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
             Modelo.Documento documento = new Modelo.Documento(0,txtDocumento.Text.ToString(),Convert.ToBoolean(int.Parse(DropDownListValidadeInsercao.SelectedItem.Value)),Convert.ToInt32(DropDownListTipoDocumentoInsercao.SelectedItem.Value));
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
        protected void GridViewDocumentos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Editar")
            {
                int Index = Convert.ToInt32(e.CommandArgument);
                DataKey keys = GridViewDocumentos.DataKeys[Index];
                string IdDocumento = keys.Value.ToString();
                Modelo.Documento documento = new DAL.DALDocumento().Select(IdDocumento);
                TextBoxDocumento.Text = documento.documento;
                DropDownListValidadeAtualizacao.SelectedValue = Convert.ToInt32(documento.validade).ToString();
                DropDownListTipoDocumentoAtualizacao.SelectedValue = documento.tipo.ToString();
                Session["Documento"] = documento;
                PanelVisualizaçãoDocumento.Visible = false;
                PanelEdicaoDocumento.Visible = true;
            }
        }

        protected void GridViewDocumentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewDocumentos.SelectedRow.BackColor = System.Drawing.Color.AliceBlue;
            LabelDocumento.Text = GridViewDocumentos.SelectedRow.Cells[2].Text;
            
        }

        protected void ButtonAtualizarDocumento_Click(object sender, EventArgs e)
        {
            Modelo.Documento documento = (Modelo.Documento) Session["Documento"];
            documento.documento= TextBoxDocumento.Text;
            documento.validade = Convert.ToBoolean(int.Parse(DropDownListValidadeAtualizacao.SelectedItem.Value));
            documento.tipo = int.Parse(DropDownListTipoDocumentoAtualizacao.SelectedItem.Value);
            new DAL.DALDocumento().Update(documento); 
            Response.Redirect(Request.RawUrl); 

        }

        protected void ButtonCancelarEdicao_Click(object sender, EventArgs e)
        {
            Session.Remove("Documento");
            Response.Redirect(Request.RawUrl);
        }
    }
}