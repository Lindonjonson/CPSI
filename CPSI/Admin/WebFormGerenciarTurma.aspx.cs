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
            
          
            if (!(Session["IdTurma"] == null))
            {
                button_Atualizar.Visible = true;
                button_Excluir.Visible = true;
                Panel_ButtonExcluir.Visible = true;
                DAL.DALTurma dALTurma = new DAL.DALTurma();
                turma = dALTurma.Select(Session["IdTurma"].ToString());
                LabelTurma.Text = turma.NomeTurma;
                if (!IsPostBack)
                {   
                    TxtNomeTurma.Text = turma.NomeTurma;
                    TxtAno.Text = turma.ano.ToString();
                    TxtHorário.Text = turma.horario;
                    CalendarDataInicio.Text = turma.DataInicio.ToShortDateString();
                    CalendarDataFim.Text = turma.DataFim.ToShortDateString();
                    TxtNumVagas.Text = turma.QtdVagas.ToString();
                    DropDownListDisciplina.SelectedValue = turma.IdDisciplina.ToString();

                }
            }
            else
            {
                button_Inserir.Visible = true;

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
            turma.NomeTurma = TxtNomeTurma.Text;
            turma.ano = int.Parse(TxtAno.Text);
            turma.horario = TxtHorário.Text;
            turma.DataInicio = DateTime.Parse(CalendarDataInicio.Text);
            turma.DataFim = DateTime.Parse(CalendarDataFim.Text);
            turma.QtdVagas = int.Parse(TxtNumVagas.Text);
            turma.IdDisciplina =int.Parse(DropDownListDisciplina.SelectedItem.Value);
            dALTurma.Update(turma);
            Session.Remove("IdTurma");
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");
            

        }

        protected void Excluir_Click(object sender, EventArgs e)
        {
            DAL.DALTurma Delete = new DAL.DALTurma();
            Delete.Delete(turma.IdTurma.ToString());
            Session.Remove("IdTurma");
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");
            
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Session.Remove("IdTurma");
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");
           
        }
    }
}