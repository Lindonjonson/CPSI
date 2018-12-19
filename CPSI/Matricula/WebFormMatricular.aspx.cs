using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormMatricular : System.Web.UI.Page
    {

        Modelo.Matricula matricula;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Pesquisar_Click(object sender, EventArgs e)
        {
            
        }

        protected void PesquisarAluno_Click(object sender, EventArgs e)
        {
           
        }

        protected void GridViewTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewTurma.SelectedRow.BackColor = System.Drawing.Color.OrangeRed;
            
        
        }

        protected void GridViewAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GridViewAlunos.SelectedRow.BackColor = System.Drawing.Color.OrangeRed;
            
        }

        protected void Exibir_matricular(object sender, EventArgs e)
        {

            PanelConfirmação.Visible = true;
            LabelNomeAluno.Text = GridViewAlunos.SelectedRow.Cells[1].Text;
            LabelNomeTurma.Text = GridViewTurma.SelectedRow.Cells[1].Text;

        }

        protected void Button_Matricular_Click(object sender, EventArgs e)
        {
            int IndexGridViewTurma = Convert.ToInt32(GridViewTurma.SelectedRow.RowIndex);
            int IndexGridViewAluno = Convert.ToInt32(GridViewAlunos.SelectedRow.RowIndex);
            DataKey keysTurmaID = GridViewTurma.DataKeys[IndexGridViewTurma];
            DataKey keysAlunoID = GridViewAlunos.DataKeys[IndexGridViewAluno];
            string IdTurma = keysTurmaID.Value.ToString();
            string IdAluno = keysAlunoID.Value.ToString();
            DAL.DALTurma dALTurma = new DAL.DALTurma();
            DAL.DALMatricula dALMatricula = new DAL.DALMatricula();
            if (dALMatricula.VagaDisponivel(IdTurma))
            {
                matricula = new Modelo.Matricula(int.Parse(IdAluno), int.Parse(IdTurma), 1, DateTime.Now);
                dALMatricula.Insert(matricula);
                Session["matricula"] = matricula;
            }
            else
            {


            }
        }
    }
}