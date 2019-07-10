using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormDocumentoAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Modelo.Aluno aluno = new DAL.DALAluno().select(Session["idAluno"].ToString());
            LiteralAluno.Text = aluno.alunoNome;
            LiteralCPF.Text = aluno.cpf;
          
        }
        protected void GridViewDocumentosCadastro_Load(object sender, EventArgs e)
        {
            List<Modelo.AlunoDocumento> alunoDocumentos = new DAL.DALAlunoDocumento().SelectAll(Session["idAluno"].ToString());
            for (int index=0; index < GridViewDocumentosCadastro.Rows.Count; index++)
            {
                DataKey keyIdDocumento = GridViewDocumentosCadastro.DataKeys[index];
                int idDocumento= Convert.ToInt32(keyIdDocumento.Value);
                if(!alunoDocumentos.Exists(documento => documento.idDocumento == idDocumento))
                {

                    GridViewDocumentosCadastro.Rows[index].Visible = false;

                }

            }
           
        }

        protected void GridViewDocumentosMatricula_Load(object sender, EventArgs e)
        {
            List<Modelo.AlunoDocumento> alunoDocumentos = new DAL.DALAlunoDocumento().SelectAll(Session["idAluno"].ToString());
            for (int index = 0; index < GridViewDocumentosMatricula.Rows.Count; index++)
            {
                DataKey keyIdDocumento = GridViewDocumentosMatricula.DataKeys[index];
                int idDocumento = Convert.ToInt32(keyIdDocumento.Value);
                if (!alunoDocumentos.Exists(documento => documento.idDocumento == idDocumento))
                {

                       GridViewDocumentosMatricula.Rows[index].Visible = false;

                }

            }
        }
    }
}