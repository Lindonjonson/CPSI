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

       
        protected void Page_Load(object sender, EventArgs e)
        {
            PanelListaEspera.Visible = false;
            PanelMatricular.Visible = false;
        }

        protected void Pesquisar_Click(object sender, EventArgs e)
        {
            
        }

      
        protected void GridViewTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewTurma.SelectedRow.BackColor = System.Drawing.Color.AliceBlue;
            
        }

        protected void GridViewAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

            GridViewAlunos.SelectedRow.BackColor = System.Drawing.Color.AliceBlue;
            
        }

        

        

        protected void VerificarDisponibilidade_Click(object sender, EventArgs e)
        {
            int IndexGridViewTurma = Convert.ToInt32(GridViewTurma.SelectedRow.RowIndex);
            int IndexGridViewAluno = Convert.ToInt32(GridViewAlunos.SelectedRow.RowIndex);
            DataKey keysTurmaID = GridViewTurma.DataKeys[IndexGridViewTurma];
            DataKey keysAlunoID = GridViewAlunos.DataKeys[IndexGridViewAluno];
            string IdTurma = keysTurmaID.Value.ToString();
            string IdAluno = keysAlunoID.Value.ToString();
            DAL.DALTurma DalTurma = new DAL.DALTurma();
            DAL.DALAluno DalAluno = new DAL.DALAluno();
            DAL.DALMatricula dALMatricula = new DAL.DALMatricula();
            if (dALMatricula.VagaDisponivel(IdTurma))
            {
                TextBoxMatricularAluno.Text = DalAluno.select(IdAluno).alunoNome;
                TextBoxMatricularTurma.Text = DalTurma.Select(IdTurma).nomeTurma;
                PanelMatricular.Visible = true;
            }
            else
            {

                TextBoxEsperaAluno.Text = DalAluno.select(IdAluno).alunoNome;
                TextBoxEsperaTurma .Text = DalTurma.Select(IdTurma).nomeTurma;
                PanelListaEspera.Visible = true;

            }


        }

        protected void ButtonMatricular_Click(object sender, EventArgs e)
        {
            int IndexGridViewTurma = Convert.ToInt32(GridViewTurma.SelectedRow.RowIndex);
            int IndexGridViewAluno = Convert.ToInt32(GridViewAlunos.SelectedRow.RowIndex);
            DataKey keysTurmaID = GridViewTurma.DataKeys[IndexGridViewTurma];
            DataKey keysAlunoID = GridViewAlunos.DataKeys[IndexGridViewAluno];
            int IdTurma = Convert.ToInt32(keysTurmaID.Value);
            int IdAluno = Convert.ToInt32(keysAlunoID.Value);
            Modelo.Matricula matricula = new Modelo.Matricula(IdAluno, IdTurma, 1, DateTime.Now);
            DAL.DALMatricula dalMatricula = new DAL.DALMatricula();
            dalMatricula.Insert(matricula);
            Session["matricula"] = matricula;
            Response.Redirect("~/Matricula/WebFormImprimirFichaInscricao.aspx");
        }

        protected void ButtonListaEspera_Click(object sender, EventArgs e)
        {
            int IndexGridViewTurma = Convert.ToInt32(GridViewTurma.SelectedRow.RowIndex);
            int IndexGridViewAluno = Convert.ToInt32(GridViewAlunos.SelectedRow.RowIndex);
            DataKey keysTurmaID = GridViewTurma.DataKeys[IndexGridViewTurma];
            DataKey keysAlunoID = GridViewAlunos.DataKeys[IndexGridViewAluno];
            int IdTurma = Convert.ToInt32(keysTurmaID.Value);
            int IdAluno = Convert.ToInt32(keysAlunoID.Value);
            Modelo.ListaEspera listaEspera = new Modelo.ListaEspera(IdTurma,IdAluno,DateTime.Now);
            new DAL.DALListaEspera().Insert(listaEspera);
            Response.Redirect("~/Matricula/WebFormMatricular.aspx");
        }
        protected void ButtonCancelarMatricula_Click()
        {
            PanelListaEspera.Visible = false;
            PanelMatricular.Visible = false;

        }
    }
}