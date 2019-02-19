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
        List<int> ListIdDocumentoDisciplina;
        Modelo.Disciplina disciplina;
        DAL.DALDisciplina dALDisciplina = new DAL.DALDisciplina();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            controleListaDocumentoDisciplina();
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
            if (!IsPostBack)
            {

                for (int index = 0; index < GridViewDocumentos.Rows.Count; index++)
                {

                    DataKey key = GridViewDocumentos.DataKeys[index];
                    int idDocumento = Convert.ToInt32(key.Value);
                    if (disciplina.getDocumentoDisciplina().Exists(X => X.idDocumento == idDocumento))
                    {
                        GridViewDocumentos.Rows[index].BackColor = System.Drawing.Color.AliceBlue;
                        if (!(ListIdDocumentoDisciplina.Exists(i => i == idDocumento)))
                        {
                            ListIdDocumentoDisciplina.Add(idDocumento);
                           
                        }

                    }

                }
                Session["ListIdDocumento"] = ListIdDocumentoDisciplina;
            }
           
        }
       
        protected void Editar_Documentos(object sender, EventArgs e)
        {

            disciplina.addDocumentoDisciplina(ListIdDocumentoDisciplina);
            new DAL.DALDocumentoDisciplina().update(disciplina);
            Session.Remove("IdDisciplina");
            Session.Remove("ListIdDocumento");
            Response.Redirect("~/Admin/WebFormGerenciarDisciplina.aspx"); 
            
        }

        protected void Cancelar_click(object sender, EventArgs e)
        {
            Session.Remove("ListIdDocumento"); 
            Session.Remove("IdDisciplina");
            Response.Redirect("~/Admin/WebFormGerenciarDisciplina.aspx");

        }

        protected void GridViewDocumentos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Adicionar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewDocumentos.Rows[index].BackColor = System.Drawing.Color.AliceBlue;
                DataKey dataKey = GridViewDocumentos.DataKeys[index];
                int idDocumento = Convert.ToInt32(dataKey.Value);
                ListIdDocumentoDisciplina.Add(idDocumento);
                Session["ListIdDocumento"] = ListIdDocumentoDisciplina;



            }
            if (e.CommandName == "Remover")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewDocumentos.Rows[index].BackColor = System.Drawing.Color.White;
                DataKey dataKey = GridViewDocumentos.DataKeys[index];
                int idDocumento = Convert.ToInt32(dataKey.Value);
                ListIdDocumentoDisciplina.Remove(idDocumento);
                Session["ListIdDocumento"] = ListIdDocumentoDisciplina;
            }
        }
    }
}