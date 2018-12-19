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

        int idTurma, IdAluno;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Pesquisar_Click(object sender, EventArgs e)
        {
            
        }

        protected void PesquisarAluno_Click(object sender, EventArgs e)
        {
            DAL.DALAluno dALAluno = new DAL.DALAluno();
            GridViewAlunos.DataSource = dALAluno.SelectALLFiltro(TextBoxFiltroAluno.Text);
            GridViewAlunos.DataBind();
        }

        protected void GridViewTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewTurma.SelectedRow.BackColor = System.Drawing.Color.OrangeRed;
            idTurma = GridViewTurma.SelectedRow.RowIndex;
        
        }

        protected void GridViewAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewAlunos.SelectedRow.BackColor = System.Drawing.Color.OrangeRed;
            IdAluno = GridViewAlunos.SelectedRow.RowIndex;
        }

        protected void Click_Matricular(object sender, EventArgs e)
        {
            int IndexGridViewTurma = idTurma;
            int IndexGridViewAluno = Convert.ToInt32(GridViewAlunos.SelectedRow.RowIndex);
            DataKey keysTurmaID = GridViewTurma.DataKeys[IndexGridViewTurma];
            DataKey keysAlunoID = GridViewAlunos.DataKeys[IndexGridViewAluno];
            string IdTurma = keysTurmaID.Value.ToString();
            string IdAluno = keysAlunoID.Value.ToString();
            DAL.DALTurma dALTurma = new DAL.DALTurma();
            DAL.DALMatricula dALMatricula = new DAL.DALMatricula();
            if (dALMatricula.VagaDisponivel(IdTurma))
            {
                
                dALMatricula.Insert(new Modelo.Matricula(int.Parse(IdAluno), int.Parse(IdTurma), 1, DateTime.Now));
                
            }
            else
            {
               

            }

        }
    }
}