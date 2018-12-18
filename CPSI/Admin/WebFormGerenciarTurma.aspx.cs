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
                DAL.DALTurma dALTurma = new DAL.DALTurma();
                turma = dALTurma.Select(Session["IdTurma"].ToString());

                button_Atualizar.Visible = true;
                if (!IsPostBack)
                {   
                    TxtNomeTurma.Text = turma.NomeTurma;
                    TxtAno.Text = turma.ano.ToString();
                    TxtHorário.Text = turma.horario;
                    CalendarDataInicio.SelectedDate = turma.DataInicio;
                    CalendarDataFim.SelectedDate = turma.DataFim;
                    TxtNumVagas.Text = turma.QtdVagas.ToString();
                    DropDownListDisciplina.SelectedIndex = turma.IdDisciplina;

                }
            }
            else
            {
                button_Salvar.Visible = true;

            }
        }

        protected void InserirTurma_Click(object sender, EventArgs e)
        {
            DAL.DALTurma dALTurma = new DAL.DALTurma();
            Modelo.Turma turma = new Modelo.Turma(0, TxtNomeTurma.Text,
            int.Parse(TxtAno.Text), TxtHorário.Text, CalendarDataInicio.SelectedDate, CalendarDataFim.SelectedDate, int.Parse(TxtNumVagas.Text),
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
            turma.DataInicio=CalendarDataInicio.SelectedDate;
            turma.DataFim = CalendarDataFim.SelectedDate;
            turma.QtdVagas = int.Parse(TxtNumVagas.Text);
            turma.IdDisciplina =int.Parse(DropDownListDisciplina.SelectedItem.Value);
            dALTurma.Update(turma);
            Response.Redirect("~/Admin/WebFormVisualizacaoTurma.aspx");

        }


    }
}