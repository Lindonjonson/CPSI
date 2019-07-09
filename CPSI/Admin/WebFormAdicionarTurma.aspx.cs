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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InserirTurma_Click(object sender, EventArgs e)
        {
            DAL.DALTurma InsertTurma = new DAL.DALTurma();
            Modelo.Turma Turma = new Modelo.Turma(0, TxtNomeTurma.Text,
            int.Parse(TxtAno.Text), TxtHorário.Text, DateTime.Parse(CalendarDataInicio.Text), DateTime.Parse(CalendarDataFim.Text), int.Parse(TxtNumVagas.Text),
            int.Parse(DropDownListDisciplina.SelectedItem.Value));
            InsertTurma.Insert(Turma);
            Response.Redirect("~//Admin//WebFormGerenciarTurma.aspx");
        }
    }
}