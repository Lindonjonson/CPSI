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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DAL.DALDisciplina disciplina = new DAL.DALDisciplina();

            if (e.CommandName == "Editar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string id = GridViewDisciplina.Rows[index].Cells[0].Text;
                Response.Redirect("~\\Admin\\Disciplina\\WebFormEditarDisciplina.aspx?ID=" + id);


            }
            if (e.CommandName == "Excluir")
            {
  
                int index = Convert.ToInt32(e.CommandArgument);
                string id = GridViewDisciplina.Rows[index].Cells[0].Text;
                disciplina.Delete(id);
                Response.Redirect("~\\Admin\\Disciplina\\WebFormGerenciarDisciplina.aspx");



            }
        }

        protected void Inserir_Click(object sender, EventArgs e)
        {   
            Modelo.Disciplina disciplina = new Modelo.Disciplina(int.Parse(TxtIdDisciplina.Text),TxtNomeDisciplina.Text, TxtCodigo.Text);
            DAL.DALDisciplina insertDisciplina = new DAL.DALDisciplina();
            insertDisciplina.Insert(disciplina);
            List<int> listIDdocumentos = new List<int>();
            foreach( ListItem I in CheckBoxListDocumento.Items)
            {

                if (I.Selected) listIDdocumentos.Add(Convert.ToInt32(I.Value)); 

            }


            Modelo.DocumentoDisciplina documentoDisciplina = new Modelo.DocumentoDisciplina(listIDdocumentos, int.Parse(TxtIdDisciplina.Text));
            DAL.DALDocumentoDisciplina InsertDocumentoDisciplina = new DAL.DALDocumentoDisciplina();
            InsertDocumentoDisciplina.Insert(documentoDisciplina);
            Response.Redirect("~\\Admin\\Disciplina\\WebFormGerenciarDisciplina.aspx?Teste="+listIDdocumentos[0].ToString());
            
            
           
            
        }
    }
}