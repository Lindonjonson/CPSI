using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Admin.Turma
{
    public partial class WebFormGerenciarTurma : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void InserirTurma_Click(object sender, EventArgs e)
        {
            DAL.DALTurma InsertTurma = new DAL.DALTurma();
            Modelo.Turma Turma = new Modelo.Turma(int.Parse(TxtIdTurma.Text),TxtNomeTurma.Text,
                int.Parse(TxtAno.Text),TxtHorário.Text,CalendarDataInicio.SelectedDate.Date,CalendarDataFim.SelectedDate.Date,int.Parse(TxtNumVagas.Text),
                int.Parse(DropDownListDisciplina.SelectedItem.Value));
            InsertTurma.Insert(Turma);
            Response.Redirect("~//Admin//Turma//WebFormGerenciarTurma.aspx");

        }

        protected void Turmas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                DAL.DALTurma Delete = new DAL.DALTurma();
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                string IDTurma = GridViewTurmas.Rows[index].Cells[0].Text;
                Delete.Delete(IDTurma);
                Response.Redirect("~//Admin//Turma//WebFormGerenciarTurma.aspx");
            }
            if (e.CommandName == "Editar")
            {

                DAL.DALTurma Insert = new DAL.DALTurma();
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                string IDTurma = GridViewTurmas.Rows[index].Cells[0].Text;
                Response.Redirect("~//Admin//Turma//WebFormEditarTurma.aspx?ID=" + IDTurma);

            }
        }
    }
}