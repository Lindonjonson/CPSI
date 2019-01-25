using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Disciplina
{
    public partial class WebFormGerenciarCategoria : System.Web.UI.Page
    {
        List<int> ListIdDocumentoDisciplina;  
        protected void Page_Load(object sender, EventArgs e)
        {
            controleListaDocumentoDisciplina();
           
        }
        public void controleListaDocumentoDisciplina()
        {
            
            if (IsPostBack)
            {
                if (Session["ListIdDocumento"] == null)
                    ListIdDocumentoDisciplina = new List<int>();
                else
                    ListIdDocumentoDisciplina = (List<int>)Session["ListIdDocumento"];
            }
            else
            {
                ListIdDocumentoDisciplina = new List<int>();

            }
        }
        protected void GridViewDisciplina_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DAL.DALDisciplina disciplina = new DAL.DALDisciplina();
            if (e.CommandName == "EditarDocumento")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey keys = GridViewDisciplina.DataKeys[index];
                string IdDisciplina = keys.Value.ToString();
                Session["IdDisciplina"] = IdDisciplina;
                Response.Redirect("~/Admin/WebFormEditarDocumentosDisciplina.aspx");
            }
        }

        protected void Inserir_Click(object sender, EventArgs e)
        {
            Modelo.Disciplina disciplina = new Modelo.Disciplina(0, TxtNomeDisciplina.Text);
            disciplina.addDocumentoDisciplina(ListIdDocumentoDisciplina);
            DAL.DALDisciplina DALDisciplina = new DAL.DALDisciplina();
            DALDisciplina.Insert(disciplina);
            Response.Redirect("~\\Admin\\WebFormGerenciarDisciplina.aspx");
            
       
        }

        protected void Excluir_Disciplina(object sender, EventArgs e)
        {
            DAL.DALDisciplina Delete = new DAL.DALDisciplina();
            int Index = Convert.ToInt32(GridViewDisciplina.SelectedRow.RowIndex);
            DataKey keys = GridViewDisciplina.DataKeys[Index];
            string IdDisciplina = keys.Value.ToString();
            Delete.Delete(IdDisciplina);
            Response.Redirect(Request.RawUrl);
        }

        protected void GridViewDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewDisciplina.SelectedRow.BackColor = System.Drawing.Color.AliceBlue;
            LabelDisciplina.Text = GridViewDisciplina.SelectedRow.Cells[1].Text;
        }

        protected void GridViewDocumentoDisciplina_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName== "Adicionar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewDocumentoDisciplina.Rows[index].BackColor = System.Drawing.Color.AliceBlue;
                DataKey dataKey = GridViewDocumentoDisciplina.DataKeys[index];
                int idDocumento = Convert.ToInt32(dataKey.Value);
                ListIdDocumentoDisciplina.Add(idDocumento);
                Session["ListIdDocumento"] = ListIdDocumentoDisciplina;
                


            }
            if (e.CommandName == "Remover")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewDocumentoDisciplina.Rows[index].BackColor = System.Drawing.Color.White;
                DataKey dataKey = GridViewDocumentoDisciplina.DataKeys[index];
                int idDocumento = Convert.ToInt32(dataKey.Value);
                ListIdDocumentoDisciplina.Remove(idDocumento);
                Session["ListIdDocumento"] = ListIdDocumentoDisciplina;
            }
        }

        protected void ExibirCadatrarClick(object sender, EventArgs e)
        {
            PanelListagemDisciplina.Visible = false;
            ButtonMostrarCadastrarDisciplina.Visible = false;
            PanelCadastrarDisciplina.Visible = true;
        }

        protected void Click_CancelarInsertDisciplina(object sender, EventArgs e)
        {
            Response.Redirect(Request.RawUrl);
        }
    }
}