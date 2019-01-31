using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin
{
    public partial class WebFormVisualizarTurmas : System.Web.UI.Page
    {
        Modelo.Turma turma = new Modelo.Turma();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!(Session["IdTurma"]==null)) 
            {
                CarregarItemEdicao();
                PanelAlterarTurma.Visible = true;
            }
            else
            {
                PanelAdicionarTurma.Visible = true;

            }
        }

        protected void InserirTurma_Click(object sender, EventArgs e)
        {
            DAL.DALTurma dALTurma = new DAL.DALTurma();
            Modelo.Turma turma = new Modelo.Turma(0, TxtNomeTurma.Text,
            int.Parse(TxtAno.Text), TxtHorário.Text, DateTime.Parse(CalendarDataInicio.Text),DateTime.Parse(CalendarDataFim.Text), int.Parse(TxtNumVagas.Text),
            int.Parse(DropDownListDisciplina.SelectedItem.Value));
            dALTurma.Insert(turma);
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");
        }
        protected void AtualizarTurma_Click(object sender, EventArgs e)
        {
            DAL.DALTurma dALTurma = new DAL.DALTurma();
            turma.nomeTurma = TxtNomeTurma.Text;
            turma.ano = int.Parse(TxtAno.Text);
            turma.horario = TxtHorário.Text;
            turma.dataInicio = DateTime.Parse(CalendarDataInicio.Text);
            turma.dataFim = DateTime.Parse(CalendarDataFim.Text);
            turma.qtdVagas = int.Parse(TxtNumVagas.Text);
            turma.idDisciplina =int.Parse(DropDownListDisciplina.SelectedItem.Value);
            dALTurma.Update(turma);
            Session.Remove("IdTurma");
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");
            

        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            DAL.DALTurma Delete = new DAL.DALTurma();
            Delete.Delete(turma.idTurma.ToString());
            Session.Remove("IdTurma");
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");
            
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Session.Remove("IdTurma");
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");

        }
        public void CarregarItemEdicao()
        {
            DAL.DALTurma dALTurma = new DAL.DALTurma();
            turma = dALTurma.Select(Session["IdTurma"].ToString());
            if (!IsPostBack)
            {
                TxtNomeTurma.Text = turma.nomeTurma;
                TxtAno.Text = turma.ano.ToString();
                TxtHorário.Text = turma.horario;
                CalendarDataInicio.Text = turma.dataInicio.ToShortDateString();
                CalendarDataFim.Text = turma.dataFim.ToShortDateString();
                TxtNumVagas.Text = turma.qtdVagas.ToString();
                DropDownListDisciplina.SelectedValue = turma.idDisciplina.ToString();

            }

        }
    }
}