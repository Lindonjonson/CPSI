using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin
{
    public partial class WebFormEditarDocumentosDisciplina : System.Web.UI.Page
    {
 
      
        protected void Page_Load(object sender, EventArgs e)
        {

            DAL.DALDisciplina dALDisciplina = new DAL.DALDisciplina();
            LabelDisciplina.Text = dALDisciplina.Select(Session["IdDisciplina"].ToString()).disciplina;
        }

        protected void Editar_Documentos(object sender, EventArgs e)
        {
          /* DAL.DALDocumentoDisciplina dALDocumentoDisciplina = new DAL.DALDocumentoDisciplina();
           dALDocumentoDisciplina.Delete(Session["IdDisciplina"].ToString());
           Modelo.DocumentoDisciplina documentoDisciplina = new Modelo.DocumentoDisciplina(Convert.ToInt32(Session["IdDisciplina"]));
           foreach (ListItem I in CheckBoxListDocumento.Items)
           {
                if (I.Selected) documentoDisciplina.AddIdDocumento(int.Parse(I.Value));
           }

           
            dALDocumentoDisciplina.Insert(documentoDisciplina);
            Session.Remove("IdDisciplina");
            Response.Redirect("~/Admin/WebFormGerenciarDisciplina.aspx"); 
            */
        }

        protected void Cancelar_click(object sender, EventArgs e)
        {
            Session.Remove("IdDisciplina");
            Response.Redirect("~/Admin/WebFormGerenciarDisciplina.aspx");

        }
    }
}