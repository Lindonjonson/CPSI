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
            DAL.DALDisciplina dALDisciplina= new DAL.DALDisciplina();
            LabelDisciplina.Text = dALDisciplina.Select(Session["IdDisciplina"].ToString()).disciplina;
        }

        protected void Editar_Documentos(object sender, EventArgs e)
        {
            DAL.DALDocumentoDisciplina dALDocumentoDisciplina = new DAL.DALDocumentoDisciplina();
            dALDocumentoDisciplina.Delete(Session["IdDisciplina"].ToString());
            List<int> listIDdocumentos = new List<int>();
            foreach (ListItem I in CheckBoxListDocumento.Items)
            {
                if (I.Selected) listIDdocumentos.Add(Convert.ToInt32(I.Value));
            }

            Modelo.DocumentoDisciplina documentoDisciplina = new Modelo.DocumentoDisciplina(listIDdocumentos,Convert.ToInt32(Session["IdDisciplina"]));
            dALDocumentoDisciplina.Insert(documentoDisciplina);
            Response.Redirect("~/Admin/WebFormGerenciarDisciplina.aspx");
        }
    }
}