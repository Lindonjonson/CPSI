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
            
        }

        protected void Pesquisar_Click(object sender, EventArgs e)
        {
            
        }

      
        protected void GridViewTurma_SelectedIndexChanged(object sender, EventArgs e)
        {

            int IndexGridViewTurma = Convert.ToInt32(GridViewTurma.SelectedRow.RowIndex);
            DataKey keysTurmaID = GridViewTurma.DataKeys[IndexGridViewTurma];
            string IdTurma = keysTurmaID.Value.ToString();
            DAL.DALTurma DalTurma = new DAL.DALTurma();
            LabelTurma.Text = DalTurma.Select(IdTurma).nomeTurma;
            LabelDataInicio.Text= DalTurma.Select(IdTurma).dataInicio.ToShortDateString();
            LabelDataFim.Text = DalTurma.Select(IdTurma).dataFim.ToShortDateString();
            VerificarDisponibilidade();
            PanelSelecaoTurma.Visible = false;
            PanelTurma.Visible = true;
        }

        protected void GridViewAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IndexGridViewAluno = Convert.ToInt32(GridViewAlunos.SelectedRow.RowIndex);
            DataKey keysAlunoID = GridViewAlunos.DataKeys[IndexGridViewAluno];
            string IdAluno = keysAlunoID.Value.ToString();
            DAL.DALAluno DalAluno = new DAL.DALAluno();
            LabelAlunoNome.Text = DalAluno.select(IdAluno).alunoNome;
            LabelAlunoCPF.Text = DalAluno.select(IdAluno).cpf;
            LabelBoxAlunoRG.Text = DalAluno.select(IdAluno).rg;
            PanelSelecaoAluno.Visible = false;
            PanelAluno.Visible = true;

        }
        protected void Button_CancelarSelecaoTurma_Click(object sender, EventArgs e)
        {
            PanelSelecaoTurma.Visible = true;
            PanelTurma.Visible = false;
        }

        protected void Button_CancelarSelecaoAluno_Click(object sender, EventArgs e)
        {
            PanelSelecaoAluno.Visible = true;
            PanelAluno.Visible = false;
        }
        public void CarregarDocumentosDisciplina(string idDisciplina)
        {
            CheckBoxListDocumentoDisciplina.DataSource = new DAL.DALDocumentoDisciplina().selectALLData(idDisciplina);
            CheckBoxListDocumentoDisciplina.DataBind();
           

        }
       
        protected void VerificarDisponibilidade()
        {
            PanelMatricular.Visible = false;
            PanelListaEspera.Visible = false;
            int IndexGridViewTurma = Convert.ToInt32(GridViewTurma.SelectedRow.RowIndex);
            DataKey keysTurmaID = GridViewTurma.DataKeys[IndexGridViewTurma];
            string IdTurma = keysTurmaID.Value.ToString();
            DAL.DALTurma DalTurma = new DAL.DALTurma();
            DAL.DALMatricula dALMatricula = new DAL.DALMatricula();
            if (dALMatricula.VagaDisponivel(IdTurma))
            {
                CarregarDocumentosDisciplina(IdTurma);
                LabelTurmaStatus.Visible = false;
                PanelMatricular.Visible = true;

            }
            else
            {
                LabelTurmaStatus.Visible = true;
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
            try
            {
                dalMatricula.Insert(matricula);
            }
            catch(Exception ex)
            {

                LiteralErro.Text = ex.Message;
                LiteralErro.Visible = true;
                
                
            }
            
            DAL.DALAlunoDocumento dalAlunoDocumento = new DAL.DALAlunoDocumento(); 
            foreach(ListItem I in CheckBoxListDocumentoDisciplina.Items)
            {
                 if (I.Selected) dalAlunoDocumento.insert(new Modelo.AlunoDocumento(Convert.ToInt32(IdAluno), Convert.ToInt32(I.Value)));
             
            }
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