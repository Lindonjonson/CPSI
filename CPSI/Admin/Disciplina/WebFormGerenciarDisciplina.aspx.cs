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
            DAL.DALDisciplina insert = new DAL.DALDisciplina();
            insert.Insert(disciplina);
            Response.Redirect("~\\Admin\\Disciplina\\WebFormGerenciarDisciplina.aspx");
            
           
            
        }
    }
}