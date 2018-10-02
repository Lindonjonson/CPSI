using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CPSI.Matricula
{
    public partial class WebFormGerenciarAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey dataKeyID = GridViewAlunos.DataKeys[index];
                string ID=dataKeyID.Values["IdAluno"].ToString();
                Session["IdAluno"] = ID;
                Response.Redirect("~//Matricula//WebFormEditarAluno.aspx");
               

            }
            if (e.CommandName == "Excluir")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                DataKey dataKeyID = GridViewAlunos.DataKeys[index];
                string ID = dataKeyID.Values["IdAluno"].ToString();
                DAL.DALAluno Delete = new DAL.DALAluno();
                Delete.Delete(ID);
                Response.Redirect("~//Matricula//WebFormGerenciarAluno.aspx");


            }

        }

        protected void InserirAluno_Click(object sender, EventArgs e)
        {
          
            Modelo.Aluno Aluno = new Modelo.Aluno(0,TextBoxAlunoNome.Text,CalendarDataNascimento.SelectedDate.Date,TextBoxCpf.Text
                                                  ,TextBoxRg.Text,TextBoxRGOrgaox.Text,int.Parse(TextBoxEstadoCivil.Text),
                                                  TextBoxNaturalidade.Text,TextBoxNaturalidadeEstado.Text,TextBoxEndereco.Text,
                                                  TextBoxCidade.Text,TextBoxEstado.Text,TextBoxTelefone1.Text,TextBoxTelefone2.Text,TextBoxContato.Text,TextBoxContatoTelefone.Text);
            DAL.DALAluno Insert = new DAL.DALAluno();
            Insert.Insert(Aluno);
            Response.Redirect("~//Matricula//WebFormGerenciarAluno.aspx");

        }
    }
}