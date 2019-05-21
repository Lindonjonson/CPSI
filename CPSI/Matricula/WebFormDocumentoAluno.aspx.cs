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
    }
}