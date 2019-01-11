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
              Modelo.Aluno aluno = new DAL.DALAluno().select(matricula.idAluno.ToString());
              Modelo.Turma turma = new DAL.DALTurma().Select(matricula.idTurma.ToString());
              LabelData.Text = matricula.dataMatricula.ToShortDateString();
              
         


        }

        protected void Imprimir(object sender, EventArgs e)
        {
            Session["IdAluno"] = matricula.idAluno;
            Session["IdTurma"] = matricula.idTurma;
            PanelImpressao.Visible = true;
            Button_Imprimir.Visible = false;
        }
    }
}