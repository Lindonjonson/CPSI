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

        protected void Button_Validar_Click(object sender, EventArgs e)
        {
            bool PermitirEnvio = false;
            if (!String.IsNullOrEmpty(TxtNomeTurma.Text))
            {
                TxtNomeTurma.ReadOnly = true;
                TxtNomeTurma.BorderColor = System.Drawing.Color.Green;
                PermitirEnvio = true;
            }
            else
            {
                PermitirEnvio = false;
                TxtNomeTurma.BorderColor = System.Drawing.Color.Red;
            }
            if((!String.IsNullOrEmpty(TxtAno.Text)) && (int.TryParse(TxtAno.Text,out int ano)))
            {
                TxtAno.ReadOnly = true;
                TxtAno.BorderColor = System.Drawing.Color.Green;
                PermitirEnvio = true;
            }
            else
            {
                PermitirEnvio = false;
                TxtAno.BorderColor = System.Drawing.Color.Red;
            }
            if (!String.IsNullOrEmpty(TxtHorário.Text))
            {
                TxtHorário.ReadOnly = true;
                TxtHorário.BorderColor = System.Drawing.Color.Green;
                PermitirEnvio = true;
            }
            else
            {
                PermitirEnvio = false;
                TxtHorário.BorderColor = System.Drawing.Color.Red;
            }
            if ((!String.IsNullOrEmpty(CalendarDataInicio.Text)) && (DateTime.TryParse(CalendarDataInicio.Text,out DateTime datainicio)))
            {
                CalendarDataInicio.ReadOnly = true;
                CalendarDataInicio.BorderColor = System.Drawing.Color.Green;
                PermitirEnvio = true;
            }
            else
            {
                PermitirEnvio = false;
                CalendarDataInicio.BorderColor = System.Drawing.Color.Red;
            }
            if ((!String.IsNullOrEmpty(CalendarDataFim.Text)) && (DateTime.TryParse(CalendarDataFim.Text, out DateTime datafim)))
            {
                CalendarDataFim.ReadOnly = true;
                CalendarDataFim.BorderColor = System.Drawing.Color.Green;
                PermitirEnvio = true;
            }
            else
            {
                PermitirEnvio = false;
                CalendarDataFim.BorderColor = System.Drawing.Color.Red;
            }
             if((!String.IsNullOrEmpty(TxtNumVagas.Text)) && (int.TryParse(TxtNumVagas.Text,out int numVagas)))
            {
                TxtNumVagas.ReadOnly = true;
                TxtNumVagas.BorderColor = System.Drawing.Color.Green;
                PermitirEnvio = true;
            }
            else
            {
                PermitirEnvio = false;
                TxtNumVagas.BorderColor = System.Drawing.Color.Red;
            }
            Button_Alterar_Editar.Visible = true;
            Button_Alterar_Inserir.Visible = true;
            if (PermitirEnvio)
            {
                Button_Validar_Atualizar.Visible = false;
                button_Atualizar.Visible = true;
                Button_Validar_Inserir.Visible = false;
                button_Inserir.Visible = true;
 
            }



        }

        protected void Alterar_Click(object sender, EventArgs e)
        {

                TxtNomeTurma.ReadOnly = false; ;
                TxtNomeTurma.BorderColor = System.Drawing.Color.White;
                TxtAno.ReadOnly = false;
                TxtAno.BorderColor = System.Drawing.Color.White;
                TxtHorário.ReadOnly = false;
                TxtHorário.BorderColor = System.Drawing.Color.White;
                CalendarDataInicio.ReadOnly = false;
                CalendarDataInicio.BorderColor = System.Drawing.Color.White;            
                CalendarDataFim.ReadOnly = false;
                CalendarDataFim.BorderColor = System.Drawing.Color.White;
                TxtNumVagas.ReadOnly = false;
                TxtNumVagas.BorderColor = System.Drawing.Color.White;
                Button_Validar_Atualizar.Visible = true;
                button_Atualizar.Visible =false;
                Button_Validar_Inserir.Visible = true;
                button_Inserir.Visible = false;




        }
    }
}