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
            Modelo.Turma Turma = new Modelo.Turma(0,TxtNomeTurma.Text,
                int.Parse(TxtAno.Text),TxtHorário.Text,CalendarDataInicio.SelectedDate.Date,CalendarDataFim.SelectedDate.Date,int.Parse(TxtNumVagas.Text),
                int.Parse(DropDownListDisciplina.SelectedItem.Value));
            InsertTurma.Insert(Turma);
            Response.Redirect("~//Admin//WebFormGerenciarTurma.aspx");

        }

        protected void Turmas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Excluir")
            {
                DAL.DALTurma Delete = new DAL.DALTurma();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                DataKey keys = GridViewTurmas.DataKeys[index];
                string id = keys.Value.ToString();

                Delete.Delete(id);
                Response.Redirect("~//Admin//WebFormGerenciarTurma.aspx");
            }
            if (e.CommandName == "Editar")
            {

                DAL.DALTurma Insert = new DAL.DALTurma();
                int index = Convert.ToInt32(e.CommandArgument.ToString());

                DataKey keys = GridViewTurmas.DataKeys[index];
                string id = keys.Value.ToString();

                Response.Redirect("~//Admin//WebFormEditarTurma.aspx?ID=" + id);

            }
        }
    }
}