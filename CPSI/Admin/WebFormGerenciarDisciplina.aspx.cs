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
         
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
        }
        
        protected void GridViewDisciplina_RowCommand(object sender, GridViewCommandEventArgs e)
        {

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
            List<int> ListIdDocumentoDisciplina= new List<int>();
            foreach(ListItem I in CheckBoxListDocumentos.Items)
            {
                if (I.Selected)
                    ListIdDocumentoDisciplina.Add(Convert.ToInt32(I.Value));
              
            }
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

    }
}