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
        List<int> documentoDisciplina;
        Modelo.Disciplina disciplina;
        DAL.DALDisciplina dALDisciplina = new DAL.DALDisciplina();
        protected void Page_Load(object sender, EventArgs e)
        {
            disciplina = dALDisciplina.Select(Session["IdDisciplina"].ToString());
            LabelDisciplina.Text = disciplina.disciplina;
            
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
        protected void GridViewDocumentos_Load(object sender, EventArgs e)
        {
            for (int index = 0; index < GridViewDocumentos.Rows.Count; index++)
            {

                DataKey key = GridViewDocumentos.DataKeys[index];
                int idDocumento = Convert.ToInt32(key.Value);
                if (disciplina.listDocumentoDaDisciplinas.Exists(X => X.idDocumento == idDocumento))
                    GridViewDocumentos.Rows[index].BackColor = System.Drawing.Color.AliceBlue;

            }
        }
        private void 
        protected void Editar_Documentos(object sender, EventArgs e)
        {
          
          
            Session.Remove("IdDisciplina");
            Response.Redirect("~/Admin/WebFormGerenciarDisciplina.aspx"); 
            
        }

        protected void Cancelar_click(object sender, EventArgs e)
        {
            Session.Remove("IdDisciplina");
            Response.Redirect("~/Admin/WebFormGerenciarDisciplina.aspx");

        }

        protected void GridViewDocumentos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}