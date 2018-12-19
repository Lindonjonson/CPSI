using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormImprimirFichaInscricao : System.Web.UI.Page
    {
        Modelo.Matricula matricula;
        protected void Page_Load(object sender, EventArgs e)
        {
             
              matricula =  (Modelo.Matricula)Session["matricula"];
              Modelo.Aluno aluno = new DAL.DALAluno().Select(matricula.IdAluno.ToString());
              Modelo.Turma turma = new DAL.DALTurma().Select(matricula.IdTurma.ToString());
              LabelData.Text = matricula.DataMatricula.ToShortDateString();
              
         


        }

        protected void Imprimir(object sender, EventArgs e)
        {
            Session["IdAluno"] = matricula.IdAluno;
            Session["IdTurma"] = matricula.IdTurma;
            PanelImpressao.Visible = true;
            Button_Imprimir.Visible = false;
        }
    }
}